namespace EmailHandler.TesteEmail
{
    partial class frmTesteEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteEmail));
            this.grbDePara = new System.Windows.Forms.GroupBox();
            this.txtAssuntoTitulo = new System.Windows.Forms.TextBox();
            this.txtEnviarPara = new System.Windows.Forms.TextBox();
            this.lblSubjectLine = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.grpMensagem = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.grpAnexos = new System.Windows.Forms.GroupBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.txtAnexos = new System.Windows.Forms.TextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkSSL = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmailProp = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMTP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDePara.SuspendLayout();
            this.grpMensagem.SuspendLayout();
            this.grpAnexos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDePara
            // 
            this.grbDePara.Controls.Add(this.txtAssuntoTitulo);
            this.grbDePara.Controls.Add(this.txtEnviarPara);
            this.grbDePara.Controls.Add(this.lblSubjectLine);
            this.grbDePara.Controls.Add(this.lblDestinatario);
            this.grbDePara.Location = new System.Drawing.Point(12, 138);
            this.grbDePara.Name = "grbDePara";
            this.grbDePara.Size = new System.Drawing.Size(485, 100);
            this.grbDePara.TabIndex = 0;
            this.grbDePara.TabStop = false;
            this.grbDePara.Text = "Para:";
            // 
            // txtAssuntoTitulo
            // 
            this.txtAssuntoTitulo.Location = new System.Drawing.Point(70, 50);
            this.txtAssuntoTitulo.Name = "txtAssuntoTitulo";
            this.txtAssuntoTitulo.Size = new System.Drawing.Size(399, 20);
            this.txtAssuntoTitulo.TabIndex = 5;
            this.txtAssuntoTitulo.Text = "Email Teste (DESCONSIDERE)";
            // 
            // txtEnviarPara
            // 
            this.txtEnviarPara.Location = new System.Drawing.Point(70, 22);
            this.txtEnviarPara.Name = "txtEnviarPara";
            this.txtEnviarPara.Size = new System.Drawing.Size(399, 20);
            this.txtEnviarPara.TabIndex = 3;
            this.txtEnviarPara.Text = "jeferson.uaisoft@gmail.com";
            // 
            // lblSubjectLine
            // 
            this.lblSubjectLine.AutoSize = true;
            this.lblSubjectLine.Location = new System.Drawing.Point(11, 54);
            this.lblSubjectLine.Name = "lblSubjectLine";
            this.lblSubjectLine.Size = new System.Drawing.Size(48, 13);
            this.lblSubjectLine.TabIndex = 2;
            this.lblSubjectLine.Text = "Assunto:";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(28, 25);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(32, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Para:";
            // 
            // grpMensagem
            // 
            this.grpMensagem.Controls.Add(this.btnCancelar);
            this.grpMensagem.Controls.Add(this.txtMensagem);
            this.grpMensagem.Controls.Add(this.btnEnviar);
            this.grpMensagem.Controls.Add(this.grpAnexos);
            this.grpMensagem.Location = new System.Drawing.Point(12, 245);
            this.grpMensagem.Name = "grpMensagem";
            this.grpMensagem.Size = new System.Drawing.Size(485, 236);
            this.grpMensagem.TabIndex = 1;
            this.grpMensagem.TabStop = false;
            this.grpMensagem.Text = "Mensagem";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(25, 20);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(444, 93);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.Text = "Este email foi enviado para teste de provedor.\r\nPor favor desconsidere o mesmo.\r\n" +
    "Obrigado.\r\n";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(400, 204);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // grpAnexos
            // 
            this.grpAnexos.Controls.Add(this.btnIncluir);
            this.grpAnexos.Controls.Add(this.txtAnexos);
            this.grpAnexos.Location = new System.Drawing.Point(6, 135);
            this.grpAnexos.Name = "grpAnexos";
            this.grpAnexos.Size = new System.Drawing.Size(485, 63);
            this.grpAnexos.TabIndex = 2;
            this.grpAnexos.TabStop = false;
            this.grpAnexos.Text = "Anexos";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(394, 23);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // txtAnexos
            // 
            this.txtAnexos.Location = new System.Drawing.Point(25, 25);
            this.txtAnexos.Name = "txtAnexos";
            this.txtAnexos.Size = new System.Drawing.Size(363, 20);
            this.txtAnexos.TabIndex = 6;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Add Attachment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkSSL);
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.txtEmailProp);
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSMTP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração Servidor";
            // 
            // chkSSL
            // 
            this.chkSSL.AutoSize = true;
            this.chkSSL.Checked = true;
            this.chkSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSSL.Location = new System.Drawing.Point(255, 100);
            this.chkSSL.Name = "chkSSL";
            this.chkSSL.Size = new System.Drawing.Size(46, 17);
            this.chkSSL.TabIndex = 6;
            this.chkSSL.Text = "SSL";
            this.chkSSL.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(70, 96);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(173, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.Text = "saeopdqgzjtntsdc";
            // 
            // txtEmailProp
            // 
            this.txtEmailProp.Location = new System.Drawing.Point(70, 70);
            this.txtEmailProp.Name = "txtEmailProp";
            this.txtEmailProp.Size = new System.Drawing.Size(399, 20);
            this.txtEmailProp.TabIndex = 5;
            this.txtEmailProp.Text = "mensageriauaisoft@gmail.com";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(70, 46);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(399, 20);
            this.txtPorta.TabIndex = 4;
            this.txtPorta.Text = "587";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Senha";
            // 
            // txtSMTP
            // 
            this.txtSMTP.Location = new System.Drawing.Point(70, 22);
            this.txtSMTP.Name = "txtSMTP";
            this.txtSMTP.Size = new System.Drawing.Size(399, 20);
            this.txtSMTP.TabIndex = 3;
            this.txtSMTP.Text = "smtp.gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Porta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "SMTP:";
            // 
            // frmTesteEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(509, 483);
            this.Controls.Add(this.grpMensagem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbDePara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTesteEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviando Emails";
            this.grbDePara.ResumeLayout(false);
            this.grbDePara.PerformLayout();
            this.grpMensagem.ResumeLayout(false);
            this.grpMensagem.PerformLayout();
            this.grpAnexos.ResumeLayout(false);
            this.grpAnexos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDePara;
        private System.Windows.Forms.TextBox txtAssuntoTitulo;
        private System.Windows.Forms.TextBox txtEnviarPara;
        private System.Windows.Forms.Label lblSubjectLine;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.GroupBox grpMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.GroupBox grpAnexos;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtAnexos;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmailProp;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtSMTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSSL;
    }
}

