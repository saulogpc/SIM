namespace SIM
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.painelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.painelConteudoCentral = new System.Windows.Forms.Panel();
            this.painelRodape = new System.Windows.Forms.Panel();
            this.imgPerfilMiniatura = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.picBoxLogoTelaLogin = new System.Windows.Forms.PictureBox();
            this.painelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfilMiniatura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoTelaLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // painelBarraTitulo
            // 
            this.painelBarraTitulo.BackColor = System.Drawing.Color.RoyalBlue;
            this.painelBarraTitulo.Controls.Add(this.lblNomeUsuario);
            this.painelBarraTitulo.Controls.Add(this.imgPerfilMiniatura);
            this.painelBarraTitulo.Controls.Add(this.bunifuMaterialTextbox1);
            this.painelBarraTitulo.Controls.Add(this.bunifuImageButton1);
            this.painelBarraTitulo.Controls.Add(this.picBoxLogoTelaLogin);
            this.painelBarraTitulo.Controls.Add(this.button2);
            this.painelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.painelBarraTitulo.Name = "painelBarraTitulo";
            this.painelBarraTitulo.Size = new System.Drawing.Size(1184, 133);
            this.painelBarraTitulo.TabIndex = 0;
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNomeUsuario.Location = new System.Drawing.Point(690, 22);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(57, 21);
            this.lblNomeUsuario.TabIndex = 4;
            this.lblNomeUsuario.Text = "label1";
            this.lblNomeUsuario.Visible = false;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(195, 10);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(379, 33);
            this.bunifuMaterialTextbox1.TabIndex = 2;
            this.bunifuMaterialTextbox1.Text = "Busca";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.Visible = false;
            this.bunifuMaterialTextbox1.Click += new System.EventHandler(this.bunifuMaterialTextbox1_OnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1106, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mostrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.painelBarraTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // painelConteudoCentral
            // 
            this.painelConteudoCentral.BackColor = System.Drawing.SystemColors.Control;
            this.painelConteudoCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelConteudoCentral.Location = new System.Drawing.Point(0, 133);
            this.painelConteudoCentral.Name = "painelConteudoCentral";
            this.painelConteudoCentral.Size = new System.Drawing.Size(1184, 577);
            this.painelConteudoCentral.TabIndex = 1;
            this.painelConteudoCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.painelConteudoCentral_Paint);
            // 
            // painelRodape
            // 
            this.painelRodape.BackColor = System.Drawing.Color.RoyalBlue;
            this.painelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelRodape.Location = new System.Drawing.Point(0, 660);
            this.painelRodape.Name = "painelRodape";
            this.painelRodape.Size = new System.Drawing.Size(1184, 50);
            this.painelRodape.TabIndex = 9;
            // 
            // imgPerfilMiniatura
            // 
            this.imgPerfilMiniatura.Location = new System.Drawing.Point(642, 10);
            this.imgPerfilMiniatura.Name = "imgPerfilMiniatura";
            this.imgPerfilMiniatura.Size = new System.Drawing.Size(42, 39);
            this.imgPerfilMiniatura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPerfilMiniatura.TabIndex = 3;
            this.imgPerfilMiniatura.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = global::SIM.Properties.Resources.x;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1142, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 18);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // picBoxLogoTelaLogin
            // 
            this.picBoxLogoTelaLogin.Image = global::SIM.Properties.Resources.NovaLogo2;
            this.picBoxLogoTelaLogin.Location = new System.Drawing.Point(2, 1);
            this.picBoxLogoTelaLogin.Name = "picBoxLogoTelaLogin";
            this.picBoxLogoTelaLogin.Size = new System.Drawing.Size(186, 130);
            this.picBoxLogoTelaLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogoTelaLogin.TabIndex = 0;
            this.picBoxLogoTelaLogin.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 710);
            this.Controls.Add(this.painelRodape);
            this.Controls.Add(this.painelConteudoCentral);
            this.Controls.Add(this.painelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.painelBarraTitulo.ResumeLayout(false);
            this.painelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfilMiniatura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoTelaLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox picBoxLogoTelaLogin;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Panel painelBarraTitulo;
        public System.Windows.Forms.Panel painelConteudoCentral;
        private System.Windows.Forms.Panel painelRodape;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.PictureBox imgPerfilMiniatura;
    }
}

