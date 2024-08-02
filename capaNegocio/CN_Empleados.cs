using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using capaDatos;

namespace capaNegocio
{
     public class CN_Empleados
    {   
        private CD_Empleados objetoCD = new CD_Empleados();

        public DataTable MostrarEmpleados() { 
            
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        
        }
    }
}
