using Camera_Entrada.Model.DataBase.Json;
using Camera_Entrada.ViewModel.Variaveis;
using SeuNamespace;
using System.Diagnostics;
using static Camera_Entrada.ViewModel.Variaveis.GVL;

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
            textBox_Parametros_Set_Bloco_de_Rede.Text = GVRL.Parametros.sIp_bloco_de_rede;
            textBox_Parametros_Set_Usuario.Text = GVRL.Parametros.sUsuario;
            textBox_Parametros_Set_Senha.Text = GVRL.Parametros.sSenha;
            textBox_Parametros_Set_Descarte.Text = GVRL.Parametros.sPeriodo_de_Descarte_Imagens;
            // Status Câmera
            label_Camera_Display_Url.Text = GVRL.Parametros.sUrl_Camera;
            linkLabel_Camera_Display_Diretorio.Text = GVRL.Parametros.sDiretorio_de_Imagens;
            // Status OPC UA
            label_Opcua_Display_Url.Text = GVRL.Parametros.sUrl_Opcua;
        }

        private void Salvar_Valores_dos_Parametros()
        {
            string Parametros_Set_Bloco_de_Rede = textBox_Parametros_Set_Bloco_de_Rede.Text;
            string Parametros_Set_Usuario = textBox_Parametros_Set_Usuario.Text;
            string Parametros_Set_Senha = textBox_Parametros_Set_Senha.Text;
            string Parametros_Set_Descarte = textBox_Parametros_Set_Descarte.Text;

            // Parâmetros Câmera
            GVRL.Parametros.sIp_bloco_de_rede = Parametros_Set_Bloco_de_Rede;
            GVRL.Parametros.sUsuario = Parametros_Set_Usuario;
            GVRL.Parametros.sSenha = Parametros_Set_Senha;
            GVRL.Parametros.sPeriodo_de_Descarte_Imagens = Parametros_Set_Descarte;
            // Status Câmera
            GVRL.Parametros.sUrl_Camera = CriarUrlCamera(Parametros_Set_Usuario, Parametros_Set_Senha, Parametros_Set_Bloco_de_Rede);

            // Status OPC UA
            GVRL.Parametros.sUrl_Opcua = CriarUrlOpcua(Parametros_Set_Bloco_de_Rede);

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
            GVL.StatusCamera.sTempoRegistroCamera = "Verificando";
            Stopwatch sw_TempoRegistroCamera = Stopwatch.StartNew();




            string sUrl_Camera = GVRL.Parametros.sUrl_Camera;
            string sDiretorio_de_Imagens = GVRL.Parametros.sDiretorio_de_Imagens;
            string sIdCarga = "ImagemTeste";

            RtspImageCapture RtspImageCapture = new RtspImageCapture();
            RtspImageCapture.CaptureImageFromRtsp(sUrl_Camera, sDiretorio_de_Imagens, sIdCarga);


            sw_TempoRegistroCamera.Stop();
            TimeSpan el_TempoRegistroCamera = sw_TempoRegistroCamera.Elapsed;
            GVL.StatusCamera.sTempoRegistroCamera = el_TempoRegistroCamera.Milliseconds.ToString() + ":" + el_TempoRegistroCamera.Microseconds.ToString();

            GVL.StatusCamera.sIdUltimaCarga = sIdCarga;

        }

        private void linkLabel_Camera_Display_Diretorio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            LinkLabel link = sender as LinkLabel;
            if (link != null && link.Text != null)
            {
                string directory = link.Text.ToString();
                try
                {
                    Process.Start("explorer", directory);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível abrir o diretório: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Diretório inválido ou não definido.");
            }
        }

        private void timer_Clock_Tela_Tick(object sender, EventArgs e)
        {
            try
            {

                var sTempoRegistroCamera        = GVL.StatusCamera.sTempoRegistroCamera;
                var xStatusCamera               = GVL.StatusCamera.xStatusCamera;
                var sIdUltimaCarga              = GVL.StatusCamera.sIdUltimaCarga;

                var sTempoCheckIp               = GVL.StatusOpcua.sTempoCheckIp;
                var sTempoRequesicaoOpcua       = GVL.StatusOpcua.sTempoRequesicaoOpcua;
                var xStatusOpcua                = GVL.StatusOpcua.xStatusOpcua;
                
                var xIniciaRelatorioCameraEntrada       = GVL.Opcua.Read.ClpCamera.xIniciaRelatorioCameraEntrada;
                var uNumeroCargaRelEntrada              = GVL.Opcua.Read.ClpCamera.uNumeroCargaRelEntrada;



                string _sTempoRegistroCamera    = sTempoRegistroCamera != null?     sTempoRegistroCamera :          string.Empty;
                string _sStatusCamera           = xStatusCamera != null?            xStatusCamera.ToString() :      string.Empty;
                string _sIdUltimaCarga          = sIdUltimaCarga != null?           sIdUltimaCarga.ToString() :     string.Empty;

                string _sTempoCheckIp           = sTempoCheckIp != null ?           sTempoCheckIp :                 string.Empty;
                string _sTempoRequesicaoOpcua   = sTempoRequesicaoOpcua != null?    sTempoRequesicaoOpcua :         string.Empty;
                string _sStatusOpcua            = xStatusOpcua != null?             xStatusOpcua.ToString() :       string.Empty;

                string _sIniciaRelatorioCameraEntrada = xIniciaRelatorioCameraEntrada != null? xIniciaRelatorioCameraEntrada.ToString() : string.Empty;
                string _sNumeroCargaRelEntrada  = uNumeroCargaRelEntrada != null? uNumeroCargaRelEntrada.ToString(): string.Empty;




                label_Camera_Display_Tempo_de_Registro.Text     = _sTempoRegistroCamera;
                label_Camera_Display_Status_Camera.Text         = _sStatusCamera;
                label_Camera_Display_Id_Ultima_Carga.Text       = _sIdUltimaCarga;


                label_Opcua_Display_Status.Text = _sStatusOpcua;
                label_Opcua_Display_Verificacao_IP.Text = _sTempoCheckIp;
                label_Opcua_Display_Requisicao_Opcua.Text = _sTempoRequesicaoOpcua;

                label_Opcua_Display_xIniciaRelatorioCameraEntrada.Text = _sIniciaRelatorioCameraEntrada;
                label_Opcua_Display_uNumeroCargaRelEntrada.Text = _sNumeroCargaRelEntrada;

            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Erro em atribuir variáveis do Status Câmera");
            }
        }
    }
}
