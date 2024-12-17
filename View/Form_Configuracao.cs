using Camera_Entrada.Model.DataBase.Json;
using Camera_Entrada.ViewModel.Variaveis;
using SeuNamespace;

namespace Camera_Entrada
{
    public partial class Form_Configuracao : Form
    {
        public Form_Configuracao()
        {
            InitializeComponent();
            Carragar_Valores_dos_Parametros();
            this.SizeChanged += Form_Configuracao_Resize;

        }

        private void Form_Configuracao_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
        }

        private void submenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            notifyIcon.ContextMenuStrip.Visible = false;
            notifyIcon.ContextMenuStrip.Close();
            this.Close();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon.ContextMenuStrip = ContextMenuStrip;
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
                Show();
            }
        }

        private void Form_Configuracao_Load(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
        }

        private void button_Salvar_dados_Click(object sender, EventArgs e)
        {
            Salvar_Valores_dos_Parametros();
            Carragar_Valores_dos_Parametros();
        }


        private void Carragar_Valores_dos_Parametros()
        {
            // Parâmetros Câmera
            textBox_Parametros_Set_Bloco_de_Rede.Text = GVRL.GVRL_Parametros.sIp_bloco_de_rede;
            textBox_Parametros_Set_Usuario.Text = GVRL.GVRL_Parametros.sUsuario;
            textBox_Parametros_Set_Senha.Text = GVRL.GVRL_Parametros.sSenha;
            textBox_Parametros_Set_Descarte.Text = GVRL.GVRL_Parametros.sPeriodo_de_Descarte_Imagens;
            // Status Câmera
            label_Camera_Display_Url.Text = GVRL.GVRL_Parametros.sUrl_Camera;
            label_Camera_Display_Diretorio.Text = GVRL.GVRL_Parametros.sDiretorio_de_Imagens;
            // Status OPC UA
            label_Opcua_Display_Url.Text = GVRL.GVRL_Parametros.sUrl_Opcua;
        }

        private void Salvar_Valores_dos_Parametros()
        {
            string Parametros_Set_Bloco_de_Rede = textBox_Parametros_Set_Bloco_de_Rede.Text;
            string Parametros_Set_Usuario = textBox_Parametros_Set_Usuario.Text;
            string Parametros_Set_Senha = textBox_Parametros_Set_Senha.Text;
            string Parametros_Set_Descarte = textBox_Parametros_Set_Descarte.Text;

            // Parâmetros Câmera
            GVRL.GVRL_Parametros.sIp_bloco_de_rede = Parametros_Set_Bloco_de_Rede;
            GVRL.GVRL_Parametros.sUsuario = Parametros_Set_Usuario;
            GVRL.GVRL_Parametros.sSenha = Parametros_Set_Senha;
            GVRL.GVRL_Parametros.sPeriodo_de_Descarte_Imagens = Parametros_Set_Descarte;
            // Status Câmera
            GVRL.GVRL_Parametros.sUrl_Camera = CriarUrlCamera(Parametros_Set_Usuario, Parametros_Set_Senha, Parametros_Set_Bloco_de_Rede);

            // Status OPC UA
            GVRL.GVRL_Parametros.sUrl_Opcua = CriarUrlOpcua(Parametros_Set_Bloco_de_Rede);

            Json_Request json_Request = new Json_Request();
            json_Request.Json_Write_Parametros();
            json_Request.Json_Read_Parametros();

        }
        private string CriarUrlOpcua(string Bloco_de_Rede)
        {
            return "opc.tcp://" + Bloco_de_Rede + ".10:4840";
        }
        private string CriarUrlCamera(string Usuario, string Senha, string Bloco_de_Rede)
        {
            return "rtsp://" + Usuario + ":" + Senha + "@" + Bloco_de_Rede + ".18:554/cam/realmonitor?channel=1&subtype=0";
        }

        private void button_Parametros_Teste_Registrar_Click(object sender, EventArgs e)
        {

            string sUrl_Camera = GVRL.GVRL_Parametros.sUrl_Camera;
            string sDiretorio_de_Imagens = GVRL.GVRL_Parametros.sDiretorio_de_Imagens;
            string sIdCarga = "00117122024";

            RtspImageCapture RtspImageCapture = new RtspImageCapture();
            RtspImageCapture.CaptureImageFromRtsp(sUrl_Camera,sDiretorio_de_Imagens,sIdCarga);
        }
    }
}
