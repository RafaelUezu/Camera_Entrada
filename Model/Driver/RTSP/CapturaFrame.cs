using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using Camera_Entrada.ViewModel.Variaveis;
using Emgu.CV;
using Emgu.CV.Structure;

namespace SeuNamespace
{
    public class RtspImageCapture
    {
        /// <summary>
        /// Captura um frame de um stream RTSP e salva como uma imagem no diretório especificado.
        /// </summary>
        /// <param name="rtspUrl">URL do stream RTSP.</param>
        /// <param name="outputDirectory">Diretório onde a imagem será salva.</param>
        /// <param name="outputFileName">Nome do arquivo de saída (ex: "snapshot.jpg").</param>
        /// <returns>true se a imagem for salva com sucesso; caso contrário, false.</returns>
        /// 

        public void Start_CaptureImageFromRtsp()
        {
            try
            {
                while (GVL.ExitProgram.xContinueRunning == true)
                {
                    try
                    {
                        string rtspUrl = GVRL.Parametros.sUrl_Camera;
                        string outputDirectory = GVRL.Parametros.sDiretorio_de_Imagens;
                        Uri uri = new Uri(rtspUrl);
                        string host = uri.Host; // 10.10.70.18, por exemplo
                        int port = uri.Port;    // 554, por exemplo

                        // Verifica a conectividade TCP antes de tentar abrir o stream
                        bool IpConected = IsRtspReachable(host, port, 6000);

                        
                        var Disparo_CaptureImageFromRtsp = GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada;
                        var Teste_CaptureImageFromRtsp = GVL.StatusCamera.xTesteIniciaRelatorioCameraEntrada;

                        if (IpConected)
                        {
                            GVL.StatusCamera.xStatusCamera = true;
                            if (Disparo_CaptureImageFromRtsp != null)
                            {
                                if ((bool)Disparo_CaptureImageFromRtsp == true)
                                {
                                    DateTime dataAtual = DateTime.Now;
                                    int NumeroCargaEntrada = (int)GVL.Opcua.Read.ClpCamera.uNumeroCargaRelEntrada;
                                    string IdCargaEntrada = MontaIdCarga(NumeroCargaEntrada);
                                    //Random rnd = new Random();
                                    //int valor = rnd.Next(1, 13); // Gera um inteiro entre 1 e 12
                                    //string valorFormatado = valor.ToString("00");
                                    //IdCargaEntrada = "11120" + valorFormatado + "2024";
                                    CaptureImageFromRtsp(rtspUrl, outputDirectory, IdCargaEntrada);
                                }
                            }
                            if (Teste_CaptureImageFromRtsp != null)
                            {
                                if ((bool)Teste_CaptureImageFromRtsp == true)
                                {

                                    CaptureImageFromRtsp(rtspUrl, outputDirectory, "ImagemTeste");
                                }
                            }
                        }
                        else
                        {
                            GVL.StatusCamera.xStatusCamera = false;
                        }
                        Thread.Sleep(1000);
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public string MontaIdCarga(int valor)
        {
            DateTime dataAtual = DateTime.Now;

            // Formata o valor com três dígitos
            string valorFormatado = valor.ToString("000");

            // Extrai o dia, mês e ano atual, já formatados com zeros à esquerda
            string dia = dataAtual.Day.ToString("00");
            string mes = dataAtual.Month.ToString("00");
            string ano = dataAtual.Year.ToString();

            // Concatena valor, dia, mês e ano
            string idCarga = valorFormatado + dia + mes + ano;

            return idCarga;
        }



        public static bool CaptureImageFromRtsp(string rtspUrl, string outputDirectory, string outputFileName)
        {
            try
            {
                Stopwatch sw_TempoCaptureImage = Stopwatch.StartNew();

                GVL.Opcua.Write.ClpCamera.xIniciaRelatorioCameraEntrada = false;
                GVL.Opcua.Write.ClpCamera.Write_xIniciaRelatorioCameraEntrada = false;
                GVL.StatusCamera.xTesteIniciaRelatorioCameraEntrada = false;
                // Extraindo IP da URL RTSP
                // Ex: rtsp://usuario:senha@10.10.70.18:554/cam/...
                Uri uri = new Uri(rtspUrl);
                string host = uri.Host; // 10.10.70.18, por exemplo
                int port = uri.Port;    // 554, por exemplo

                // Verifica a conectividade TCP antes de tentar abrir o stream

                if (!IsRtspReachable(host, port, 6000)) // Timeout de 3 segundos
                {
                    System.Diagnostics.Debug.WriteLine("Não foi possível acessar a câmera RTSP (host inatingível ou porta fechada).");
                    GVL.StatusCamera.xStatusCamera = false;
                    GVL.StatusCamera.sTempoRegistroCamera = "Falha na Conexão";
                    return false;
                }
                GVL.StatusCamera.xStatusCamera = true;
                // Cria o diretório se não existir
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                // Caminho completo da imagem
                string outputFileName_ext = outputFileName + ".jpg";
                string outputPath = Path.Combine(outputDirectory, outputFileName_ext);

                // Inicializa a captura
                using (VideoCapture capture = new VideoCapture(rtspUrl))
                {
                    using (Mat frame = new Mat())
                    {
                        capture.Read(frame);

                        if (!frame.IsEmpty)
                        {
                            frame.Save(outputPath);
                            GVL.StatusCamera.xStatusCamera = true;
                            GVL.StatusCamera.sIdUltimaCarga = outputFileName;
                            sw_TempoCaptureImage.Stop();
                            TimeSpan el_TempoCaptureImage = sw_TempoCaptureImage.Elapsed;
                            GVL.StatusCamera.sTempoRegistroCamera = el_TempoCaptureImage.Milliseconds.ToString() + ":" + el_TempoCaptureImage.Microseconds.ToString();
                            return true;
                        }
                        else
                        {
                            GVL.StatusCamera.xStatusCamera = false;
                            System.Diagnostics.Debug.WriteLine("Não foi possível capturar o frame do stream RTSP.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Ocorreu um erro ao capturar a imagem: " + ex.Message);
                return false;
            }
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
                return false;
            }
        }
    }
}
