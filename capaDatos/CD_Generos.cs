using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class CD_Generos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarGeneros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Insertar(string Nombre, string Descripcion)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarGeneros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Editar(string Nombre, string Descripcion, int Id)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarGeneros";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Id", Id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void Eliminar(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarGeneros";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@IdGen", Id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
