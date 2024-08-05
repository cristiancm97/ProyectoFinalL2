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

namespace capaPresentacion
{
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
            CargarUser();
            CargarTitulo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            CP_Empleado formEmpleado = new CP_Empleado();
            formEmpleado.Show();
            this.Hide();
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            CP_Libro formLibro = new CP_Libro();
            formLibro.Show();
            this.Hide();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            CP_Genero formGenero = new CP_Genero();
            formGenero.Show();
            this.Hide();
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            CP_Autor formAutor = new CP_Autor();
            formAutor.Show();
            this.Hide();
        }

        private void btnLogoutMenu_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            MessageBox.Show("Sesion Cerrada");
            formLogin.Show();
            this.Close();
        }

        private void CargarUser()
        {
            lblNombreU.Text = ValidUser.Nombre;
            lblApellidoU.Text = ValidUser.Apellido;
            lblUsuarioU.Text = ValidUser.Usuario;
            lblEmailU.Text = ValidUser.Email;
        }

        private void CargarTitulo()
        {
            lblTitulo.Parent = pbFondo;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Text = "Bienvenido " + ValidUser.Nombre + ", ¿que desea gestionar?";
        }
    }
}
