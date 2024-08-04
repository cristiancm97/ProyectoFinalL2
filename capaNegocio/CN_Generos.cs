using capaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class CN_Generos
    {
        private CD_Generos objetoCD = new CD_Generos();

        public DataTable MostrarGeneros()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarGen(string Nombre, string Descripcion)
        {
            objetoCD.Insertar(Nombre, Descripcion);
        }
        public void EditarGen(string Nombre, string Descripcion, int Id)
        {
            objetoCD.Editar(Nombre, Descripcion, Convert.ToInt32(Id));
        }
        public void EliminarGen(string Id)
        {

            objetoCD.Eliminar(Convert.ToInt32(Id));
        }
    }
}
