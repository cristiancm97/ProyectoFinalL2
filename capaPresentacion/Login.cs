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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            menuAdmin formMenuAdmin = new menuAdmin();
            formMenuAdmin.Show();
            this.Hide();
        }

        private void pbCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
