using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BlockBuster.Peliclas.Data
{
    public class datCatalogos
    {
        public SqlConnection con;

        public datCatalogos()
        {
            con = new SqlConnection("Data Source =TORO-PC\\MSSQLSERVER2012; initial catalog=Cinepolis; user Id=sa; Password=12345;");
        }

        public DataTable ObtenerGenero()
        {
            SqlCommand com = new SqlCommand("spObtenerGenero", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ObtenerClasificacion()
        {
            SqlCommand com = new SqlCommand("spObtenerClasificacion", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable obtenerUsuario(int Id)
        {
            SqlCommand com = new SqlCommand("spObtenerUsuario", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = Id });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       
    }
}
