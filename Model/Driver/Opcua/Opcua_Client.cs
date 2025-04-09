using Camera_Entrada.Model.DataBase.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Camera_Entrada.ViewModel.Variaveis;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Xml.Linq;
using Opc.Ua.Client;
using Opc.Ua;
using System.Threading;
using Camera_Entrada.ViewModel.Variaveis;
using System.Net.Sockets;
using System.Net;

namespace Camera_Entrada.Model.Driver.Opcua
{
    internal class Opcua_Client
    {
        public static (string host, int port) ExtractHostAndPort(string endpoint)
        {
            // Verifica se a string começa com opc.tcp://
            const string prefix = "opc.tcp://";
            if (!endpoint.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException("Endpoint inválido: não inicia com 'opc.tcp://'");
            }

            // Remove o prefixo inicial
            string withoutScheme = endpoint.Substring(prefix.Length);

            // Encontra o índice do ':', separador entre host e porta
            int colonIndex = withoutScheme.IndexOf(':');
            if (colonIndex < 0)
            {
                throw new ArgumentException("Endpoint inválido: não foi encontrada a porta após o host.");
            }

            // A partir do primeiro ':', pode existir um '/' indicando caminho adicional
            int slashIndex = withoutScheme.IndexOf('/', colonIndex);
            string hostPart;
            string portPart;

            if (slashIndex > 0)
            {
                // Temos um path adicional após a porta
                hostPart = withoutScheme.Substring(0, colonIndex);
                portPart = withoutScheme.Substring(colonIndex + 1, slashIndex - (colonIndex + 1));
            }
            else
            {
                // Não há path adicional, a porta vai até o fim da string
                hostPart = withoutScheme.Substring(0, colonIndex);
                portPart = withoutScheme.Substring(colonIndex + 1);
            }

            // Converte a porta para inteiro
            if (!int.TryParse(portPart, out int port))
            {
                throw new ArgumentException("A porta não é um número válido.");
            }

            return (hostPart, port);
        }
        private static bool IsRtspReachable(string ip, int port, int timeoutMs)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var result = client.BeginConnect(ip, port, null, null);
                    bool success = result.AsyncWaitHandle.WaitOne(timeoutMs);
                    if (!success)
                    {
                        return false;
                    }
                    client.EndConnect(result);
                    return true;
                }
            }
            catch
            {
                return true;
            }
        }
        public string ExtrairIP(string endereco)
        {
            var ipSemProtocolo = endereco.Replace("opc.tcp://", ""); // Remove o protocolo
            var ipFinal = ipSemProtocolo.Split(':')[0]; // Remove a porta e qualquer coisa após ela
            return ipFinal;
        }
        private string serverURL = GVRL.Parametros.sUrl_Opcua; // Pega a URL do banco de dados
        //private string serverURL = "opc.tcp://Projetos05.sglass.local:53530/OPCUA/SimulationServer";
        bool IP_OPC_UA_Status = false;



        public void Start_OPCUA()
        {

            var Host = ExtractHostAndPort(serverURL);
  


            if (!IsRtspReachable(Host.host, Host.port, 3000)) // Timeout de 3 segundos
            {
                System.Diagnostics.Debug.WriteLine("Não foi possível acessar o server OPCUA (host inatingível ou porta fechada).");
                GVL.StatusOpcua.xStatusOpcua = false;
                GVL.StatusOpcua.sTempoCheckIp = "Falha na Conexão";
                return;
            }

            try
            {
                Opc.Ua.ApplicationConfiguration configuration = new Opc.Ua.ApplicationConfiguration();
                ClientConfiguration clientConfiguration = new ClientConfiguration();
                configuration.ClientConfiguration = clientConfiguration;
                Stopwatch stopwatch_Total = Stopwatch.StartNew();
                EndpointDescription endpointDescription = CoreClientUtils.SelectEndpoint(serverURL, false);
                EndpointConfiguration endpointConfiguration = EndpointConfiguration.Create(configuration);
                ConfiguredEndpoint endpoint = new ConfiguredEndpoint(null, endpointDescription, endpointConfiguration);
                bool updateBeforeConnect = false;
                bool checkDomain = false;
                string sessionName = configuration.ApplicationName;
                uint sessionTimeout = 60000;
                UserIdentity user = new UserIdentity();
                List<string>? preferredLocales = null;

                // Create the session
                Session session = Session.Create(
                    configuration,
                    endpoint,
                    updateBeforeConnect,
                    checkDomain,
                    sessionName,
                    sessionTimeout,
                    user,
                    preferredLocales
                ).Result;

                List<ReadValueId> nodesToRead_GVL_ClpCamera = new List<ReadValueId>
                {
                    new ReadValueId { NodeId = NodeId.Parse("ns=2;s=Application.GVL_ClpSuper.xIniciaRelatorioCameraMe"), AttributeId = Attributes.Value },//0
                    new ReadValueId { NodeId = NodeId.Parse("ns=2;s=Application.GVL_ClpSuper.uNumeroCargaRelMe"), AttributeId = Attributes.Value },//1
                };

                RequestHeader requestHeader_GVL_ClpCamera = new RequestHeader();
                double maxAge_GVL_ClpCamera = 0;
                TimestampsToReturn timestampsToReturn_GVL_ClpCamera = TimestampsToReturn.Both;
                DataValueCollection? results_GVL_ClpCamera = null;
                DiagnosticInfoCollection? diagnosticInfos_GVL_ClpCamera = null;

                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();


                while (GVL.ExitProgram.xContinueRunning == true)
                {
                    try
                    {
                        Stopwatch sw_TempoCheckIp = Stopwatch.StartNew();
                        GVL.StatusOpcua.sTempoCheckIp = "Em Leitura";

                        int timeout = 1000;
                        string host = ExtrairIP(serverURL);
                        byte[] buffer = new byte[32];
                        PingReply reply = pingSender.Send(host, timeout, buffer, options);

                        if (reply.Status == IPStatus.Success)
                        {
                            IP_OPC_UA_Status = true;
                            GVL.StatusOpcua.xStatusIp = true;
                        }
                        else
                        {
                            IP_OPC_UA_Status = false;
                            GVL.StatusOpcua.xStatusIp = false;
                        }

                        sw_TempoCheckIp.Stop();
                        TimeSpan el_TempoCheckIp = sw_TempoCheckIp.Elapsed;
                        GVL.StatusOpcua.sTempoCheckIp = el_TempoCheckIp.Milliseconds.ToString() + ":" + el_TempoCheckIp.Microseconds.ToString();

                        if (IP_OPC_UA_Status == true)
                        {
                            try
                            {
                                Stopwatch sw_TempoRequesicaoOpcua = Stopwatch.StartNew();
                                GVL.StatusOpcua.sTempoRequesicaoOpcua = "Em requisição";


                                Leitura_OPCUA();
                                Atribuir_OPCUA();
                                Escrita_OPCUA();
                                //session.Close();
                                System.Diagnostics.Debug.WriteLine("Leitura Escrita com sucesso");
                                System.Diagnostics.Debug.WriteLine("uNumeroCargaRelEntrada" + ": " + GVL.Opcua.Read.ClpCamera.uNumeroCargaRelEntrada.ToString());
                                System.Diagnostics.Debug.WriteLine("xIniciaRelatorioCameraEntrada" + ": " + GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada.ToString());

                                sw_TempoRequesicaoOpcua.Stop();
                                TimeSpan el_TempoRequesicaoOpcua = sw_TempoRequesicaoOpcua.Elapsed;
                                GVL.StatusOpcua.sTempoRequesicaoOpcua = el_TempoRequesicaoOpcua.Milliseconds.ToString() + ":" + el_TempoRequesicaoOpcua.Microseconds.ToString();
                                GVL.StatusOpcua.xStatusOpcua = true;
                            }
                            catch
                            {
                                GVL.StatusOpcua.sTempoRequesicaoOpcua = "Falha na requisição";
                                GVL.StatusOpcua.xStatusOpcua = false;
                                System.Diagnostics.Debug.WriteLine("Erro na leitura do OPC UA - Nível 1 - Execução de leitura e escrita");
                                return;
                            }
                        }
                        Thread.Sleep(1000);
                    }
                    catch
                    {
                        GVL.StatusOpcua.sTempoRequesicaoOpcua = "Falha na conexão";
                        GVL.StatusOpcua.sTempoCheckIp = "Falha na conexão";
                        GVL.StatusOpcua.xStatusOpcua = false;
                        return;
                        System.Diagnostics.Debug.WriteLine("Erro na leitura do OPC UA - Nível 2 - Conexão");
                    }
                }

                void Leitura_OPCUA()
                {
                    ReadValueIdCollection nodesToReadCollection_GVL_ClpCamera = new ReadValueIdCollection(nodesToRead_GVL_ClpCamera);
                    session.Read(
                                requestHeader_GVL_ClpCamera,
                                maxAge_GVL_ClpCamera,
                                timestampsToReturn_GVL_ClpCamera,
                                nodesToReadCollection_GVL_ClpCamera,
                                out results_GVL_ClpCamera,
                                out diagnosticInfos_GVL_ClpCamera
                                );
                }
                void Escrita_OPCUA()
                {
                    try
                    {
                        if (GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada == true)
                        {
                            GVL.Opcua.Write.ClpCamera.Write_xIniciaRelatorioCameraEntrada = false;

                            if(GVL.Opcua.Write.ClpCamera.xIniciaRelatorioCameraEntrada == null)
                            {
                                return;
                            }

                            bool valorParaEscrever = (bool)GVL.Opcua.Write.ClpCamera.xIniciaRelatorioCameraEntrada;

                            // Criar o objeto WriteValue
                            WriteValue writeValue = new WriteValue
                            {
                                NodeId = NodeId.Parse("ns=2;s=Application.GVL_ClpSuper.xIniciaRelatorioCameraMe"),
                                AttributeId = Attributes.Value,
                                Value = new DataValue(new Variant(valorParaEscrever))
                            };

                            WriteValueCollection nodesToWrite = new WriteValueCollection
                            {
                                writeValue
                            };

                            StatusCodeCollection results = null;
                            DiagnosticInfoCollection diagnosticInfos = null;

                            try
                            {
                                session.Write(
                                    null,
                                    nodesToWrite,
                                    out results,
                                    out diagnosticInfos
                                );
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Erro ao escrever no servidor OPC UA: {ex.Message}");
                                return;
                            }
                        }
                    }
                    catch
                    {
                        System.Diagnostics.Debug.WriteLine("Erro na escrita do OPC UA - Nível 3 - Execução da criação do driver");
                        return;
                    }
                }
                void Atribuir_OPCUA()
                {



                    var xIniciaRelatorioCameraEntrada = results_GVL_ClpCamera[0].Value;

                    if (xIniciaRelatorioCameraEntrada != null)
                    {
                        GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada = (bool)xIniciaRelatorioCameraEntrada;
                    }
                    else if (xIniciaRelatorioCameraEntrada == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Erro: xIniciaRelatorioCameraEntrada is null");
                        return;
                    }

                    var uNumeroCargaRelEntrada = results_GVL_ClpCamera[1].Value;

                    if (uNumeroCargaRelEntrada != null)
                    {
                        GVL.Opcua.Read.ClpCamera.uNumeroCargaRelEntrada = (short)(UInt16)uNumeroCargaRelEntrada;
                    }
                    else if (uNumeroCargaRelEntrada == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Erro: uNumeroCargaRelEntrada is null");
                        return;
                    }

                }
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Erro na leitura do OPC UA - Nível 3 - Execução da criação do driver");
                GVL.StatusOpcua.xStatusOpcua = false;
                return;
                
            }
        }
    }
}
