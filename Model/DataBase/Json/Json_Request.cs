using Camera_Entrada.ViewModel.Variaveis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace Camera_Entrada.Model.DataBase.Json
{

    public class Json_GVRL
    {
        public string sIp_bloco_de_rede;
        public string sUsuario;
        public string sSenha;
        public string sUrl_Camera;
        public string sUrl_Opcua;
        public string sDiretorio_de_Imagens;
        public string sPeriodo_de_Descarte_Imagens;
    }


    class Json_Request
    {

        public void Json_Read_Parametros()
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.Parent.FullName;
                //
                string fileName = "Model\\DataBase\\Json\\GVRL.json";
                string fullPath = Path.Combine(projectDirectory, fileName);
                System.Diagnostics.Debug.WriteLine(fullPath);
                string jsonContent = File.ReadAllText(fullPath);
                Json_GVRL Json_GVRL_Read = JsonConvert.DeserializeObject<Json_GVRL>(jsonContent);

                GVRL.Parametros.sIp_bloco_de_rede = Json_GVRL_Read.sIp_bloco_de_rede;
                GVRL.Parametros.sUsuario = Json_GVRL_Read.sUsuario;
                GVRL.Parametros.sSenha = Json_GVRL_Read.sSenha;
                GVRL.Parametros.sUrl_Camera = Json_GVRL_Read.sUrl_Camera;
                GVRL.Parametros.sUrl_Opcua = Json_GVRL_Read.sUrl_Opcua;
                GVRL.Parametros.sDiretorio_de_Imagens = Json_GVRL_Read.sDiretorio_de_Imagens;
                GVRL.Parametros.sPeriodo_de_Descarte_Imagens = Json_GVRL_Read.sPeriodo_de_Descarte_Imagens;
            }
            catch
            {
                return;
            }

        }

        public void Json_Write_Parametros()
        {
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string projectDirectory = Directory.GetParent(baseDirectory).Parent.Parent.Parent.Parent.FullName;
                string fileName = "Model\\DataBase\\Json\\GVRL.json";
                string fullPath = Path.Combine(projectDirectory, fileName);
                string jsonContent = File.ReadAllText(fullPath);
                JObject jsonParsed = JObject.Parse(jsonContent);

                jsonParsed["sIp_bloco_de_rede"] = JToken.FromObject(GVRL.Parametros.sIp_bloco_de_rede);
                jsonParsed["sUsuario"] = JToken.FromObject(GVRL.Parametros.sUsuario);
                jsonParsed["sSenha"] = JToken.FromObject(GVRL.Parametros.sSenha);
                jsonParsed["sUrl_Camera"] = JToken.FromObject(GVRL.Parametros.sUrl_Camera);
                jsonParsed["sUrl_Opcua"] = JToken.FromObject(GVRL.Parametros.sUrl_Opcua);
                jsonParsed["sDiretorio_de_Imagens"] = JToken.FromObject(GVRL.Parametros.sDiretorio_de_Imagens);
                jsonParsed["sPeriodo_de_Descarte_Imagens"] = JToken.FromObject(GVRL.Parametros.sPeriodo_de_Descarte_Imagens);

                string updatedJsonContent = jsonParsed.ToString(Formatting.Indented);
                File.WriteAllText(fullPath, updatedJsonContent);
            }
            catch
            {
                return;
            }
        }
    }




}
