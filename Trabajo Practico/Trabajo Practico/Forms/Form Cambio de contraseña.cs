using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Trabajo_Practico;
namespace Trabajo_Practico
{
    public partial class Cambio_de_contraseña : Form
    {
        //se llama a la lista de usuarios
        private List<UsuarioUser> listaUsers;

        //Esta al inicializar el formulario, mostrar los datos del usuario ingresado
        public Cambio_de_contraseña(List<UsuarioUser> usuarios)
        {
            InitializeComponent();
            listaUsers = usuarios;
        }
        
        private void Cambio_de_contraseña_Load(object sender, EventArgs e)
        {
            
        }

        private UsuarioUser usuarioEncontrado = null;

        //Verificacion al colocar el N° de usuario y que este envie el codigo de cambio de contraseña
        private void BTN_Verificacion_Click(object sender, EventArgs e)
        {
            string n_user = TB_NUser.Text.Trim();

            usuarioEncontrado = listaUsers.FirstOrDefault(u => u.n_usuario == n_user);
            //Si el usuario existe y no es Nulo mostrara los demas elemento del formulario
            if (usuarioEncontrado != null)
            {
                MessageBox.Show("El nummero de usuario es correcto,el código de verificación ha sido enviado con éxito al mail");
                lbl_CodConfimation.Visible = true;
                tb_CodConfimation.Visible = true;
                Btn_ConfirmCode.Visible = true;
            }
            else
            {
                MessageBox.Show("El número de usuario no existe o es erróneo");
            }
        }

        //boton confirmar de cambio de contraseña
        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            string newpass = Tb_NewPass.Text.Trim();
            string confirmpass = Tb_ConfirmPass.Text.Trim();

            //verificacion de que los campos no sean vacios o no tenga espacios
            if (string.IsNullOrEmpty(newpass) || string.IsNullOrEmpty(confirmpass))
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }
            //Verificacion de contraseña no sea diferente
            if (newpass != confirmpass)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }
            //verificacion de que el usuario no sea nulo y que la contraseña se cambie con exito
            if (usuarioEncontrado != null)
            {
                usuarioEncontrado.Clave = newpass;
                MessageBox.Show("La contraseña fue cambiada con éxito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar al usuario.");
            }

            
        }
        //El boton de confirmacion de codigo enviado
        private void Btn_ConfirmCode_Click(object sender, EventArgs e)
        {
            //verificacion del codigo y si es correcto muestre los elementos faltantes
            if (tb_CodConfimation.Text == "1234")
            {
                MessageBox.Show("El codigo es Correcto, siga con el cambio de contraseña");
                Lbl_NewPass.Visible = true;
                Tb_NewPass.Visible = true;
                Lbl_PassCofirm.Visible = true;
                Tb_ConfirmPass.Visible = true;
                Btn_Confirmar.Visible = true;
            }
            else
            {
                MessageBox.Show("El código introducido es erróneo");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
