namespace Trabajo_Practico
{
    partial class Cambio_de_contraseña
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
            Tb_NewPass = new TextBox();
            Tb_ConfirmPass = new TextBox();
            TB_NUser = new TextBox();
            lbl_Nuser = new Label();
            Lbl_NewPass = new Label();
            lbl_CodConfimation = new Label();
            Btn_Confirmar = new Button();
            Btn_Cancelar = new Button();
            BTN_Verificacion = new Button();
            tb_CodConfimation = new TextBox();
            Btn_ConfirmCode = new Button();
            Lbl_PassCofirm = new Label();
            SuspendLayout();
            // 
            // Tb_NewPass
            // 
            Tb_NewPass.Location = new Point(23, 164);
            Tb_NewPass.Name = "Tb_NewPass";
            Tb_NewPass.PasswordChar = '*';
            Tb_NewPass.Size = new Size(100, 23);
            Tb_NewPass.TabIndex = 0;
            Tb_NewPass.Visible = false;
            // 
            // Tb_ConfirmPass
            // 
            Tb_ConfirmPass.Location = new Point(143, 164);
            Tb_ConfirmPass.Name = "Tb_ConfirmPass";
            Tb_ConfirmPass.PasswordChar = '*';
            Tb_ConfirmPass.Size = new Size(100, 23);
            Tb_ConfirmPass.TabIndex = 1;
            Tb_ConfirmPass.Visible = false;
            // 
            // TB_NUser
            // 
            TB_NUser.Location = new Point(23, 58);
            TB_NUser.Name = "TB_NUser";
            TB_NUser.Size = new Size(100, 23);
            TB_NUser.TabIndex = 2;
            // 
            // lbl_Nuser
            // 
            lbl_Nuser.AutoSize = true;
            lbl_Nuser.Location = new Point(23, 40);
            lbl_Nuser.Name = "lbl_Nuser";
            lbl_Nuser.Size = new Size(76, 15);
            lbl_Nuser.TabIndex = 3;
            lbl_Nuser.Text = "N°de usuario";
            // 
            // Lbl_NewPass
            // 
            Lbl_NewPass.AutoSize = true;
            Lbl_NewPass.Location = new Point(23, 146);
            Lbl_NewPass.Name = "Lbl_NewPass";
            Lbl_NewPass.Size = new Size(102, 15);
            Lbl_NewPass.TabIndex = 4;
            Lbl_NewPass.Text = "Nueva contraseña";
            Lbl_NewPass.Visible = false;
            // 
            // lbl_CodConfimation
            // 
            lbl_CodConfimation.AutoSize = true;
            lbl_CodConfimation.Location = new Point(29, 84);
            lbl_CodConfimation.Name = "lbl_CodConfimation";
            lbl_CodConfimation.Size = new Size(83, 30);
            lbl_CodConfimation.TabIndex = 5;
            lbl_CodConfimation.Text = "Confirmacion \r\nde codigo";
            lbl_CodConfimation.Visible = false;
            // 
            // Btn_Confirmar
            // 
            Btn_Confirmar.Location = new Point(29, 207);
            Btn_Confirmar.Name = "Btn_Confirmar";
            Btn_Confirmar.Size = new Size(75, 23);
            Btn_Confirmar.TabIndex = 6;
            Btn_Confirmar.Text = "Confirmar";
            Btn_Confirmar.UseVisualStyleBackColor = true;
            Btn_Confirmar.Click += Btn_Confirmar_Click;
            // 
            // Btn_Cancelar
            // 
            Btn_Cancelar.BackColor = Color.Red;
            Btn_Cancelar.Location = new Point(151, 207);
            Btn_Cancelar.Name = "Btn_Cancelar";
            Btn_Cancelar.Size = new Size(75, 23);
            Btn_Cancelar.TabIndex = 7;
            Btn_Cancelar.Text = "Cancelar";
            Btn_Cancelar.UseVisualStyleBackColor = false;
            Btn_Cancelar.Click += Btn_Cancelar_Click;
            // 
            // BTN_Verificacion
            // 
            BTN_Verificacion.Location = new Point(143, 56);
            BTN_Verificacion.Name = "BTN_Verificacion";
            BTN_Verificacion.Size = new Size(143, 24);
            BTN_Verificacion.TabIndex = 8;
            BTN_Verificacion.Text = "Codigo de verificación";
            BTN_Verificacion.UseVisualStyleBackColor = true;
            BTN_Verificacion.Click += BTN_Verificacion_Click;
            // 
            // tb_CodConfimation
            // 
            tb_CodConfimation.Location = new Point(23, 117);
            tb_CodConfimation.Name = "tb_CodConfimation";
            tb_CodConfimation.PasswordChar = '*';
            tb_CodConfimation.Size = new Size(100, 23);
            tb_CodConfimation.TabIndex = 9;
            tb_CodConfimation.Visible = false;
            // 
            // Btn_ConfirmCode
            // 
            Btn_ConfirmCode.Location = new Point(151, 116);
            Btn_ConfirmCode.Name = "Btn_ConfirmCode";
            Btn_ConfirmCode.Size = new Size(75, 23);
            Btn_ConfirmCode.TabIndex = 10;
            Btn_ConfirmCode.Text = "Confirmar";
            Btn_ConfirmCode.UseVisualStyleBackColor = true;
            Btn_ConfirmCode.Visible = false;
            Btn_ConfirmCode.Click += Btn_ConfirmCode_Click;
            // 
            // Lbl_PassCofirm
            // 
            Lbl_PassCofirm.AutoSize = true;
            Lbl_PassCofirm.Location = new Point(143, 146);
            Lbl_PassCofirm.Name = "Lbl_PassCofirm";
            Lbl_PassCofirm.Size = new Size(120, 15);
            Lbl_PassCofirm.TabIndex = 11;
            Lbl_PassCofirm.Text = "confirmar contraseña";
            Lbl_PassCofirm.Visible = false;
            // 
            // Cambio_de_contraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(318, 252);
            Controls.Add(Lbl_PassCofirm);
            Controls.Add(Btn_ConfirmCode);
            Controls.Add(tb_CodConfimation);
            Controls.Add(BTN_Verificacion);
            Controls.Add(Btn_Cancelar);
            Controls.Add(Btn_Confirmar);
            Controls.Add(lbl_CodConfimation);
            Controls.Add(Lbl_NewPass);
            Controls.Add(lbl_Nuser);
            Controls.Add(TB_NUser);
            Controls.Add(Tb_ConfirmPass);
            Controls.Add(Tb_NewPass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cambio_de_contraseña";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cambio de Contraseña";
            Load += Cambio_de_contraseña_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Tb_NewPass;
        private TextBox Tb_ConfirmPass;
        private TextBox TB_NUser;
        private Label lbl_Nuser;
        private Label Lbl_NewPass;
        private Label lbl_CodConfimation;
        private Button Btn_Confirmar;
        private Button Btn_Cancelar;
        private Button BTN_Verificacion;
        private TextBox tb_CodConfimation;
        private Button Btn_ConfirmCode;
        private Label Lbl_PassCofirm;
    }
}