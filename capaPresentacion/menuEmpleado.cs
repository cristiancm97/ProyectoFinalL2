using capaComun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class menuEmpleado : Form
    {
        public menuEmpleado()
        {
            InitializeComponent();
            CargarUser();
            CargarTitulo();
        }

        private void pbCerrarE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizarE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLibroE_Click(object sender, EventArgs e)
        {
            CP_Libro formLibro = new CP_Libro();
            formLibro.Show();
            this.Hide();
        }

        private void btnGeneroE_Click(object sender, EventArgs e)
        {
            CP_Genero formGenero = new CP_Genero();
            formGenero.Show();
            this.Hide();
        }

        private void btnAutorE_Click(object sender, EventArgs e)
        {
            CP_Autor formAutor = new CP_Autor();
            formAutor.Show();
            this.Hide();
        }

        private void btnLogoutMenuE_Click(object sender, EventArgs e)
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
            lblTituloE.Parent = pbFondoE;
            lblTituloE.BackColor = Color.Transparent;
            lblTituloE.Text = "Bienvenido, " + ValidUser.Nombre + ", ¿Qué desea gestionar?";
        }
    }
}
