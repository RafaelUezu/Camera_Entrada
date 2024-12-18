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

namespace Camera_Entrada.Model.Driver.Opcua
{
    internal class Opcua_Client
    {
        //private string serverURL = GVRL.Parametros.sUrl_Opcua; // Pega a URL do banco de dados
        private string serverURL = "opc.tcp://Projetos05.sglass.local:53530/OPCUA/SimulationServer";
        bool IP_OPC_UA_Status = false;

        public string ExtrairIP(string endereco)
        {
            var ipSemProtocolo = endereco.Replace("opc.tcp://", ""); // Remove o protocolo
            var ipFinal = ipSemProtocolo.Split(':')[0]; // Remove a porta e qualquer coisa após ela
            return ipFinal;
        }

        public void Start_OPCUA()
        {
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
                    new ReadValueId { NodeId = NodeId.Parse("ns=3;s=Application.GVL_ClpCamera.uNumeroCargaRelEntrada"), AttributeId = Attributes.Value },//0
                    new ReadValueId { NodeId = NodeId.Parse("ns=3;s=Application.GVL_ClpCamera.xIniciaRelatorioCameraEntrada"), AttributeId = Attributes.Value },//1
                };

                RequestHeader requestHeader_GVL_ClpCamera = new RequestHeader();
                double maxAge_GVL_ClpCamera = 0;
                TimestampsToReturn timestampsToReturn_GVL_ClpCamera = TimestampsToReturn.Both;
                DataValueCollection? results_GVL_ClpCamera = null;
                DiagnosticInfoCollection? diagnosticInfos_GVL_ClpCamera = null;

                while (GVL.ExitProgram.xContinueRunning == true)
                {
                    try
                    {
                        Ping pingSender = new Ping();
                        PingOptions options = new PingOptions();
                        int timeout = 1000;
                        string host = ExtrairIP(serverURL);
                        byte[] buffer = new byte[32];
                        PingReply reply = pingSender.Send(host, timeout, buffer, options);

                        if (reply.Status == IPStatus.Success)
                        {
                            IP_OPC_UA_Status = true;
                        }
                        else
                        {
                            IP_OPC_UA_Status = false;
                            IP_OPC_UA_Status = true; // Teste, tirar depois
                        }

                        if (IP_OPC_UA_Status == true)
                        {
                            try
                            {
                                Leitura_OPCUA();
                                Atribuir_OPCUA();
                                Escrita_OPCUA();
                                System.Diagnostics.Debug.WriteLine("Leitura Escrita com sucesso");
                                System.Diagnostics.Debug.WriteLine("uNumeroCargaRelEntrada" + ": " + GVL.Opcua.Read.ClpCamera.uNumeroCargaRelEntrada.ToString());
                                System.Diagnostics.Debug.WriteLine("xIniciaRelatorioCameraEntrada" + ": " + GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada.ToString());
                            }
                            catch
                            {
                                System.Diagnostics.Debug.WriteLine("Erro na leitura do OPC UA - Nível 1 - Execução de leitura e escrita");
                                return;
                            }
                        }
                        Thread.Sleep(1000);
                    }
                    catch
                    {
                        return;
                        System.Diagnostics.Debug.WriteLine("Erro na leitura do OPC UA - Nível 2 - Conexão");
                    }
                }

                void Leitura_OPCUA()
                {

                    // Leitura

                    Stopwatch stopwatch_Requisicao = Stopwatch.StartNew();

                    // Leitura do vetor B_RampaPatamar

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
                            bool valorParaEscrever = (bool)GVL.Opcua.Write.ClpCamera.xIniciaRelatorioCameraEntrada;

                            // Criar o objeto WriteValue
                            WriteValue writeValue = new WriteValue
                            {
                                NodeId = NodeId.Parse("ns=3;s=Application.GVL_ClpCamera.xIniciaRelatorioCameraEntrada"),
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

                    var uNumeroCargaRelEntrada = (short)(UInt16)results_GVL_ClpCamera[0].Value;

                    if (uNumeroCargaRelEntrada != null)
                    {
                        GVL.Opcua.Read.ClpCamera.uNumeroCargaRelEntrada = uNumeroCargaRelEntrada;
                    }
                    else if (uNumeroCargaRelEntrada == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Erro: uNumeroCargaRelEntrada is null");
                        return;
                    }

                    var xIniciaRelatorioCameraEntrada = (bool)results_GVL_ClpCamera[1].Value;

                    if (xIniciaRelatorioCameraEntrada != null)
                    {
                        GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada = xIniciaRelatorioCameraEntrada;
                    }
                    else if (xIniciaRelatorioCameraEntrada == null)
                    {
                        System.Diagnostics.Debug.WriteLine("Erro: xIniciaRelatorioCameraEntrada is null");
                        return;
                    }

                }
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Erro na leitura do OPC UA - Nível 3 - Execução da criação do driver");
                return;
            }
        }
    }
}
