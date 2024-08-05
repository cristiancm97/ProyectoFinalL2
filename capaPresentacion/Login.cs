using capaNegocio;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            if ( tbUsuario.Text != "")
            {
                if (tbPassword.Text != "")
                {
                    CN_Usuarios objetoCN = new CN_Usuarios();
                    var validacion = objetoCN.ValidUser (tbUsuario.Text, tbPassword.Text);
                    if (validacion == true)
                    {
                        if (ValidUser.Rol == "Admin")
                        {
                            menuAdmin formMenuAdmin = new menuAdmin();
                            formMenuAdmin.Show();
                            this.Hide();
                        } 
                        else
                        {
                            if(ValidUser.Rol == "Empleado")
                            {
                                MessageBox.Show("Bienvenido Esclavo");
                            }
                            else
                            {
                                MessageBox.Show("Rol desconocido, por favor contacte con soporte");
                            }

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrectos");
                        tbPassword.Clear();
                        tbUsuario.Clear();
                        tbUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Complete el campo Contraseña");
                }
            }       
            else
            {
                MessageBox.Show("Complete el campo Usuario");
            }               
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
