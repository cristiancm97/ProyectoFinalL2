using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
        public class CD_Libros
        {
            private CD_Conexion conexion = new CD_Conexion();
            SqlDataReader leer;
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand();

        public DataTable ObtenerAutores()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerAutores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ObtenerGeneros()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ObtenerGeneros";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Mostrar()
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "MostrarLibros"; 
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
                return tabla;
            }

            public void Insertar(string Titulo, int Autor, int AñoPublicacion, int Genero)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarLibros"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Titulo", Titulo);
                comando.Parameters.AddWithValue("@Autor", Autor);
                comando.Parameters.AddWithValue("@AñoPublicacion", AñoPublicacion);
                comando.Parameters.AddWithValue("@Genero", Genero);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

           
            public void Editar(string Titulo, int Autor, int AñoPublicacion, int Genero, int Id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EditarLibros";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Titulo", Titulo);
                comando.Parameters.AddWithValue("@Autor", Autor);
                comando.Parameters.AddWithValue("@AñoPublicacion", AñoPublicacion);
                comando.Parameters.AddWithValue("@Genero", Genero);
                comando.Parameters.AddWithValue("@Id", Id);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }

            public void Eliminar(int Id)
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarLibros"; 
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@IdLib", Id);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
    
}
