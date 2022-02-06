using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    
    public class Conexion
    {
        public SqlConnection coneccion = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = bdAdmision; Integrated Security = true ");
        //private SqlConnection coneccion = new SqlConnection("Data Source = DESKTOP-9QP4SEF; Initial Catalog = bdAdmision; Integrated Security = true ");

        public SqlConnection getConection()
        {
            return coneccion;
        }
    }
}
