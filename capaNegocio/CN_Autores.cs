using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CN_Autores
    {
        private CD_Autores objetoCD = new CD_Autores();

        public DataTable MostrarAutores()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarAut(string Nombre, string Bibliografia)
        {
            objetoCD.Insertar(Nombre, Bibliografia);
        }
        public void EditarAut(string Nombre, string Bibliografia, int Id)
        {
            objetoCD.Editar(Nombre, Bibliografia, Convert.ToInt32(Id));
        }
        public void EliminarAut(string Id)
        {

            objetoCD.Eliminar(Convert.ToInt32(Id));
        }
    }
}
