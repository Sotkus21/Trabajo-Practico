using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.Versioning;
using Trabajo_Practico;
namespace Trabajo_Practico
{
    public partial class Login : Form
    {
        Administrativo Administrativo = new Administrativo();


        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        //llamado de la clase Usuario
        public UsuarioUser UsuarioLogueado { get; set; }

        //creacion del metodo lista donde esta la lista de usuarios admins y comunes
        public void lista()
        {

        }
        //lista usuario
        private List<UsuarioUser> listaUsers = new List<UsuarioUser>
        {
            new UsuarioUser {n_usuario= "0000100", Usuario = "SuarezA", Clave = "1234", Nombre = "Agustin", Apellido = "Suarez" },
        };
        //lista administrativa
        private List<UsuarioUser> listaAdmins = new List<UsuarioUser>
        {
            new UsuarioUser {n_usuario= "0000001" ,Usuario = "admin1", Clave = "1234", Nombre = "Agustin", Apellido = "Suarez" },
            new UsuarioUser {n_usuario= "0000002", Usuario = "admin2", Clave = "abcd", Nombre = "María", Apellido = "Lobrano"}
        };
        //Metodo de verifiacion de usuarios, si es admin o normal
        public void Users()
        {
            string userIngresado = Tb_User.Text.Trim();
            string claveIngresada = Tb_Pass.Text.Trim();

            var admin = listaAdmins.FirstOrDefault(a => a.Usuario == userIngresado && a.Clave == claveIngresada);
            var user = listaUsers.FirstOrDefault(u => u.Usuario == userIngresado && u.Clave == claveIngresada);

            if (admin != null)
            {
                // Si es admin
                Administrativo formAdmin = new Administrativo(listaUsers, listaAdmins);
                formAdmin.ShowDialog();
                Tb_Pass.Text = "";
                Tb_User.Text = "";
            }
            else if (user != null)
            {
                // Si es usuario común
                Fmr_Usuario formUsuario = new Fmr_Usuario();
                formUsuario.UsuarioLogueado = user;
                formUsuario.ShowDialog();
                Tb_Pass.Text = "";
                Tb_User.Text = "";
            }
            else
            {
                MessageBox.Show("Los datos colocados son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }




        //el btn inicio llama directamente al metodo Users
        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            Users();
        }

        
        //al hacer click en el LBL de cambio de contraseña que muestre el formulario
        private void LBL_Cambio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Al llamar al formulario se da como parametro enviar la lista de los usuarios.
            Cambio_de_contraseña cambio = new Cambio_de_contraseña(listaUsers);
            cambio.ShowDialog();
            LBL_Cambio.LinkVisited = true;

        }

        
    }
}
