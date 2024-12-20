using Camera_Entrada.Model.DataBase.Json;
using Camera_Entrada.Model.Driver.Opcua;
using Camera_Entrada.ViewModel.Variaveis;
using SeuNamespace;

namespace Camera_Entrada
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        private static Thread Thread_OpcuaClient;
        private static Thread Thread_CaptureFrame;

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Json_Request json_Request = new Json_Request();
            json_Request.Json_Read_Parametros();
            InicialicaVariaveisGlobaisPrograma();

            Thread_OpcuaClient = new Thread(new ThreadStart(Thread_OpcuaClient_Class));
            Thread_OpcuaClient.Start();


            Thread_CaptureFrame = new Thread(new ThreadStart(Thread_CaptureFrame_Class));
            Thread_CaptureFrame.Start();


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Configurando o encerramento da aplicação
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            Application.Run(new Form_Configuracao());

        }
        private static void InicialicaVariaveisGlobaisPrograma()
        {
            GVL.ExitProgram.xContinueRunning = true;
        }

        private static void Thread_CaptureFrame_Class()
        {
            try
            {
                while (continueRunning)
                {
                    RtspImageCapture RtspImageCapture = new RtspImageCapture();
                    RtspImageCapture.Start_CaptureImageFromRtsp();
                    Thread.Sleep(1000); // Espera por 1 segundo antes da próxima leitura
                    System.Diagnostics.Debug.WriteLine("Thread Camera Iniciada com sucesso");
                }
            }
            catch
            {
                GVL.StatusCamera.xStatusCamera = false;
                System.Diagnostics.Debug.WriteLine("Thread Camera não Iniciada");
            }
        }

        private static void Thread_OpcuaClient_Class()
        {
            try
            {
                while (continueRunning)
                {
                    Opcua_Client Opcua_Client = new Opcua_Client();
                    Opcua_Client.Start_OPCUA();
                    Thread.Sleep(1000); // Espera por 1 segundo antes da próxima leitura
                    System.Diagnostics.Debug.WriteLine("Thread OPCUA Iniciada com sucesso");
                }
            }
            catch
            {
                GVL.StatusOpcua.xStatusOpcua = false;
                System.Diagnostics.Debug.WriteLine("Thread OPCUA não Iniciada");
            }

        }

        private static bool continueRunning = true;

        static void OnApplicationExit(object sender, EventArgs e)
        {
            // Signal the thread to stop running
            GVL.ExitProgram.xContinueRunning = false;
            continueRunning = (bool)GVL.ExitProgram.xContinueRunning;
            // Wait for the thread to finish (optionally with timeout)
            if (Thread_OpcuaClient != null && Thread_OpcuaClient.IsAlive)
            {
                Thread_OpcuaClient.Join(2000); // Wait up to 2 seconds
            }


        }
    }
}