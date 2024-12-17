using System;
using System.IO;
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
        public static bool CaptureImageFromRtsp(string rtspUrl, string outputDirectory, string outputFileName)
        {
            try
            {
                // Cria o diretório se não existir
                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                // Caminho completo da imagem
                outputFileName = outputFileName + ".jpg";
                string outputPath = Path.Combine(outputDirectory, outputFileName);

                // Inicializa a captura
                using (VideoCapture capture = new VideoCapture(rtspUrl))
                {
                    using (Mat frame = new Mat())
                    {
                        capture.Read(frame);

                        if (!frame.IsEmpty)
                        {
                            frame.Save(outputPath);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("Não foi possível capturar o frame do stream RTSP.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro ao capturar a imagem: " + ex.Message);
                return false;
            }
        }
    }
}
