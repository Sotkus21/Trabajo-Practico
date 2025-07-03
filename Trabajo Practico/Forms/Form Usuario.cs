using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Practico;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Trabajo_Practico
{
    public partial class Fmr_Usuario : Form
    {
        public Fmr_Usuario()
        {
            InitializeComponent();
        }
        //llamado de la lista Users y crear una llamado UseriaoLogueado
        public UsuarioUser UsuarioLogueado { get; set; }

        private void Fmr_Usuario_Load(object sender, EventArgs e)
        {
            //Cuando cargue el formulario, este tiene que rellenar los datos del usuario en cuestion
            if (UsuarioLogueado != null)
            {
                Tb_Apellido.Text = UsuarioLogueado.Apellido;
                TB_Name.Text = UsuarioLogueado.Nombre;
                TB_NameUser.Text = UsuarioLogueado.Usuario;
                Tb_NUser.Text = UsuarioLogueado.n_usuario;
            }

        }
        //Boton de confirmacion de nueva clave
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //cambio de contraseña pidiendo los datos de los textboxes
            string nuevaClave = Tb_NewPass.Text.Trim();
            string confirmarClave = TB_ConfirmNewPass.Text.Trim();

            //Validacion si los datos no son nulos o vacios 
            if (string.IsNullOrEmpty(nuevaClave) || string.IsNullOrEmpty(confirmarClave))
            {
                MessageBox.Show("Por favor, completá ambos campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Validacion si la contraseña es distinta
            if (nuevaClave != confirmarClave)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioLogueado.Clave = nuevaClave;
            MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos de la contraseña luego de confirmarla
            Tb_NewPass.Clear();
            TB_ConfirmNewPass.Clear();
        }

        
        //boton para cerrar el formulario si lo requiere
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
