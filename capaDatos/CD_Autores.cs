using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_Autores
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAutores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string Nombre, string Bibliografia)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAutores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Bibliografia", Bibliografia);
            
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(string Nombre, string Bibliografia,int Id)
        {


            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarAutores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Bibliografia", Bibliografia);
            comando.Parameters.AddWithValue("@Id", Id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void Eliminar(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAutores";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdAut", Id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
