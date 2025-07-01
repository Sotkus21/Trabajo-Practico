namespace Trabajo_Practico
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Tb_User = new TextBox();
            Tb_Pass = new TextBox();
            Lbl_User = new Label();
            Lbl_Pass = new Label();
            btn_Inicio = new Button();
            LBL_Cambio = new LinkLabel();
            SuspendLayout();
            // 
            // Tb_User
            // 
            Tb_User.Location = new Point(188, 99);
            Tb_User.Name = "Tb_User";
            Tb_User.Size = new Size(100, 23);
            Tb_User.TabIndex = 0;
            // 
            // Tb_Pass
            // 
            Tb_Pass.Location = new Point(188, 156);
            Tb_Pass.Name = "Tb_Pass";
            Tb_Pass.PasswordChar = '*';
            Tb_Pass.Size = new Size(100, 23);
            Tb_Pass.TabIndex = 1;
            // 
            // Lbl_User
            // 
            Lbl_User.AutoSize = true;
            Lbl_User.Location = new Point(188, 81);
            Lbl_User.Name = "Lbl_User";
            Lbl_User.Size = new Size(47, 15);
            Lbl_User.TabIndex = 2;
            Lbl_User.Text = "Usuario";
            // 
            // Lbl_Pass
            // 
            Lbl_Pass.AutoSize = true;
            Lbl_Pass.Location = new Point(188, 138);
            Lbl_Pass.Name = "Lbl_Pass";
            Lbl_Pass.Size = new Size(67, 15);
            Lbl_Pass.TabIndex = 3;
            Lbl_Pass.Text = "Contraseña";
            // 
            // btn_Inicio
            // 
            btn_Inicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_Inicio.Location = new Point(191, 209);
            btn_Inicio.Name = "btn_Inicio";
            btn_Inicio.Size = new Size(75, 23);
            btn_Inicio.TabIndex = 4;
            btn_Inicio.Text = "Iniciar";
            btn_Inicio.UseVisualStyleBackColor = true;
            btn_Inicio.Click += btn_Inicio_Click;
            // 
            // LBL_Cambio
            // 
            LBL_Cambio.AutoSize = true;
            LBL_Cambio.LinkColor = Color.Purple;
            LBL_Cambio.Location = new Point(171, 182);
            LBL_Cambio.Name = "LBL_Cambio";
            LBL_Cambio.Size = new Size(128, 15);
            LBL_Cambio.TabIndex = 5;
            LBL_Cambio.TabStop = true;
            LBL_Cambio.Text = "Cambio de Contraseña";
            LBL_Cambio.LinkClicked += LBL_Cambio_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(311, 292);
            Controls.Add(LBL_Cambio);
            Controls.Add(btn_Inicio);
            Controls.Add(Lbl_Pass);
            Controls.Add(Lbl_User);
            Controls.Add(Tb_Pass);
            Controls.Add(Tb_User);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_User;
        private TextBox Tb_Pass;
        private Label Lbl_User;
        private Label Lbl_Pass;
        private Button btn_Inicio;
        private LinkLabel LBL_Cambio;
    }
}
