using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaComun;
using capaNegocio;

namespace capaPresentacion
{
    public partial class CP_Empleado : Form
    {
        CN_Usuarios objetoCN = new CN_Usuarios();
        private string idUsuarios = null;
        private bool Editar = false;

        public CP_Empleado()
        {
            InitializeComponent();
            CargarUser();
        }

        private void CP_Empleado_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void MostrarUsuarios()
        {
            CN_Usuarios objeto = new CN_Usuarios();
            dgvEmp.DataSource = objeto.MostrarUsuarios();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuEmp_Click(object sender, EventArgs e)
        {
            menuAdmin formMenu = new menuAdmin();
            formMenu.Show();
            this.Close();
        }

        private void btnLogoutEmp_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            MessageBox.Show("Sesión Cerrada");
            formLogin.Show();
            this.Close();
        }

        private void btnFormDatosEmp_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    string rol = "empleado";
                    objetoCN.InsertarUsu(txtNombre.Text, txtApellido.Text, txtCelular.Text, txtEmail.Text, txtUsuario.Text, txtContra.Text, rol);
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarUsuarios();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se puede Insertar los datos por : " + ex);
                }
            }
            else // EDITAR
            {
                try
                {
                    string rol = "empleado";
                    int id = int.Parse(idUsuarios); // Convertir idUsuarios a int
                    objetoCN.EditarUsu(txtNombre.Text, txtApellido.Text, txtCelular.Text, txtEmail.Text, txtUsuario.Text, txtContra.Text, rol, id);
                    MessageBox.Show("Se editó correctamente");
                    MostrarUsuarios();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditarEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmp.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dgvEmp.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvEmp.CurrentRow.Cells["Apellido"].Value.ToString();
                txtCelular.Text = dgvEmp.CurrentRow.Cells["Celular"].Value.ToString();
                txtEmail.Text = dgvEmp.CurrentRow.Cells["Email"].Value.ToString();
                txtUsuario.Text = dgvEmp.CurrentRow.Cells["Usuario"].Value.ToString();
                txtContra.Text = dgvEmp.CurrentRow.Cells["Contrasena"].Value.ToString();
                idUsuarios = dgvEmp.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void limpiarForm()
        {
            txtApellido.Clear();
            txtCelular.Text = "";
            txtEmail.Clear();
            txtUsuario.Clear();
            txtContra.Clear();
            txtNombre.Clear();
        }
      

        private void btnEliminarEmp_Click(object sender, EventArgs e)
        {
            if (dgvEmp.SelectedRows.Count > 0)
            {
                idUsuarios = dgvEmp.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarUsu(idUsuarios);
                MessageBox.Show("Eliminado correctamente");
                MostrarUsuarios();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void CargarUser()
        {
            lblNombreU.Text = ValidUser.Nombre;
            lblApellidoU.Text = ValidUser.Apellido;
            lblUsuarioU.Text = ValidUser.Usuario;
            lblEmailU.Text = ValidUser.Email;
        }
    }
}
