namespace Trabajo_Practico
{
    partial class Administrativo
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
            TB_Name = new TextBox();
            TB_NameUser = new TextBox();
            Tb_Pass = new TextBox();
            Tb_Nuser = new TextBox();
            Btn_Eliminar = new Button();
            Id_User = new Label();
            Lbl_NameCompleto = new Label();
            Lbl_NomeUser = new Label();
            Lbl_Pass = new Label();
            label5 = new Label();
            Btn_Guardar = new Button();
            Btn_Agregar = new Button();
            TP1 = new TabControl();
            tp_User = new TabPage();
            DGV_Usuarios = new DataGridView();
            Tp_Admin = new TabPage();
            DGV_Admins = new DataGridView();
            Lbl_Apellido = new Label();
            Tb_Apellido = new TextBox();
            TP1.SuspendLayout();
            tp_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Usuarios).BeginInit();
            Tp_Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Admins).BeginInit();
            SuspendLayout();
            // 
            // TB_Name
            // 
            TB_Name.Location = new Point(391, 82);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(100, 23);
            TB_Name.TabIndex = 20;
            // 
            // TB_NameUser
            // 
            TB_NameUser.Location = new Point(391, 164);
            TB_NameUser.Name = "TB_NameUser";
            TB_NameUser.Size = new Size(100, 23);
            TB_NameUser.TabIndex = 40;
            // 
            // Tb_Pass
            // 
            Tb_Pass.Location = new Point(391, 205);
            Tb_Pass.Name = "Tb_Pass";
            Tb_Pass.PasswordChar = '*';
            Tb_Pass.Size = new Size(100, 23);
            Tb_Pass.TabIndex = 50;
            // 
            // Tb_Nuser
            // 
            Tb_Nuser.Location = new Point(391, 43);
            Tb_Nuser.Name = "Tb_Nuser";
            Tb_Nuser.Size = new Size(100, 23);
            Tb_Nuser.TabIndex = 10;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.Red;
            Btn_Eliminar.ForeColor = Color.Black;
            Btn_Eliminar.Location = new Point(448, 230);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(75, 23);
            Btn_Eliminar.TabIndex = 70;
            Btn_Eliminar.Text = "Eliminar";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // Id_User
            // 
            Id_User.AutoSize = true;
            Id_User.Location = new Point(394, 23);
            Id_User.Name = "Id_User";
            Id_User.Size = new Size(78, 15);
            Id_User.TabIndex = 8;
            Id_User.Text = "Id del usuario";
            // 
            // Lbl_NameCompleto
            // 
            Lbl_NameCompleto.AutoSize = true;
            Lbl_NameCompleto.Location = new Point(391, 68);
            Lbl_NameCompleto.Name = "Lbl_NameCompleto";
            Lbl_NameCompleto.Size = new Size(51, 15);
            Lbl_NameCompleto.TabIndex = 9;
            Lbl_NameCompleto.Text = "Nombre";
            // 
            // Lbl_NomeUser
            // 
            Lbl_NomeUser.AutoSize = true;
            Lbl_NomeUser.Location = new Point(391, 151);
            Lbl_NomeUser.Name = "Lbl_NomeUser";
            Lbl_NomeUser.Size = new Size(109, 15);
            Lbl_NomeUser.TabIndex = 10;
            Lbl_NomeUser.Text = "Nombre de usuario";
            // 
            // Lbl_Pass
            // 
            Lbl_Pass.AutoSize = true;
            Lbl_Pass.Location = new Point(391, 190);
            Lbl_Pass.Name = "Lbl_Pass";
            Lbl_Pass.Size = new Size(67, 15);
            Lbl_Pass.TabIndex = 11;
            Lbl_Pass.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(211, 28);
            label5.TabIndex = 12;
            label5.Text = "Panel Administrativo";
            // 
            // Btn_Guardar
            // 
            Btn_Guardar.Location = new Point(367, 230);
            Btn_Guardar.Name = "Btn_Guardar";
            Btn_Guardar.Size = new Size(75, 23);
            Btn_Guardar.TabIndex = 60;
            Btn_Guardar.Text = "Guardar";
            Btn_Guardar.UseVisualStyleBackColor = true;
            Btn_Guardar.Click += Btn_Guardar_Click;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.Location = new Point(407, 257);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(75, 23);
            Btn_Agregar.TabIndex = 80;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = true;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // TP1
            // 
            TP1.Controls.Add(tp_User);
            TP1.Controls.Add(Tp_Admin);
            TP1.Location = new Point(22, 72);
            TP1.Name = "TP1";
            TP1.SelectedIndex = 0;
            TP1.Size = new Size(322, 197);
            TP1.TabIndex = 14;
            TP1.Tag = "";
            // 
            // tp_User
            // 
            tp_User.Controls.Add(DGV_Usuarios);
            tp_User.Location = new Point(4, 24);
            tp_User.Name = "tp_User";
            tp_User.Padding = new Padding(3);
            tp_User.Size = new Size(314, 169);
            tp_User.TabIndex = 0;
            tp_User.Text = "Usuarios";
            tp_User.UseVisualStyleBackColor = true;
            // 
            // DGV_Usuarios
            // 
            DGV_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Usuarios.Location = new Point(6, 0);
            DGV_Usuarios.Name = "DGV_Usuarios";
            DGV_Usuarios.ReadOnly = true;
            DGV_Usuarios.Size = new Size(305, 166);
            DGV_Usuarios.TabIndex = 0;
            DGV_Usuarios.CellContentClick += DGV_Usuarios_CellContentClick;
            // 
            // Tp_Admin
            // 
            Tp_Admin.Controls.Add(DGV_Admins);
            Tp_Admin.Location = new Point(4, 24);
            Tp_Admin.Name = "Tp_Admin";
            Tp_Admin.Padding = new Padding(3);
            Tp_Admin.Size = new Size(314, 169);
            Tp_Admin.TabIndex = 1;
            Tp_Admin.Text = "Administrativos";
            Tp_Admin.UseVisualStyleBackColor = true;
            // 
            // DGV_Admins
            // 
            DGV_Admins.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Admins.Location = new Point(6, 3);
            DGV_Admins.Name = "DGV_Admins";
            DGV_Admins.Size = new Size(302, 160);
            DGV_Admins.TabIndex = 0;
            // 
            // Lbl_Apellido
            // 
            Lbl_Apellido.AutoSize = true;
            Lbl_Apellido.Location = new Point(393, 108);
            Lbl_Apellido.Name = "Lbl_Apellido";
            Lbl_Apellido.Size = new Size(51, 15);
            Lbl_Apellido.TabIndex = 16;
            Lbl_Apellido.Text = "Apellido";
            // 
            // Tb_Apellido
            // 
            Tb_Apellido.Location = new Point(393, 122);
            Tb_Apellido.Name = "Tb_Apellido";
            Tb_Apellido.Size = new Size(100, 23);
            Tb_Apellido.TabIndex = 30;
            // 
            // Administrativo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(549, 292);
            Controls.Add(Lbl_Apellido);
            Controls.Add(Tb_Apellido);
            Controls.Add(TP1);
            Controls.Add(Btn_Agregar);
            Controls.Add(label5);
            Controls.Add(Lbl_Pass);
            Controls.Add(Lbl_NomeUser);
            Controls.Add(Lbl_NameCompleto);
            Controls.Add(Id_User);
            Controls.Add(Btn_Eliminar);
            Controls.Add(Btn_Guardar);
            Controls.Add(Tb_Nuser);
            Controls.Add(Tb_Pass);
            Controls.Add(TB_NameUser);
            Controls.Add(TB_Name);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Administrativo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrativo";
            Load += Administrativo_Load;
            TP1.ResumeLayout(false);
            tp_User.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Usuarios).EndInit();
            Tp_Admin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Admins).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TB_Name;
        private TextBox TB_NameUser;
        private TextBox Tb_Pass;
        private TextBox Tb_Nuser;
        private Button Btn_Eliminar;
        private Label Id_User;
        private Label Lbl_NameCompleto;
        private Label Lbl_NomeUser;
        private Label Lbl_Pass;
        private Label label5;
        private Button Btn_Guardar;
        private Button Btn_Agregar;
        private TabControl TP1;
        private TabPage tp_User;
        private DataGridView DGV_Usuarios;
        private TabPage Tp_Admin;
        private DataGridView DGV_Admins;
        private Label Lbl_Apellido;
        private TextBox Tb_Apellido;
    }
}