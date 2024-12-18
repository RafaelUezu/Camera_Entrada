namespace Camera_Entrada
{
    partial class Form_Configuracao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Configuracao));
            textBox_Parametros_Set_Bloco_de_Rede = new TextBox();
            label_Parametros_Legenda_Bloco_de_Rede = new Label();
            label1 = new Label();
            label_Ex_Usuario = new Label();
            label_Parametros_Legenda_Usuario = new Label();
            textBox_Parametros_Set_Usuario = new TextBox();
            label_Ex_Senha = new Label();
            label_Parametros_Legenda_Senha = new Label();
            textBox_Parametros_Set_Senha = new TextBox();
            groupBox_Status_OPC = new GroupBox();
            label_Opcua_Display_xIniciaRelatorioCameraEntrada = new Label();
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada = new Label();
            label_Opcua_Display_uNumeroCargaRelEntrada = new Label();
            label_Opcua_Legenda_uNumeroCargaRelEntrada = new Label();
            label_Opcua_Display_Status = new Label();
            label_Opcua_Legenda_Status = new Label();
            label3 = new Label();
            label2 = new Label();
            label_Opcua_Display_Verificacao_IP = new Label();
            label_Opcua_Legenda_Verificacao_IP = new Label();
            label_Opcua_Display_Url = new Label();
            label_Opcua_Legenda_Url = new Label();
            groupBox_Status_Camera = new GroupBox();
            label_Camera_Display_Status_Camera = new Label();
            label_Camera_Legenda_Status_Camera = new Label();
            linkLabel_Camera_Display_Diretorio = new LinkLabel();
            button_Parametros_Teste_Registrar = new Button();
            label_Camera_Legenda_Diretorio = new Label();
            label_Camera_Display_Tempo_de_Registro = new Label();
            label_Camera_Legenda_Tempo_de_Registro = new Label();
            label_Camera_Display_Url = new Label();
            labell_Camera_Legenda_Url = new Label();
            button_Salvar_dados = new Button();
            groupBox_Parametros_Camera = new GroupBox();
            button_Parametros_Teste_Descarte = new Button();
            label_Parametros_Ex_Descarte = new Label();
            textBox_Parametros_Set_Descarte = new TextBox();
            label_Parametros_Legenda_Descarte = new Label();
            timer_Clock_Tela = new System.Windows.Forms.Timer(components);
            timer_Clock_Descarte = new System.Windows.Forms.Timer(components);
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            submenuToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            label5 = new Label();
            groupBox_Status_OPC.SuspendLayout();
            groupBox_Status_Camera.SuspendLayout();
            groupBox_Parametros_Camera.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Parametros_Set_Bloco_de_Rede
            // 
            textBox_Parametros_Set_Bloco_de_Rede.Anchor = AnchorStyles.Left;
            textBox_Parametros_Set_Bloco_de_Rede.Location = new Point(130, 20);
            textBox_Parametros_Set_Bloco_de_Rede.Multiline = true;
            textBox_Parametros_Set_Bloco_de_Rede.Name = "textBox_Parametros_Set_Bloco_de_Rede";
            textBox_Parametros_Set_Bloco_de_Rede.Size = new Size(140, 20);
            textBox_Parametros_Set_Bloco_de_Rede.TabIndex = 0;
            textBox_Parametros_Set_Bloco_de_Rede.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Parametros_Legenda_Bloco_de_Rede
            // 
            label_Parametros_Legenda_Bloco_de_Rede.BorderStyle = BorderStyle.FixedSingle;
            label_Parametros_Legenda_Bloco_de_Rede.ForeColor = Color.White;
            label_Parametros_Legenda_Bloco_de_Rede.Location = new Point(5, 20);
            label_Parametros_Legenda_Bloco_de_Rede.Name = "label_Parametros_Legenda_Bloco_de_Rede";
            label_Parametros_Legenda_Bloco_de_Rede.Size = new Size(120, 20);
            label_Parametros_Legenda_Bloco_de_Rede.TabIndex = 1;
            label_Parametros_Legenda_Bloco_de_Rede.Text = "Ip do bloco de rede";
            label_Parametros_Legenda_Bloco_de_Rede.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.White;
            label1.Location = new Point(275, 20);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "(Ex: 10.10.70) ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Ex_Usuario
            // 
            label_Ex_Usuario.BorderStyle = BorderStyle.FixedSingle;
            label_Ex_Usuario.ForeColor = Color.White;
            label_Ex_Usuario.Location = new Point(275, 50);
            label_Ex_Usuario.Name = "label_Ex_Usuario";
            label_Ex_Usuario.Size = new Size(120, 20);
            label_Ex_Usuario.TabIndex = 5;
            label_Ex_Usuario.Text = "(Ex: admin) ";
            label_Ex_Usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Parametros_Legenda_Usuario
            // 
            label_Parametros_Legenda_Usuario.BorderStyle = BorderStyle.FixedSingle;
            label_Parametros_Legenda_Usuario.ForeColor = Color.White;
            label_Parametros_Legenda_Usuario.Location = new Point(5, 50);
            label_Parametros_Legenda_Usuario.Name = "label_Parametros_Legenda_Usuario";
            label_Parametros_Legenda_Usuario.Size = new Size(120, 20);
            label_Parametros_Legenda_Usuario.TabIndex = 4;
            label_Parametros_Legenda_Usuario.Text = "Usuário da Câmera";
            label_Parametros_Legenda_Usuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Parametros_Set_Usuario
            // 
            textBox_Parametros_Set_Usuario.Anchor = AnchorStyles.Left;
            textBox_Parametros_Set_Usuario.Location = new Point(130, 50);
            textBox_Parametros_Set_Usuario.Multiline = true;
            textBox_Parametros_Set_Usuario.Name = "textBox_Parametros_Set_Usuario";
            textBox_Parametros_Set_Usuario.Size = new Size(140, 20);
            textBox_Parametros_Set_Usuario.TabIndex = 3;
            textBox_Parametros_Set_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Ex_Senha
            // 
            label_Ex_Senha.BorderStyle = BorderStyle.FixedSingle;
            label_Ex_Senha.ForeColor = Color.White;
            label_Ex_Senha.Location = new Point(275, 80);
            label_Ex_Senha.Name = "label_Ex_Senha";
            label_Ex_Senha.Size = new Size(120, 20);
            label_Ex_Senha.TabIndex = 8;
            label_Ex_Senha.Text = "(Ex: t*********3) ";
            label_Ex_Senha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Parametros_Legenda_Senha
            // 
            label_Parametros_Legenda_Senha.BorderStyle = BorderStyle.FixedSingle;
            label_Parametros_Legenda_Senha.ForeColor = Color.White;
            label_Parametros_Legenda_Senha.Location = new Point(5, 80);
            label_Parametros_Legenda_Senha.Name = "label_Parametros_Legenda_Senha";
            label_Parametros_Legenda_Senha.Size = new Size(120, 20);
            label_Parametros_Legenda_Senha.TabIndex = 7;
            label_Parametros_Legenda_Senha.Text = "Senha da Câmera";
            label_Parametros_Legenda_Senha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Parametros_Set_Senha
            // 
            textBox_Parametros_Set_Senha.Anchor = AnchorStyles.Left;
            textBox_Parametros_Set_Senha.Location = new Point(130, 80);
            textBox_Parametros_Set_Senha.Multiline = true;
            textBox_Parametros_Set_Senha.Name = "textBox_Parametros_Set_Senha";
            textBox_Parametros_Set_Senha.PasswordChar = '*';
            textBox_Parametros_Set_Senha.Size = new Size(140, 20);
            textBox_Parametros_Set_Senha.TabIndex = 6;
            textBox_Parametros_Set_Senha.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox_Status_OPC
            // 
            groupBox_Status_OPC.Controls.Add(label_Opcua_Display_xIniciaRelatorioCameraEntrada);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Legenda_xIniciaRelatorioCameraEntrada);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Display_uNumeroCargaRelEntrada);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Legenda_uNumeroCargaRelEntrada);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Display_Status);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Legenda_Status);
            groupBox_Status_OPC.Controls.Add(label3);
            groupBox_Status_OPC.Controls.Add(label2);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Display_Verificacao_IP);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Legenda_Verificacao_IP);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Display_Url);
            groupBox_Status_OPC.Controls.Add(label_Opcua_Legenda_Url);
            groupBox_Status_OPC.ForeColor = Color.White;
            groupBox_Status_OPC.Location = new Point(420, 10);
            groupBox_Status_OPC.Name = "groupBox_Status_OPC";
            groupBox_Status_OPC.Size = new Size(350, 440);
            groupBox_Status_OPC.TabIndex = 9;
            groupBox_Status_OPC.TabStop = false;
            groupBox_Status_OPC.Text = "Status do OPCUA";
            // 
            // label_Opcua_Display_xIniciaRelatorioCameraEntrada
            // 
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.ForeColor = Color.White;
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.Location = new Point(230, 389);
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.Name = "label_Opcua_Display_xIniciaRelatorioCameraEntrada";
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.Size = new Size(115, 20);
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.TabIndex = 21;
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.Text = "False";
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Legenda_xIniciaRelatorioCameraEntrada
            // 
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.ForeColor = SystemColors.Info;
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Location = new Point(6, 389);
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Name = "label_Opcua_Legenda_xIniciaRelatorioCameraEntrada";
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Size = new Size(220, 20);
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.TabIndex = 20;
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Text = "xIniciaRelatorioCameraEntrada";
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Display_uNumeroCargaRelEntrada
            // 
            label_Opcua_Display_uNumeroCargaRelEntrada.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Display_uNumeroCargaRelEntrada.ForeColor = Color.White;
            label_Opcua_Display_uNumeroCargaRelEntrada.Location = new Point(229, 415);
            label_Opcua_Display_uNumeroCargaRelEntrada.Name = "label_Opcua_Display_uNumeroCargaRelEntrada";
            label_Opcua_Display_uNumeroCargaRelEntrada.Size = new Size(115, 20);
            label_Opcua_Display_uNumeroCargaRelEntrada.TabIndex = 19;
            label_Opcua_Display_uNumeroCargaRelEntrada.Text = "123";
            label_Opcua_Display_uNumeroCargaRelEntrada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Legenda_uNumeroCargaRelEntrada
            // 
            label_Opcua_Legenda_uNumeroCargaRelEntrada.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_uNumeroCargaRelEntrada.ForeColor = SystemColors.Info;
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Location = new Point(5, 415);
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Name = "label_Opcua_Legenda_uNumeroCargaRelEntrada";
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Size = new Size(220, 20);
            label_Opcua_Legenda_uNumeroCargaRelEntrada.TabIndex = 18;
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Text = "uNumeroCargaRelEntrada";
            label_Opcua_Legenda_uNumeroCargaRelEntrada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Display_Status
            // 
            label_Opcua_Display_Status.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Display_Status.ForeColor = Color.White;
            label_Opcua_Display_Status.Location = new Point(230, 50);
            label_Opcua_Display_Status.Name = "label_Opcua_Display_Status";
            label_Opcua_Display_Status.Size = new Size(115, 20);
            label_Opcua_Display_Status.TabIndex = 17;
            label_Opcua_Display_Status.Text = "Operando";
            label_Opcua_Display_Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Legenda_Status
            // 
            label_Opcua_Legenda_Status.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_Status.ForeColor = SystemColors.Info;
            label_Opcua_Legenda_Status.Location = new Point(5, 50);
            label_Opcua_Legenda_Status.Name = "label_Opcua_Legenda_Status";
            label_Opcua_Legenda_Status.Size = new Size(220, 20);
            label_Opcua_Legenda_Status.TabIndex = 16;
            label_Opcua_Legenda_Status.Text = "Status do Servidor OpcUa";
            label_Opcua_Legenda_Status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = Color.White;
            label3.Location = new Point(229, 110);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 15;
            label3.Text = "3333 ms";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(5, 110);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 14;
            label2.Text = "Tempo Total da Requisição";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Display_Verificacao_IP
            // 
            label_Opcua_Display_Verificacao_IP.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Display_Verificacao_IP.ForeColor = Color.White;
            label_Opcua_Display_Verificacao_IP.Location = new Point(230, 80);
            label_Opcua_Display_Verificacao_IP.Name = "label_Opcua_Display_Verificacao_IP";
            label_Opcua_Display_Verificacao_IP.Size = new Size(115, 20);
            label_Opcua_Display_Verificacao_IP.TabIndex = 13;
            label_Opcua_Display_Verificacao_IP.Text = "3333 ms";
            label_Opcua_Display_Verificacao_IP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Legenda_Verificacao_IP
            // 
            label_Opcua_Legenda_Verificacao_IP.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_Verificacao_IP.ForeColor = SystemColors.Info;
            label_Opcua_Legenda_Verificacao_IP.Location = new Point(5, 80);
            label_Opcua_Legenda_Verificacao_IP.Name = "label_Opcua_Legenda_Verificacao_IP";
            label_Opcua_Legenda_Verificacao_IP.Size = new Size(220, 20);
            label_Opcua_Legenda_Verificacao_IP.TabIndex = 12;
            label_Opcua_Legenda_Verificacao_IP.Text = "Tempo de Verificação de IP";
            label_Opcua_Legenda_Verificacao_IP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Display_Url
            // 
            label_Opcua_Display_Url.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Display_Url.ForeColor = Color.White;
            label_Opcua_Display_Url.Location = new Point(100, 20);
            label_Opcua_Display_Url.Name = "label_Opcua_Display_Url";
            label_Opcua_Display_Url.Size = new Size(245, 20);
            label_Opcua_Display_Url.TabIndex = 11;
            label_Opcua_Display_Url.Text = "opc.tcp://10.10.01.10:4840";
            label_Opcua_Display_Url.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Opcua_Legenda_Url
            // 
            label_Opcua_Legenda_Url.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_Url.ForeColor = Color.White;
            label_Opcua_Legenda_Url.Location = new Point(5, 20);
            label_Opcua_Legenda_Url.Name = "label_Opcua_Legenda_Url";
            label_Opcua_Legenda_Url.Size = new Size(90, 20);
            label_Opcua_Legenda_Url.TabIndex = 10;
            label_Opcua_Legenda_Url.Text = "Url";
            label_Opcua_Legenda_Url.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_Status_Camera
            // 
            groupBox_Status_Camera.Controls.Add(label4);
            groupBox_Status_Camera.Controls.Add(label5);
            groupBox_Status_Camera.Controls.Add(label_Camera_Display_Status_Camera);
            groupBox_Status_Camera.Controls.Add(label_Camera_Legenda_Status_Camera);
            groupBox_Status_Camera.Controls.Add(linkLabel_Camera_Display_Diretorio);
            groupBox_Status_Camera.Controls.Add(button_Parametros_Teste_Registrar);
            groupBox_Status_Camera.Controls.Add(label_Camera_Legenda_Diretorio);
            groupBox_Status_Camera.Controls.Add(label_Camera_Display_Tempo_de_Registro);
            groupBox_Status_Camera.Controls.Add(label_Camera_Legenda_Tempo_de_Registro);
            groupBox_Status_Camera.Controls.Add(label_Camera_Display_Url);
            groupBox_Status_Camera.Controls.Add(labell_Camera_Legenda_Url);
            groupBox_Status_Camera.ForeColor = Color.White;
            groupBox_Status_Camera.Location = new Point(10, 200);
            groupBox_Status_Camera.Name = "groupBox_Status_Camera";
            groupBox_Status_Camera.Size = new Size(400, 250);
            groupBox_Status_Camera.TabIndex = 10;
            groupBox_Status_Camera.TabStop = false;
            groupBox_Status_Camera.Text = "Status da Câmera";
            // 
            // label_Camera_Display_Status_Camera
            // 
            label_Camera_Display_Status_Camera.BorderStyle = BorderStyle.FixedSingle;
            label_Camera_Display_Status_Camera.ForeColor = Color.White;
            label_Camera_Display_Status_Camera.Location = new Point(280, 100);
            label_Camera_Display_Status_Camera.Name = "label_Camera_Display_Status_Camera";
            label_Camera_Display_Status_Camera.Size = new Size(115, 20);
            label_Camera_Display_Status_Camera.TabIndex = 27;
            label_Camera_Display_Status_Camera.Text = "Porta Indisponível";
            label_Camera_Display_Status_Camera.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Camera_Legenda_Status_Camera
            // 
            label_Camera_Legenda_Status_Camera.BorderStyle = BorderStyle.FixedSingle;
            label_Camera_Legenda_Status_Camera.ForeColor = SystemColors.Info;
            label_Camera_Legenda_Status_Camera.Location = new Point(5, 100);
            label_Camera_Legenda_Status_Camera.Name = "label_Camera_Legenda_Status_Camera";
            label_Camera_Legenda_Status_Camera.Size = new Size(270, 20);
            label_Camera_Legenda_Status_Camera.TabIndex = 26;
            label_Camera_Legenda_Status_Camera.Text = "Status da Câmera";
            label_Camera_Legenda_Status_Camera.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel_Camera_Display_Diretorio
            // 
            linkLabel_Camera_Display_Diretorio.BorderStyle = BorderStyle.FixedSingle;
            linkLabel_Camera_Display_Diretorio.LinkColor = Color.Cyan;
            linkLabel_Camera_Display_Diretorio.Location = new Point(160, 160);
            linkLabel_Camera_Display_Diretorio.Name = "linkLabel_Camera_Display_Diretorio";
            linkLabel_Camera_Display_Diretorio.Size = new Size(235, 20);
            linkLabel_Camera_Display_Diretorio.TabIndex = 25;
            linkLabel_Camera_Display_Diretorio.TabStop = true;
            linkLabel_Camera_Display_Diretorio.Text = "C:\\Imagem_Entrada";
            linkLabel_Camera_Display_Diretorio.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel_Camera_Display_Diretorio.LinkClicked += linkLabel_Camera_Display_Diretorio_LinkClicked;
            // 
            // button_Parametros_Teste_Registrar
            // 
            button_Parametros_Teste_Registrar.ForeColor = Color.Black;
            button_Parametros_Teste_Registrar.Location = new Point(5, 220);
            button_Parametros_Teste_Registrar.Name = "button_Parametros_Teste_Registrar";
            button_Parametros_Teste_Registrar.Size = new Size(120, 25);
            button_Parametros_Teste_Registrar.TabIndex = 16;
            button_Parametros_Teste_Registrar.Text = "Teste Registrar";
            button_Parametros_Teste_Registrar.UseVisualStyleBackColor = true;
            button_Parametros_Teste_Registrar.Click += button_Parametros_Teste_Registrar_Click;
            // 
            // label_Camera_Legenda_Diretorio
            // 
            label_Camera_Legenda_Diretorio.BorderStyle = BorderStyle.FixedSingle;
            label_Camera_Legenda_Diretorio.ForeColor = Color.White;
            label_Camera_Legenda_Diretorio.Location = new Point(5, 160);
            label_Camera_Legenda_Diretorio.Name = "label_Camera_Legenda_Diretorio";
            label_Camera_Legenda_Diretorio.Size = new Size(150, 20);
            label_Camera_Legenda_Diretorio.TabIndex = 23;
            label_Camera_Legenda_Diretorio.Text = "Diretório das Imagens";
            label_Camera_Legenda_Diretorio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Camera_Display_Tempo_de_Registro
            // 
            label_Camera_Display_Tempo_de_Registro.BorderStyle = BorderStyle.FixedSingle;
            label_Camera_Display_Tempo_de_Registro.ForeColor = Color.White;
            label_Camera_Display_Tempo_de_Registro.Location = new Point(280, 70);
            label_Camera_Display_Tempo_de_Registro.Name = "label_Camera_Display_Tempo_de_Registro";
            label_Camera_Display_Tempo_de_Registro.Size = new Size(115, 20);
            label_Camera_Display_Tempo_de_Registro.TabIndex = 22;
            label_Camera_Display_Tempo_de_Registro.Text = "3333 ms";
            label_Camera_Display_Tempo_de_Registro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Camera_Legenda_Tempo_de_Registro
            // 
            label_Camera_Legenda_Tempo_de_Registro.BorderStyle = BorderStyle.FixedSingle;
            label_Camera_Legenda_Tempo_de_Registro.ForeColor = SystemColors.Info;
            label_Camera_Legenda_Tempo_de_Registro.Location = new Point(5, 70);
            label_Camera_Legenda_Tempo_de_Registro.Name = "label_Camera_Legenda_Tempo_de_Registro";
            label_Camera_Legenda_Tempo_de_Registro.Size = new Size(270, 20);
            label_Camera_Legenda_Tempo_de_Registro.TabIndex = 22;
            label_Camera_Legenda_Tempo_de_Registro.Text = "Tempo de Registro da Imagem";
            label_Camera_Legenda_Tempo_de_Registro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Camera_Display_Url
            // 
            label_Camera_Display_Url.BorderStyle = BorderStyle.FixedSingle;
            label_Camera_Display_Url.ForeColor = Color.White;
            label_Camera_Display_Url.Location = new Point(100, 20);
            label_Camera_Display_Url.Name = "label_Camera_Display_Url";
            label_Camera_Display_Url.Size = new Size(295, 40);
            label_Camera_Display_Url.TabIndex = 22;
            label_Camera_Display_Url.Text = "rtsp://admin:tvsglass123@10.10.01.18:554/cam/realmonitor?channel=1&subtype=0";
            label_Camera_Display_Url.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labell_Camera_Legenda_Url
            // 
            labell_Camera_Legenda_Url.BorderStyle = BorderStyle.FixedSingle;
            labell_Camera_Legenda_Url.ForeColor = Color.White;
            labell_Camera_Legenda_Url.Location = new Point(5, 20);
            labell_Camera_Legenda_Url.Name = "labell_Camera_Legenda_Url";
            labell_Camera_Legenda_Url.Size = new Size(90, 40);
            labell_Camera_Legenda_Url.TabIndex = 22;
            labell_Camera_Legenda_Url.Text = "Url";
            labell_Camera_Legenda_Url.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Salvar_dados
            // 
            button_Salvar_dados.ForeColor = Color.Black;
            button_Salvar_dados.Location = new Point(275, 160);
            button_Salvar_dados.Name = "button_Salvar_dados";
            button_Salvar_dados.Size = new Size(120, 25);
            button_Salvar_dados.TabIndex = 11;
            button_Salvar_dados.Text = "Salvar";
            button_Salvar_dados.UseVisualStyleBackColor = true;
            button_Salvar_dados.Click += button_Salvar_dados_Click;
            // 
            // groupBox_Parametros_Camera
            // 
            groupBox_Parametros_Camera.Controls.Add(button_Parametros_Teste_Descarte);
            groupBox_Parametros_Camera.Controls.Add(label_Parametros_Ex_Descarte);
            groupBox_Parametros_Camera.Controls.Add(textBox_Parametros_Set_Descarte);
            groupBox_Parametros_Camera.Controls.Add(label_Parametros_Legenda_Descarte);
            groupBox_Parametros_Camera.Controls.Add(button_Salvar_dados);
            groupBox_Parametros_Camera.Controls.Add(label_Parametros_Legenda_Bloco_de_Rede);
            groupBox_Parametros_Camera.Controls.Add(textBox_Parametros_Set_Bloco_de_Rede);
            groupBox_Parametros_Camera.Controls.Add(label1);
            groupBox_Parametros_Camera.Controls.Add(textBox_Parametros_Set_Usuario);
            groupBox_Parametros_Camera.Controls.Add(label_Ex_Senha);
            groupBox_Parametros_Camera.Controls.Add(label_Parametros_Legenda_Usuario);
            groupBox_Parametros_Camera.Controls.Add(label_Parametros_Legenda_Senha);
            groupBox_Parametros_Camera.Controls.Add(label_Ex_Usuario);
            groupBox_Parametros_Camera.Controls.Add(textBox_Parametros_Set_Senha);
            groupBox_Parametros_Camera.ForeColor = Color.White;
            groupBox_Parametros_Camera.Location = new Point(10, 10);
            groupBox_Parametros_Camera.Name = "groupBox_Parametros_Camera";
            groupBox_Parametros_Camera.Size = new Size(400, 190);
            groupBox_Parametros_Camera.TabIndex = 22;
            groupBox_Parametros_Camera.TabStop = false;
            groupBox_Parametros_Camera.Text = "Parâmetros Câmera";
            // 
            // button_Parametros_Teste_Descarte
            // 
            button_Parametros_Teste_Descarte.ForeColor = Color.Black;
            button_Parametros_Teste_Descarte.Location = new Point(150, 160);
            button_Parametros_Teste_Descarte.Name = "button_Parametros_Teste_Descarte";
            button_Parametros_Teste_Descarte.Size = new Size(120, 25);
            button_Parametros_Teste_Descarte.TabIndex = 15;
            button_Parametros_Teste_Descarte.Text = "Teste Descarte";
            button_Parametros_Teste_Descarte.UseVisualStyleBackColor = true;
            // 
            // label_Parametros_Ex_Descarte
            // 
            label_Parametros_Ex_Descarte.BorderStyle = BorderStyle.FixedSingle;
            label_Parametros_Ex_Descarte.ForeColor = Color.White;
            label_Parametros_Ex_Descarte.Location = new Point(275, 110);
            label_Parametros_Ex_Descarte.Name = "label_Parametros_Ex_Descarte";
            label_Parametros_Ex_Descarte.Size = new Size(120, 20);
            label_Parametros_Ex_Descarte.TabIndex = 14;
            label_Parametros_Ex_Descarte.Text = "(Ex: 3) ";
            label_Parametros_Ex_Descarte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_Parametros_Set_Descarte
            // 
            textBox_Parametros_Set_Descarte.Anchor = AnchorStyles.Left;
            textBox_Parametros_Set_Descarte.Location = new Point(130, 110);
            textBox_Parametros_Set_Descarte.Multiline = true;
            textBox_Parametros_Set_Descarte.Name = "textBox_Parametros_Set_Descarte";
            textBox_Parametros_Set_Descarte.Size = new Size(140, 20);
            textBox_Parametros_Set_Descarte.TabIndex = 13;
            textBox_Parametros_Set_Descarte.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Parametros_Legenda_Descarte
            // 
            label_Parametros_Legenda_Descarte.BorderStyle = BorderStyle.FixedSingle;
            label_Parametros_Legenda_Descarte.ForeColor = Color.White;
            label_Parametros_Legenda_Descarte.Location = new Point(5, 110);
            label_Parametros_Legenda_Descarte.Name = "label_Parametros_Legenda_Descarte";
            label_Parametros_Legenda_Descarte.Size = new Size(120, 20);
            label_Parametros_Legenda_Descarte.TabIndex = 12;
            label_Parametros_Legenda_Descarte.Text = "Descarte (Meses)";
            label_Parametros_Legenda_Descarte.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer_Clock_Tela
            // 
            timer_Clock_Tela.Interval = 500;
            // 
            // timer_Clock_Descarte
            // 
            timer_Clock_Descarte.Interval = 86400000;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "notifyIcon1";
            notifyIcon.Visible = true;
            notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { submenuToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip.Name = "contextMenuStrip1";
            contextMenuStrip.Size = new Size(126, 48);
            // 
            // submenuToolStripMenuItem
            // 
            submenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            submenuToolStripMenuItem.Name = "submenuToolStripMenuItem";
            submenuToolStripMenuItem.Size = new Size(125, 22);
            submenuToolStripMenuItem.Text = "Submenu";
            submenuToolStripMenuItem.Click += submenuToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(94, 22);
            testToolStripMenuItem.Text = "Test";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(125, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = Color.White;
            label4.Location = new Point(280, 130);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 29;
            label4.Text = "00118122024";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(5, 130);
            label5.Name = "label5";
            label5.Size = new Size(270, 20);
            label5.TabIndex = 28;
            label5.Text = "Id da Última Carga Registrada";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Configuracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 41, 61);
            ClientSize = new Size(784, 461);
            Controls.Add(groupBox_Parametros_Camera);
            Controls.Add(groupBox_Status_Camera);
            Controls.Add(groupBox_Status_OPC);
            Name = "Form_Configuracao";
            Text = "Form_Configuracao";
            Load += Form_Configuracao_Load;
            groupBox_Status_OPC.ResumeLayout(false);
            groupBox_Status_Camera.ResumeLayout(false);
            groupBox_Parametros_Camera.ResumeLayout(false);
            groupBox_Parametros_Camera.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox_Parametros_Set_Bloco_de_Rede;
        private Label label_Parametros_Legenda_Bloco_de_Rede;
        private Label label1;
        private Label label_Ex_Usuario;
        private Label label_Parametros_Legenda_Usuario;
        private TextBox textBox_Parametros_Set_Usuario;
        private Label label_Ex_Senha;
        private Label label_Parametros_Legenda_Senha;
        private TextBox textBox_Parametros_Set_Senha;
        private GroupBox groupBox_Status_OPC;
        private Label label_Opcua_Legenda_Url;
        private Label label_Opcua_Display_Url;
        private Label label_Opcua_Display_Verificacao_IP;
        private Label label_Opcua_Legenda_Verificacao_IP;
        private Label label3;
        private Label label2;
        private Label label_Opcua_Display_Status;
        private Label label_Opcua_Legenda_Status;
        private Label label_Opcua_Legenda_uNumeroCargaRelEntrada;
        private Label label_Opcua_Display_xIniciaRelatorioCameraEntrada;
        private Label label_Opcua_Legenda_xIniciaRelatorioCameraEntrada;
        private Label label_Opcua_Display_uNumeroCargaRelEntrada;
        private GroupBox groupBox_Status_Camera;
        private Button button_Salvar_dados;
        private Label label_Camera_Display_Url;
        private Label labell_Camera_Legenda_Url;
        private Label label_Camera_Legenda_Tempo_de_Registro;
        private Label label_Camera_Display_Tempo_de_Registro;
        private Label label_Camera_Legenda_Diretorio;
        private GroupBox groupBox_Parametros_Camera;
        private Label label_Parametros_Legenda_Descarte;
        private Label label_Parametros_Ex_Descarte;
        private TextBox textBox_Parametros_Set_Descarte;
        private System.Windows.Forms.Timer timer_Clock_Tela;
        private System.Windows.Forms.Timer timer_Clock_Descarte;
        private Button button_Parametros_Teste_Descarte;
        private Button button_Parametros_Teste_Registrar;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem submenuToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private LinkLabel linkLabel_Camera_Display_Diretorio;
        private Label label_Camera_Display_Status_Camera;
        private Label label_Camera_Legenda_Status_Camera;
        private Label label4;
        private Label label5;
    }
}
