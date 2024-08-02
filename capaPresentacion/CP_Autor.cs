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
    public partial class CP_Autor : Form
    {
        public CP_Autor()
        {
            InitializeComponent();
        }

        private void pbCerrarAutor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizarAutor_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuAutor_Click(object sender, EventArgs e)
        {
            menuAdmin formMenu = new menuAdmin();
            formMenu.Show();
            this.Close();
        }

        private void btnLogoutAutor_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            MessageBox.Show("Sesion Cerrada");
            formLogin.Show();
            this.Close();
        }
    }
}
