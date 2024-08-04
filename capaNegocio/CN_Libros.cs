using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CN_Libros
    {
        private CD_Libros objetoCD = new CD_Libros();

        public DataTable MostrarLibros()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable ObtenerAutores()
        {
            return objetoCD.ObtenerAutores();
        }

        public DataTable ObtenerGeneros()
        {
            return objetoCD.ObtenerGeneros();
        }

        public void InsertarLib(string Titulo, int Autor, int AñoPublicacion, int Genero)
        {
            objetoCD.Insertar(Titulo,Autor,AñoPublicacion,Genero);
        }
        public void EditarLib(string Titulo, int Autor, int AñoPublicacion, int Genero, int Id)
        {
            objetoCD.Editar(Titulo, Convert.ToInt32(Autor), Convert.ToInt32(AñoPublicacion),Convert.ToInt32(Genero), Convert.ToInt32(Id));
        }
        public void EliminarLib(int Id)
        {

            objetoCD.Eliminar(Id);
        }

        
    }
}
