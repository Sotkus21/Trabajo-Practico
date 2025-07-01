using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico
{
    public partial class Administrativo : Form
    {
        //llamado de la lista usuario administrativo y normales
        private List<UsuarioUser> listaUsuariosNormales;
        private List<UsuarioUser> listaUsuariosAdmins;
        public Administrativo()
        {
            InitializeComponent();
        }
        
        public Administrativo(List<UsuarioUser> usuariosNormales, List<UsuarioUser> usuariosAdmins)
        {
            InitializeComponent();

            // solicita directamente la lista de usuarios normalaes y administrativos
            this.listaUsuariosNormales = usuariosNormales;
            this.listaUsuariosAdmins = usuariosAdmins;
            //muestra directamente los datos en los DataGrid correspondientes
            DGV_Usuarios.DataSource = listaUsuariosNormales;
            DGV_Admins.DataSource = listaUsuariosAdmins;
        }
        private void Administrativo_Load(object sender, EventArgs e)
        {
            //al cargar los formularios y usar el cell click muestre los datos en los textboxes
            DGV_Usuarios.CellClick += DGV_Usuarios_CellClick;
            DGV_Admins.CellClick += DGV_Admins_CellClick;
            DGV_Usuarios.AutoGenerateColumns = true;
            DGV_Admins.AutoGenerateColumns = true;
        }
       
        //carga los datos de cada columna y fila los DataGrids
        private void DGV_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //carga los datos de cada columna y fila los DataGrids
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Usuarios.Rows[e.RowIndex];


                Tb_Nuser.Text = row.Cells["n_usuario"].Value.ToString();
                TB_Name.Text = row.Cells["Nombre"].Value.ToString();
                Tb_Apellido.Text = row.Cells["Apellido"].Value.ToString();
                TB_NameUser.Text = row.Cells["Usuario"].Value.ToString();
                Tb_Pass.Text = row.Cells["Clave"].Value.ToString();
            }
        }
        private void DGV_Admins_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //carga los datos de cada columna y fila los DataGrids
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DGV_Admins.Rows[e.RowIndex];


                Tb_Nuser.Text = row.Cells["n_usuario"].Value.ToString();
                TB_Name.Text = row.Cells["Nombre"].Value.ToString();
                Tb_Apellido.Text = row.Cells["Apellido"].Value.ToString();
                TB_NameUser.Text = row.Cells["Usuario"].Value.ToString();
                Tb_Pass.Text = row.Cells["Clave"].Value.ToString();
            }
        }
        private void DGV_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //al guardar los datos que modifique de los textboxes correspondientes
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            string id = Tb_Nuser.Text;
            bool usuarioModificado = false;

            // Determina que TabPage está activa
            if (TP1.SelectedTab == tp_User)
            {
                // Intentar actualizar el usuario normal
                var usuario = listaUsuariosNormales.FirstOrDefault(u => u.n_usuario == id);
                if (usuario != null)
                {
                    usuario.Nombre = TB_Name.Text;
                    usuario.Apellido = Tb_Apellido.Text;
                    usuario.Usuario = TB_NameUser.Text;
                    usuario.Clave = Tb_Pass.Text;

                    // Refrescar el DataGridView
                    DGV_Usuarios.DataSource = null;
                    DGV_Usuarios.DataSource = listaUsuariosNormales;
                    MessageBox.Show("Datos del usuario normal actualizados correctamente.");
                    usuarioModificado = true; // Marca que se realizó una modificación

                    Tb_Nuser.Text = "";
                    Tb_Apellido.Text = "";
                    TB_Name.Text = "";
                    TB_NameUser.Text = "";
                    Tb_Pass.Text = "";
                }
            }
            else if (TP1.SelectedTab == Tp_Admin)
            {
                // Intentar actualizar el usuario administrador
                var admin = listaUsuariosAdmins.FirstOrDefault(u => u.n_usuario == id);
                if (admin != null)
                {
                    admin.Nombre = TB_Name.Text;
                    admin.Apellido = Tb_Apellido.Text;
                    admin.Usuario = TB_NameUser.Text;
                    admin.Clave = Tb_Pass.Text;

                    // Refrescar el DataGridView
                    DGV_Usuarios.DataSource = null;
                    DGV_Usuarios.DataSource = listaUsuariosAdmins;
                    MessageBox.Show("Datos del usuario administrador actualizados correctamente.");
                    usuarioModificado = true; // Marca que se realizó una modificación

                    Tb_Nuser.Text = "";
                    Tb_Apellido.Text = "";
                    TB_Name.Text = "";
                    TB_NameUser.Text = "";
                    Tb_Pass.Text = "";
                }
            }

            // Verificacion al intentar modificar un usuario inexistente
            if (!usuarioModificado)
            {
                MessageBox.Show("No se encontró el usuario a modificar en la lista seleccionada.");
            }
        }
        //boton para eliminar un usuario de la lista en tiempo de ejecuccion
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Busca el usuario por su N° de usuario
            string id = Tb_Nuser.Text.Trim();

            // Verificación de que se seleccionó un usuario
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Primero seleccioná un usuario para eliminar.");
                return;
            }

            // Confirmación de eliminación
            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este usuario?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
            {
                return; // Si elige "No", se cancela la operación
            }

            // Verificación de eliminación de usuario normal
            if (TP1.SelectedTab == tp_User)
            {
                var usuario = listaUsuariosNormales.FirstOrDefault(u => u.n_usuario == id);
                if (usuario != null)
                {
                    listaUsuariosNormales.Remove(usuario);
                    DGV_Usuarios.DataSource = null;
                    DGV_Usuarios.DataSource = listaUsuariosNormales;
                    MessageBox.Show("Usuario normal eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario en la lista.");
                }
            }
            // Verificación de eliminación de administrador
            else if (TP1.SelectedTab == Tp_Admin)
            {
                var admin = listaUsuariosAdmins.FirstOrDefault(a => a.n_usuario == id);
                if (admin != null)
                {
                    listaUsuariosAdmins.Remove(admin);
                    DGV_Admins.DataSource = null;
                    DGV_Admins.DataSource = listaUsuariosAdmins;
                    MessageBox.Show("Administrador eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró el administrador en la lista.");
                }
            }

            // Limpiar los campos
            Tb_Nuser.Text = "";
            TB_Name.Text = "";
            Tb_Apellido.Text = "";
            TB_NameUser.Text = "";
            Tb_Pass.Text = "";
        }
        //boton agregar un usuario a la lista en tiempo de ejecucion
        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            string id = Tb_Nuser.Text.Trim();
            string nombre = TB_Name.Text.Trim();
            string apellido = Tb_Apellido.Text.Trim();
            string usuario = TB_NameUser.Text.Trim();
            string clave = Tb_Pass.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }
            
            if (TP1.SelectedTab == tp_User)
            {
                //En caso de que el usuario exista ya con ese numero de usuario
                if (listaUsuariosNormales.Any(u => u.n_usuario == id))
                {
                    MessageBox.Show("Ya existe un usuario con ese número.");
                    return;
                }
                //creacion del usuario normal
                listaUsuariosNormales.Add(new UsuarioUser
                {
                    n_usuario = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Usuario = usuario,
                    Clave = clave
                });
                //actualizacion de la lista al cargar un usuario
                DGV_Usuarios.DataSource = null;
                DGV_Usuarios.DataSource = listaUsuariosNormales;

                MessageBox.Show("Usuario normal agregado correctamente.");
            }
            else if (TP1.SelectedTab == Tp_Admin)
            {
                //En caso de que el usuario exista ya con ese numero de usuario
                if (listaUsuariosAdmins.Any(a => a.n_usuario == id))
                {
                    MessageBox.Show("Ya existe un administrador con ese número.");
                    return;
                }
                //creacion del usuario en la lista admin
                listaUsuariosAdmins.Add(new UsuarioUser
                {
                    n_usuario = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Usuario = usuario,
                    Clave = clave
                });
                //actualizacion de la lista al cargar un usuario
                DGV_Admins.DataSource = null;
                DGV_Admins.DataSource = listaUsuariosAdmins;

                MessageBox.Show("Administrador agregado correctamente.");
            }

            // Limpiar los campos
            Tb_Nuser.Text = "";
            TB_Name.Text = "";
            Tb_Apellido.Text = "";
            TB_NameUser.Text = "";
            Tb_Pass.Text = "";
        }
    }
}
