namespace Estruturas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlContainer = new Panel();
            pibImagem = new PictureBox();
            btnSair = new Button();
            pnlLogin = new Panel();
            btnLimpar = new Button();
            btnTestar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lsbMostra = new ListBox();
            lblBotões = new Label();
            pnlRepeticao = new Panel();
            btnBobEsp = new Button();
            btnBlocodn = new Button();
            btnCalculadora = new Button();
            btnCalculaJ = new Button();
            btnJurosComp = new Button();
            btnMontante = new Button();
            btnJurosSimples = new Button();
            lblRegistro = new Label();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pibImagem).BeginInit();
            pnlLogin.SuspendLayout();
            pnlRepeticao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.None;
            pnlContainer.BackColor = SystemColors.Control;
            pnlContainer.Controls.Add(pibImagem);
            pnlContainer.Controls.Add(btnSair);
            pnlContainer.Controls.Add(pnlLogin);
            pnlContainer.Controls.Add(lsbMostra);
            pnlContainer.Controls.Add(lblBotões);
            pnlContainer.Controls.Add(pnlRepeticao);
            pnlContainer.Controls.Add(lblRegistro);
            pnlContainer.Location = new Point(44, 45);
            pnlContainer.Margin = new Padding(4, 5, 4, 5);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1253, 830);
            pnlContainer.TabIndex = 0;
            // 
            // pibImagem
            // 
            pibImagem.Image = (Image)resources.GetObject("pibImagem.Image");
            pibImagem.Location = new Point(530, 664);
            pibImagem.Margin = new Padding(4, 5, 4, 5);
            pibImagem.Name = "pibImagem";
            pibImagem.Size = new Size(591, 166);
            pibImagem.TabIndex = 11;
            pibImagem.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Cursor = Cursors.Hand;
            btnSair.Location = new Point(987, 36);
            btnSair.Margin = new Padding(4, 5, 4, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(147, 63);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair do sistema";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.Fixed3D;
            pnlLogin.Controls.Add(btnLimpar);
            pnlLogin.Controls.Add(btnTestar);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(lblSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Location = new Point(103, 110);
            pnlLogin.Margin = new Padding(4, 5, 4, 5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(384, 229);
            pnlLogin.TabIndex = 10;
            // 
            // btnLimpar
            // 
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(227, 148);
            btnLimpar.Margin = new Padding(4, 5, 4, 5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(130, 38);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnTestar
            // 
            btnTestar.Cursor = Cursors.Hand;
            btnTestar.Location = new Point(227, 57);
            btnTestar.Margin = new Padding(4, 5, 4, 5);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(130, 38);
            btnTestar.TabIndex = 1;
            btnTestar.Text = "Entrar";
            btnTestar.UseVisualStyleBackColor = true;
            btnTestar.Click += btnTestar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(29, 148);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.MaxLength = 20;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(161, 31);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(29, 117);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(29, 57);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(161, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(29, 25);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // lsbMostra
            // 
            lsbMostra.FormattingEnabled = true;
            lsbMostra.Location = new Point(518, 108);
            lsbMostra.Margin = new Padding(4, 5, 4, 5);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(616, 729);
            lsbMostra.TabIndex = 9;
            // 
            // lblBotões
            // 
            lblBotões.AutoSize = true;
            lblBotões.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBotões.Location = new Point(103, 370);
            lblBotões.Margin = new Padding(4, 0, 4, 0);
            lblBotões.Name = "lblBotões";
            lblBotões.Size = new Size(261, 32);
            lblBotões.TabIndex = 8;
            lblBotões.Text = "Calculos Empresariais";
            // 
            // pnlRepeticao
            // 
            pnlRepeticao.BorderStyle = BorderStyle.Fixed3D;
            pnlRepeticao.Controls.Add(btnBobEsp);
            pnlRepeticao.Controls.Add(btnBlocodn);
            pnlRepeticao.Controls.Add(btnCalculadora);
            pnlRepeticao.Controls.Add(btnCalculaJ);
            pnlRepeticao.Controls.Add(btnJurosComp);
            pnlRepeticao.Controls.Add(btnMontante);
            pnlRepeticao.Controls.Add(btnJurosSimples);
            pnlRepeticao.Location = new Point(103, 425);
            pnlRepeticao.Margin = new Padding(4, 5, 4, 5);
            pnlRepeticao.Name = "pnlRepeticao";
            pnlRepeticao.Size = new Size(384, 400);
            pnlRepeticao.TabIndex = 7;
            // 
            // btnBobEsp
            // 
            btnBobEsp.Cursor = Cursors.Hand;
            btnBobEsp.Location = new Point(47, 322);
            btnBobEsp.Margin = new Padding(4, 5, 4, 5);
            btnBobEsp.Name = "btnBobEsp";
            btnBobEsp.Size = new Size(293, 67);
            btnBobEsp.TabIndex = 11;
            btnBobEsp.Text = "Assistir Bob Esponja";
            btnBobEsp.UseVisualStyleBackColor = true;
            btnBobEsp.Click += btnBobEsp_Click;
            // 
            // btnBlocodn
            // 
            btnBlocodn.Cursor = Cursors.Hand;
            btnBlocodn.Location = new Point(209, 217);
            btnBlocodn.Margin = new Padding(4, 5, 4, 5);
            btnBlocodn.Name = "btnBlocodn";
            btnBlocodn.Size = new Size(130, 67);
            btnBlocodn.TabIndex = 10;
            btnBlocodn.Text = "Bloco de notas";
            btnBlocodn.UseVisualStyleBackColor = true;
            btnBlocodn.Click += btnBlocodn_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.Cursor = Cursors.Hand;
            btnCalculadora.Location = new Point(46, 217);
            btnCalculadora.Margin = new Padding(4, 5, 4, 5);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(130, 67);
            btnCalculadora.TabIndex = 9;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnCalculaJ
            // 
            btnCalculaJ.Cursor = Cursors.Hand;
            btnCalculaJ.Location = new Point(210, 113);
            btnCalculaJ.Margin = new Padding(4, 5, 4, 5);
            btnCalculaJ.Name = "btnCalculaJ";
            btnCalculaJ.Size = new Size(130, 67);
            btnCalculaJ.TabIndex = 8;
            btnCalculaJ.Text = "Calculadora de juros";
            btnCalculaJ.UseVisualStyleBackColor = true;
            btnCalculaJ.Click += btnCalculaJ_Click;
            // 
            // btnJurosComp
            // 
            btnJurosComp.Cursor = Cursors.Hand;
            btnJurosComp.Location = new Point(47, 113);
            btnJurosComp.Margin = new Padding(4, 5, 4, 5);
            btnJurosComp.Name = "btnJurosComp";
            btnJurosComp.Size = new Size(130, 67);
            btnJurosComp.TabIndex = 7;
            btnJurosComp.Text = "Juros composto";
            btnJurosComp.UseVisualStyleBackColor = true;
            btnJurosComp.Click += btnJurosComp_Click;
            // 
            // btnMontante
            // 
            btnMontante.Cursor = Cursors.Hand;
            btnMontante.Location = new Point(209, 17);
            btnMontante.Margin = new Padding(4, 5, 4, 5);
            btnMontante.Name = "btnMontante";
            btnMontante.Size = new Size(130, 67);
            btnMontante.TabIndex = 6;
            btnMontante.Text = "Montante";
            btnMontante.UseVisualStyleBackColor = true;
            btnMontante.Click += btnMontante_Click;
            // 
            // btnJurosSimples
            // 
            btnJurosSimples.Cursor = Cursors.Hand;
            btnJurosSimples.Location = new Point(46, 17);
            btnJurosSimples.Margin = new Padding(4, 5, 4, 5);
            btnJurosSimples.Name = "btnJurosSimples";
            btnJurosSimples.Size = new Size(130, 67);
            btnJurosSimples.TabIndex = 5;
            btnJurosSimples.Text = "Juros simples";
            btnJurosSimples.UseVisualStyleBackColor = true;
            btnJurosSimples.Click += btnJurosSimples_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistro.Location = new Point(103, 67);
            lblRegistro.Margin = new Padding(4, 0, 4, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(280, 32);
            lblRegistro.TabIndex = 6;
            lblRegistro.Text = "Registro de Empresario";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1270, 875);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Empresários Jovens";
            WindowState = FormWindowState.Maximized;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pibImagem).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRepeticao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private ListBox lsbMostra;
        private Label lblBotões;
        private Panel pnlRepeticao;
        private Button btnBlocodn;
        private Button btnCalculadora;
        private Button btnCalculaJ;
        private Button btnJurosComp;
        private Button btnMontante;
        private Button btnJurosSimples;
        private Label lblRegistro;
        private Panel pnlLogin;
        private Button btnLimpar;
        private Button btnTestar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnSair;
        private PictureBox pibImagem;
        private Button btnBobEsp;
    }
}
