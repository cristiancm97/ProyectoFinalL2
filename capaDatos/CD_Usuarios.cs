using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using capaComun;

namespace capaDatos
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();  
            return tabla;

        }

        public void Insertar(string Nombre,string Apellido, string Celular, string Email,string Usuario,string Contrasena,string Rol)
        {
           
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Celular", Celular);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);
            comando.Parameters.AddWithValue("@Rol", Rol);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(string Nombre, string Apellido, string Celular, string Email, string Usuario, string Contrasena, string Rol,int Id)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Celular", Celular);
            comando.Parameters.AddWithValue("@Email", Email);
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);
            comando.Parameters.AddWithValue("@Rol", Rol);
            comando.Parameters.AddWithValue("@Id", Id);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void Eliminar(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdUsu", Id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public bool LoginUser(string Usuario, string Contrasena)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * from Usuarios where Usuario=@Usuario and Contrasena=@Contrasena";
            comando.Parameters.AddWithValue("@Usuario", Usuario);
            comando.Parameters.AddWithValue("@Contrasena", Contrasena);
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    ValidUser.IdUser = leer.GetInt32(0);
                    ValidUser.Nombre = leer.GetString(1);
                    ValidUser.Apellido = leer.GetString(2);
                    ValidUser.Email = leer.GetString(4);
                    ValidUser.Usuario = leer.GetString(5);
                    ValidUser.Rol = leer.GetString(7);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
