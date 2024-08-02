using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace capaPresentacion
{
    public partial class CP_Empleado : Form
    {
        CN_Empleados objetoCN = new CN_Empleados();

        public CP_Empleado()
        {
            InitializeComponent();
        }

        private void CP_Empleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
        }

        private void MostrarEmpleados()
        {
            // Asegúrate de que "dataGridView1" es el nombre correcto del control en tu formulario
            CN_Empleados objeto = new CN_Empleados();
            dgvEmp.DataSource = objeto.MostrarEmpleados();
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
    }
}
