using Camera_Entrada.Model.DataBase.Json;

namespace Camera_Entrada
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Json_Request json_Request = new Json_Request();
            json_Request.Json_Read_Parametros();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_Configuracao());


        }
    }
}