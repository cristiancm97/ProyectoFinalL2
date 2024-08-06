using capaComun;
using capaNegocio;
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
    public partial class CP_Genero : Form
    {
        CN_Generos objetoCN = new CN_Generos();
        private string idGeneros = null;
        private bool Editar = false;
        public CP_Genero()
        {
            InitializeComponent();
            CargarUser();
            MostrarGeneros();
        }

        private void CP_Genero_Load(object sender, EventArgs e)
        {
            MostrarGeneros();
        }
        private void MostrarGeneros()
        {
            CN_Generos objeto = new CN_Generos();
            dgvGenero.DataSource = objeto.MostrarGeneros();
        }
        private void pbCerrarGenero_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizarGenero_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuGenero_Click(object sender, EventArgs e)
        {
            if (ValidUser.Rol == "Admin")
            {
                menuAdmin formMenu = new menuAdmin();
                formMenu.Show();
                this.Close();
            }
            else if (ValidUser.Rol == "Empleado")
            {
                menuEmpleado formMenuE = new menuEmpleado();
                formMenuE.Show();
                this.Close();
            }
        }

        private void btnLogoutGenero_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            MessageBox.Show("Sesion Cerrada");
            formLogin.Show();
            this.Close();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFormDatosGenero_Click(object sender, EventArgs e)
        {
            if(txtNombreGenero.Text != "" && txtDescripcionGenero.Text != "") 
            {
                if (Editar == false)
                {
                    try
                    {

                        objetoCN.InsertarGen(txtNombreGenero.Text, txtDescripcionGenero.Text);
                        MessageBox.Show("Se inserto Correctamente");
                        MostrarGeneros();
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

                        int id = int.Parse(idGeneros); // Convertir idUsuarios a int
                        objetoCN.EditarGen(txtNombreGenero.Text, txtDescripcionGenero.Text, id);
                        MessageBox.Show("Se editó correctamente");
                        MostrarGeneros();
                        limpiarForm();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por: " + ex);
                    }
                }
            } 
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private void btnEditarGenero_Click(object sender, EventArgs e)
        {
            if (dgvGenero.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombreGenero.Text = dgvGenero.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcionGenero.Text = dgvGenero.CurrentRow.Cells["Descripcion"].Value.ToString();
                idGeneros = dgvGenero.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void limpiarForm()
        {
            txtNombreGenero.Clear();
            txtDescripcionGenero.Clear();

        }

        private void btnEliminarGenero_Click(object sender, EventArgs e)
        {
            if (dgvGenero.SelectedRows.Count > 0)
            {
                idGeneros = dgvGenero.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarGen(idGeneros);
                MessageBox.Show("Eliminado correctamente");
                MostrarGeneros();
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
