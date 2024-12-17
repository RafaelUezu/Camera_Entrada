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
            textBox_Set_Bloco_de_Rede = new TextBox();
            label_Legenda_Bloco_de_Rede = new Label();
            label1 = new Label();
            label_Ex_Usuario = new Label();
            label_Legenda_Usuario = new Label();
            textBox_Set_Usuario = new TextBox();
            label_Ex_Senha = new Label();
            label_Legenda_Senha = new Label();
            textBox_Set_Senha = new TextBox();
            groupBox_Status_OPC = new GroupBox();
            label_Opcua_Legenda_Url = new Label();
            label_Opcua_Display_Url = new Label();
            label_Opcua_Display_Verificacao_IP = new Label();
            label_Opcua_Legenda_Verificacao_IP = new Label();
            label2 = new Label();
            label3 = new Label();
            label_Opcua_Display_Status = new Label();
            label_Opcua_Legenda_Status = new Label();
            label_Opcua_Legenda_uNumeroCargaRelEntrada = new Label();
            label_Opcua_Display_uNumeroCargaRelEntrada = new Label();
            label_Opcua_Display_xIniciaRelatorioCameraEntrada = new Label();
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada = new Label();
            groupBox_Status_Camera = new GroupBox();
            button_Atualizar_dados = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox_Status_OPC.SuspendLayout();
            groupBox_Status_Camera.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_Set_Bloco_de_Rede
            // 
            textBox_Set_Bloco_de_Rede.Anchor = AnchorStyles.Left;
            textBox_Set_Bloco_de_Rede.Location = new Point(140, 10);
            textBox_Set_Bloco_de_Rede.Multiline = true;
            textBox_Set_Bloco_de_Rede.Name = "textBox_Set_Bloco_de_Rede";
            textBox_Set_Bloco_de_Rede.Size = new Size(100, 20);
            textBox_Set_Bloco_de_Rede.TabIndex = 0;
            textBox_Set_Bloco_de_Rede.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Legenda_Bloco_de_Rede
            // 
            label_Legenda_Bloco_de_Rede.BorderStyle = BorderStyle.FixedSingle;
            label_Legenda_Bloco_de_Rede.ForeColor = Color.White;
            label_Legenda_Bloco_de_Rede.Location = new Point(10, 10);
            label_Legenda_Bloco_de_Rede.Name = "label_Legenda_Bloco_de_Rede";
            label_Legenda_Bloco_de_Rede.Size = new Size(120, 20);
            label_Legenda_Bloco_de_Rede.TabIndex = 1;
            label_Legenda_Bloco_de_Rede.Text = "Ip do bloco de rede";
            label_Legenda_Bloco_de_Rede.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.White;
            label1.Location = new Point(250, 10);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "(Ex: 10.10.70) ";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_Ex_Usuario
            // 
            label_Ex_Usuario.BorderStyle = BorderStyle.FixedSingle;
            label_Ex_Usuario.ForeColor = Color.White;
            label_Ex_Usuario.Location = new Point(250, 50);
            label_Ex_Usuario.Name = "label_Ex_Usuario";
            label_Ex_Usuario.Size = new Size(120, 20);
            label_Ex_Usuario.TabIndex = 5;
            label_Ex_Usuario.Text = "(Ex: admin) ";
            label_Ex_Usuario.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_Legenda_Usuario
            // 
            label_Legenda_Usuario.BorderStyle = BorderStyle.FixedSingle;
            label_Legenda_Usuario.ForeColor = Color.White;
            label_Legenda_Usuario.Location = new Point(10, 50);
            label_Legenda_Usuario.Name = "label_Legenda_Usuario";
            label_Legenda_Usuario.Size = new Size(120, 20);
            label_Legenda_Usuario.TabIndex = 4;
            label_Legenda_Usuario.Text = "Usuário da Câmera";
            label_Legenda_Usuario.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox_Set_Usuario
            // 
            textBox_Set_Usuario.Anchor = AnchorStyles.Left;
            textBox_Set_Usuario.Location = new Point(140, 50);
            textBox_Set_Usuario.Multiline = true;
            textBox_Set_Usuario.Name = "textBox_Set_Usuario";
            textBox_Set_Usuario.Size = new Size(100, 20);
            textBox_Set_Usuario.TabIndex = 3;
            textBox_Set_Usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label_Ex_Senha
            // 
            label_Ex_Senha.BorderStyle = BorderStyle.FixedSingle;
            label_Ex_Senha.ForeColor = Color.White;
            label_Ex_Senha.Location = new Point(250, 90);
            label_Ex_Senha.Name = "label_Ex_Senha";
            label_Ex_Senha.Size = new Size(120, 20);
            label_Ex_Senha.TabIndex = 8;
            label_Ex_Senha.Text = "(Ex: t*********3) ";
            label_Ex_Senha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_Legenda_Senha
            // 
            label_Legenda_Senha.BorderStyle = BorderStyle.FixedSingle;
            label_Legenda_Senha.ForeColor = Color.White;
            label_Legenda_Senha.Location = new Point(10, 90);
            label_Legenda_Senha.Name = "label_Legenda_Senha";
            label_Legenda_Senha.Size = new Size(120, 20);
            label_Legenda_Senha.TabIndex = 7;
            label_Legenda_Senha.Text = "Senha da Câmera";
            label_Legenda_Senha.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox_Set_Senha
            // 
            textBox_Set_Senha.Anchor = AnchorStyles.Left;
            textBox_Set_Senha.Location = new Point(140, 90);
            textBox_Set_Senha.Multiline = true;
            textBox_Set_Senha.Name = "textBox_Set_Senha";
            textBox_Set_Senha.PasswordChar = '*';
            textBox_Set_Senha.Size = new Size(100, 20);
            textBox_Set_Senha.TabIndex = 6;
            textBox_Set_Senha.TextAlign = HorizontalAlignment.Center;
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
            // label_Opcua_Legenda_Url
            // 
            label_Opcua_Legenda_Url.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_Url.ForeColor = Color.White;
            label_Opcua_Legenda_Url.Location = new Point(5, 20);
            label_Opcua_Legenda_Url.Name = "label_Opcua_Legenda_Url";
            label_Opcua_Legenda_Url.Size = new Size(90, 20);
            label_Opcua_Legenda_Url.TabIndex = 10;
            label_Opcua_Legenda_Url.Text = "Url";
            label_Opcua_Legenda_Url.TextAlign = ContentAlignment.BottomCenter;
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
            label_Opcua_Display_Url.TextAlign = ContentAlignment.BottomCenter;
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
            label_Opcua_Display_Verificacao_IP.TextAlign = ContentAlignment.BottomCenter;
            label_Opcua_Display_Verificacao_IP.Click += this.label_Opcua_Display_Verificacao_IP_Click;
            // 
            // label_Opcua_Legenda_Verificacao_IP
            // 
            label_Opcua_Legenda_Verificacao_IP.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_Verificacao_IP.ForeColor = Color.White;
            label_Opcua_Legenda_Verificacao_IP.Location = new Point(5, 80);
            label_Opcua_Legenda_Verificacao_IP.Name = "label_Opcua_Legenda_Verificacao_IP";
            label_Opcua_Legenda_Verificacao_IP.Size = new Size(220, 20);
            label_Opcua_Legenda_Verificacao_IP.TabIndex = 12;
            label_Opcua_Legenda_Verificacao_IP.Text = "Tempo de Verificação de IP";
            label_Opcua_Legenda_Verificacao_IP.TextAlign = ContentAlignment.BottomCenter;
            label_Opcua_Legenda_Verificacao_IP.Click += this.label_Opcua_Legenda_Verificacao_IP_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.White;
            label2.Location = new Point(5, 110);
            label2.Name = "label2";
            label2.Size = new Size(220, 20);
            label2.TabIndex = 14;
            label2.Text = "Tempo Total da Requisição";
            label2.TextAlign = ContentAlignment.BottomCenter;
            label2.Click += this.label2_Click;
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
            label3.TextAlign = ContentAlignment.BottomCenter;
            label3.Click += this.label3_Click;
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
            label_Opcua_Display_Status.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_Opcua_Legenda_Status
            // 
            label_Opcua_Legenda_Status.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_Status.ForeColor = Color.White;
            label_Opcua_Legenda_Status.Location = new Point(5, 50);
            label_Opcua_Legenda_Status.Name = "label_Opcua_Legenda_Status";
            label_Opcua_Legenda_Status.Size = new Size(220, 20);
            label_Opcua_Legenda_Status.TabIndex = 16;
            label_Opcua_Legenda_Status.Text = "Status do Servidor OpcUa";
            label_Opcua_Legenda_Status.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_Opcua_Legenda_uNumeroCargaRelEntrada
            // 
            label_Opcua_Legenda_uNumeroCargaRelEntrada.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_uNumeroCargaRelEntrada.ForeColor = Color.White;
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Location = new Point(5, 415);
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Name = "label_Opcua_Legenda_uNumeroCargaRelEntrada";
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Size = new Size(220, 20);
            label_Opcua_Legenda_uNumeroCargaRelEntrada.TabIndex = 18;
            label_Opcua_Legenda_uNumeroCargaRelEntrada.Text = "uNumeroCargaRelEntrada";
            label_Opcua_Legenda_uNumeroCargaRelEntrada.TextAlign = ContentAlignment.BottomCenter;
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
            label_Opcua_Display_uNumeroCargaRelEntrada.TextAlign = ContentAlignment.BottomCenter;
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
            label_Opcua_Display_xIniciaRelatorioCameraEntrada.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label_Opcua_Legenda_xIniciaRelatorioCameraEntrada
            // 
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.BorderStyle = BorderStyle.FixedSingle;
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.ForeColor = Color.White;
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Location = new Point(6, 389);
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Name = "label_Opcua_Legenda_xIniciaRelatorioCameraEntrada";
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Size = new Size(220, 20);
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.TabIndex = 20;
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.Text = "xIniciaRelatorioCameraEntrada";
            label_Opcua_Legenda_xIniciaRelatorioCameraEntrada.TextAlign = ContentAlignment.BottomCenter;
            // 
            // groupBox_Status_Camera
            // 
            groupBox_Status_Camera.Controls.Add(label5);
            groupBox_Status_Camera.Controls.Add(label4);
            groupBox_Status_Camera.ForeColor = Color.White;
            groupBox_Status_Camera.Location = new Point(10, 200);
            groupBox_Status_Camera.Name = "groupBox_Status_Camera";
            groupBox_Status_Camera.Size = new Size(400, 250);
            groupBox_Status_Camera.TabIndex = 10;
            groupBox_Status_Camera.TabStop = false;
            groupBox_Status_Camera.Text = "Status da Câmera";
            // 
            // button_Atualizar_dados
            // 
            button_Atualizar_dados.Location = new Point(295, 120);
            button_Atualizar_dados.Name = "button_Atualizar_dados";
            button_Atualizar_dados.Size = new Size(75, 23);
            button_Atualizar_dados.TabIndex = 11;
            button_Atualizar_dados.Text = "Atualizar";
            button_Atualizar_dados.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.ForeColor = Color.White;
            label4.Location = new Point(5, 20);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 22;
            label4.Text = "Url";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.ForeColor = Color.White;
            label5.Location = new Point(100, 20);
            label5.Name = "label5";
            label5.Size = new Size(295, 20);
            label5.TabIndex = 22;
            label5.Text = "opc.tcp://10.10.01.10:4840";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Form_Configuracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(784, 461);
            Controls.Add(button_Atualizar_dados);
            Controls.Add(groupBox_Status_Camera);
            Controls.Add(groupBox_Status_OPC);
            Controls.Add(label_Ex_Senha);
            Controls.Add(label_Legenda_Senha);
            Controls.Add(textBox_Set_Senha);
            Controls.Add(label_Ex_Usuario);
            Controls.Add(label_Legenda_Usuario);
            Controls.Add(textBox_Set_Usuario);
            Controls.Add(label1);
            Controls.Add(label_Legenda_Bloco_de_Rede);
            Controls.Add(textBox_Set_Bloco_de_Rede);
            Name = "Form_Configuracao";
            Text = "Form_Configuracao";
            Load += this.Form_Configuracao_Load;
            groupBox_Status_OPC.ResumeLayout(false);
            groupBox_Status_Camera.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Set_Bloco_de_Rede;
        private Label label_Legenda_Bloco_de_Rede;
        private Label label1;
        private Label label_Ex_Usuario;
        private Label label_Legenda_Usuario;
        private TextBox textBox_Set_Usuario;
        private Label label_Ex_Senha;
        private Label label_Legenda_Senha;
        private TextBox textBox_Set_Senha;
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
        private Button button_Atualizar_dados;
        private Label label5;
        private Label label4;
    }
}
