namespace Trabajo_Practico
{
    partial class Fmr_Usuario
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
            btn_Confirm = new Button();
            Btn_Cancel = new Button();
            Tb_NUser = new TextBox();
            TB_Name = new TextBox();
            Tb_Apellido = new TextBox();
            Tb_NewPass = new TextBox();
            TB_ConfirmNewPass = new TextBox();
            Lbl_NUser = new Label();
            Lbl_NameCompleto = new Label();
            Lbl_ApellidoCompleto = new Label();
            Lbl_Pass = new Label();
            Lbl_NewPass = new Label();
            TB_NameUser = new TextBox();
            Lbl_NameUser = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btn_Confirm
            // 
            btn_Confirm.Location = new Point(45, 216);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(75, 23);
            btn_Confirm.TabIndex = 0;
            btn_Confirm.Text = "Confirmar";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.Red;
            Btn_Cancel.Location = new Point(155, 216);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(75, 23);
            Btn_Cancel.TabIndex = 1;
            Btn_Cancel.Text = "Cancelar";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Tb_NUser
            // 
            Tb_NUser.Location = new Point(36, 70);
            Tb_NUser.Name = "Tb_NUser";
            Tb_NUser.ReadOnly = true;
            Tb_NUser.ShortcutsEnabled = false;
            Tb_NUser.Size = new Size(100, 23);
            Tb_NUser.TabIndex = 2;
            Tb_NUser.WordWrap = false;
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(36, 121);
            TB_Name.Name = "TB_Name";
            TB_Name.ReadOnly = true;
            TB_Name.Size = new Size(100, 23);
            TB_Name.TabIndex = 3;
            // 
            // Tb_Apellido
            // 
            Tb_Apellido.Location = new Point(155, 121);
            Tb_Apellido.Name = "Tb_Apellido";
            Tb_Apellido.ReadOnly = true;
            Tb_Apellido.Size = new Size(100, 23);
            Tb_Apellido.TabIndex = 4;
            // 
            // Tb_NewPass
            // 
            Tb_NewPass.Location = new Point(36, 168);
            Tb_NewPass.Name = "Tb_NewPass";
            Tb_NewPass.PasswordChar = '*';
            Tb_NewPass.Size = new Size(100, 23);
            Tb_NewPass.TabIndex = 5;
            // 
            // TB_ConfirmNewPass
            // 
            TB_ConfirmNewPass.Location = new Point(155, 168);
            TB_ConfirmNewPass.Name = "TB_ConfirmNewPass";
            TB_ConfirmNewPass.PasswordChar = '*';
            TB_ConfirmNewPass.Size = new Size(100, 23);
            TB_ConfirmNewPass.TabIndex = 6;
            // 
            // Lbl_NUser
            // 
            Lbl_NUser.AutoSize = true;
            Lbl_NUser.Location = new Point(33, 50);
            Lbl_NUser.Name = "Lbl_NUser";
            Lbl_NUser.Size = new Size(80, 15);
            Lbl_NUser.TabIndex = 7;
            Lbl_NUser.Text = "N° de Usuario";
            // 
            // Lbl_NameCompleto
            // 
            Lbl_NameCompleto.AutoSize = true;
            Lbl_NameCompleto.Location = new Point(36, 103);
            Lbl_NameCompleto.Name = "Lbl_NameCompleto";
            Lbl_NameCompleto.Size = new Size(105, 15);
            Lbl_NameCompleto.TabIndex = 8;
            Lbl_NameCompleto.Text = "Nombre completo";
            // 
            // Lbl_ApellidoCompleto
            // 
            Lbl_ApellidoCompleto.AutoSize = true;
            Lbl_ApellidoCompleto.Location = new Point(155, 103);
            Lbl_ApellidoCompleto.Name = "Lbl_ApellidoCompleto";
            Lbl_ApellidoCompleto.Size = new Size(105, 15);
            Lbl_ApellidoCompleto.TabIndex = 9;
            Lbl_ApellidoCompleto.Text = "Apellido completo";
            // 
            // Lbl_Pass
            // 
            Lbl_Pass.AutoSize = true;
            Lbl_Pass.Location = new Point(36, 150);
            Lbl_Pass.Name = "Lbl_Pass";
            Lbl_Pass.Size = new Size(67, 15);
            Lbl_Pass.TabIndex = 10;
            Lbl_Pass.Text = "Contraseña";
            // 
            // Lbl_NewPass
            // 
            Lbl_NewPass.AutoSize = true;
            Lbl_NewPass.Location = new Point(155, 150);
            Lbl_NewPass.Name = "Lbl_NewPass";
            Lbl_NewPass.Size = new Size(157, 15);
            Lbl_NewPass.TabIndex = 11;
            Lbl_NewPass.Text = "Confirmacion de contraseña";
            // 
            // TB_NameUser
            // 
            TB_NameUser.Location = new Point(155, 70);
            TB_NameUser.Name = "TB_NameUser";
            TB_NameUser.ReadOnly = true;
            TB_NameUser.Size = new Size(100, 23);
            TB_NameUser.TabIndex = 12;
            // 
            // Lbl_NameUser
            // 
            Lbl_NameUser.AutoSize = true;
            Lbl_NameUser.Location = new Point(155, 50);
            Lbl_NameUser.Name = "Lbl_NameUser";
            Lbl_NameUser.Size = new Size(109, 15);
            Lbl_NameUser.TabIndex = 13;
            Lbl_NameUser.Text = "Nombre de usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 9);
            label7.Name = "label7";
            label7.Size = new Size(212, 25);
            label7.TabIndex = 14;
            label7.Text = "Formulario de Usuario";
            // 
            // Fmr_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = Properties.Resources.Sin_título_12;
            ClientSize = new Size(366, 279);
            Controls.Add(label7);
            Controls.Add(Lbl_NameUser);
            Controls.Add(TB_NameUser);
            Controls.Add(Lbl_NewPass);
            Controls.Add(Lbl_Pass);
            Controls.Add(Lbl_ApellidoCompleto);
            Controls.Add(Lbl_NameCompleto);
            Controls.Add(Lbl_NUser);
            Controls.Add(TB_ConfirmNewPass);
            Controls.Add(Tb_NewPass);
            Controls.Add(Tb_Apellido);
            Controls.Add(TB_Name);
            Controls.Add(Tb_NUser);
            Controls.Add(Btn_Cancel);
            Controls.Add(btn_Confirm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Fmr_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABM_Usuario";
            Load += Fmr_Usuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Confirm;
        private Button Btn_Cancel;
        private TextBox Tb_NUser;
        private TextBox TB_Name;
        private TextBox Tb_Apellido;
        private TextBox Tb_NewPass;
        private TextBox TB_ConfirmNewPass;
        private Label Lbl_NUser;
        private Label Lbl_NameCompleto;
        private Label Lbl_ApellidoCompleto;
        private Label Lbl_Pass;
        private Label Lbl_NewPass;
        private TextBox TB_NameUser;
        private Label Lbl_NameUser;
        private Label label7;
    }
}