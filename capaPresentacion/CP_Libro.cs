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
    public partial class CP_Libro : Form
    {
        CN_Libros objetoCN = new CN_Libros();
        private string idLibros = null;
        private bool Editar = false;

        public CP_Libro()
        {

            InitializeComponent();
            CargarComboBoxAutores();
            CargarComboBoxGeneros();
            CargarUser();
            MostrarLibros();
        }
        private void CargarComboBoxAutores()
        {
            CN_Libros objeto = new CN_Libros();
            cbAutorLibro.DataSource = objeto.ObtenerAutores();
            cbAutorLibro.DisplayMember = "Nombre"; // Cambia "Nombre" por el nombre de la columna de autores en tu base de datos
            cbAutorLibro.ValueMember = "Id"; // Cambia "Id" por el nombre del campo ID de autores en tu base de datos
        }

        private void CargarComboBoxGeneros()
        {
            CN_Libros objeto = new CN_Libros();
            cbGeneroLibro.DataSource = objeto.ObtenerGeneros();
            cbGeneroLibro.DisplayMember = "Nombre"; // Cambia "Nombre" por el nombre de la columna de géneros en tu base de datos
            cbGeneroLibro.ValueMember = "Id"; // Cambia "Id" por el nombre del campo ID de géneros en tu base de datos
        }
        private void CP_Libro_Load(object sender, EventArgs e)
        {
            MostrarLibros();            
        }

        private void MostrarLibros()
        {
            CN_Libros objeto = new CN_Libros();
            dgvLibro.DataSource = objeto.MostrarLibros();
        }

        private void pbCerrarLibro_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinimizarLibro_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuLibro_Click(object sender, EventArgs e)
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

        private void btnLogoutLibro_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            MessageBox.Show("Sesión Cerrada");
            formLogin.Show();
            this.Close();
        }

        

        private void btnFormDatosLibro_Click(object sender, EventArgs e)
        {
            if(txtTituloLibro.Text != "" && txtAnioLibro.Text != "")
            {
                if (Editar == false)
                {
                    try
                    {
                        // Obtener el ID del autor seleccionado en el ComboBox
                        int autorId = (int)cbAutorLibro.SelectedValue;

                        // Obtener el ID del género seleccionado en el ComboBox
                        int generoId = (int)cbGeneroLibro.SelectedValue;

                        // Convertir el año a entero
                        int anioPublicacion = int.Parse(txtAnioLibro.Text);

                        objetoCN.InsertarLib(txtTituloLibro.Text, autorId, anioPublicacion, generoId);
                        MessageBox.Show("Se insertó correctamente");
                        MostrarLibros();
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puede insertar los datos por: " + ex);
                    }
                }
                else // EDITAR
                {
                    try
                    {
                        int id = int.Parse(idLibros); // Convertir idLibros a int
                        int autorId = (int)cbAutorLibro.SelectedValue;
                        int generoId = (int)cbGeneroLibro.SelectedValue;
                        int anioPublicacion = int.Parse(txtAnioLibro.Text);

                        objetoCN.EditarLib(txtTituloLibro.Text, autorId, anioPublicacion, generoId, id);
                        MessageBox.Show("Se editó correctamente");
                        MostrarLibros();
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

        // Método para limpiar el formulario después de insertar/editar
        private void limpiarForm()
        {
            txtTituloLibro.Clear();
            cbAutorLibro.SelectedIndex = -1; // Resetear el ComboBox
            txtAnioLibro.Clear();
            cbGeneroLibro.SelectedIndex = -1; // Resetear el ComboBox
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count > 0)
            {
                Editar = true;
                txtTituloLibro.Text = dgvLibro.CurrentRow.Cells["Titulo"].Value.ToString();
                cbAutorLibro.SelectedValue = dgvLibro.CurrentRow.Cells["Autor"].Value;
                cbGeneroLibro.SelectedValue = dgvLibro.CurrentRow.Cells["Genero"].Value;
                txtAnioLibro.Text = dgvLibro.CurrentRow.Cells["AñoPublicacion"].Value.ToString();
                idLibros = dgvLibro.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibro.SelectedRows.Count > 0)
            {
                idLibros = dgvLibro.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarLib(int.Parse(idLibros));
                MessageBox.Show("Eliminado correctamente");
                MostrarLibros();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void CargarUser()
        {
            lblNombreU.Text = ValidUser.Nombre;
            lblApellidoU.Text = ValidUser.Apellido;
            lblUsuarioU.Text = ValidUser.Usuario;
            lblEmailU.Text = ValidUser.Email;
        }

        private void lblEmailU_Click(object sender, EventArgs e)
        {

        }
        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
