using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaDatos;
using System.Collections;

namespace capaNegocio
{
     public class CN_Usuarios
    {   
        private CD_Usuarios objetoCD = new CD_Usuarios();

        public DataTable MostrarUsuarios() { 
            
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarUsu(string Nombre,string Apellido,string Celular, string Email,string Usuario,string Contrasena,string Rol)
        {
            objetoCD.Insertar(Nombre,Apellido,Celular,Email,Usuario,Contrasena,Rol);
        }
        public void EditarUsu(string Nombre, string Apellido, string Celular, string Email, string Usuario, string Contrasena, string Rol,int Id)
        {
            objetoCD.Editar(Nombre, Apellido, Celular, Email, Usuario, Contrasena, Rol,Convert.ToInt32(Id));
        }
        public void EliminarUsu(string Id)
        {

            objetoCD.Eliminar(Convert.ToInt32(Id));
        }

        public bool ValidUser (string Usuario, string Contrasena)
        {
            return objetoCD.LoginUser (Usuario, Contrasena);
        }
    }
}
