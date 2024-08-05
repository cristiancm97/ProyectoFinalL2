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
    public partial class CP_Autor : Form
    {
        CN_Autores objetoCN = new CN_Autores();
        private string idAutores = null;
        private bool Editar = false;
        public CP_Autor()
        {
            InitializeComponent();
        }
        private void CP_Autor_Load(object sender, EventArgs e)
        {
            MostrarAutores();
        }
        private void MostrarAutores()
        {
            CN_Autores objeto = new CN_Autores();
            dgvAutor.DataSource = objeto.MostrarAutores();
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
            if (ValidUser.Rol == "Admin")
            {
                menuAdmin formMenu = new menuAdmin();
                formMenu.Show();
                this.Close();
            } else if (ValidUser.Rol == "Empleado")
            {
                menuEmpleado formMenuE = new menuEmpleado();
                formMenuE.Show();
                this.Close();
            }            
        }

        private void btnLogoutAutor_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            MessageBox.Show("Sesion Cerrada");
            formLogin.Show();
            this.Close();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFormDatosAutor_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                   
                    objetoCN.InsertarAut(txtNombreAutor.Text, txtBibliografiaAutor.Text );
                    MessageBox.Show("Se inserto Correctamente");
                    MostrarAutores();
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
                    
                    int id = int.Parse(idAutores); // Convertir idUsuarios a int
                    objetoCN.EditarAut(txtNombreAutor.Text, txtBibliografiaAutor.Text, id);
                    MessageBox.Show("Se editó correctamente");
                    MostrarAutores();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            if (dgvAutor.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombreAutor.Text = dgvAutor.CurrentRow.Cells["Nombre"].Value.ToString();
                txtBibliografiaAutor.Text = dgvAutor.CurrentRow.Cells["Bibliografia"].Value.ToString();
                idAutores = dgvAutor.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void limpiarForm()
        {
            txtNombreAutor.Clear();
            txtBibliografiaAutor.Clear();
            
        }

        private void btnEliminarAutor_Click(object sender, EventArgs e)
        {
            if (dgvAutor.SelectedRows.Count > 0)
            {
                idAutores = dgvAutor.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarAut(idAutores);
                MessageBox.Show("Eliminado correctamente");
                MostrarAutores();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
    }

