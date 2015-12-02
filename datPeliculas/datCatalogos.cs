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
            con = new SqlConnection("Data Source =EVE; initial catalog=Cinepolis; user Id=sa; Password=12345;");
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

        public DataTable ObtenerUsuario(string Correo,string Password)
        {
            SqlCommand com = new SqlCommand("spObtenerUsuario", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Correo", Value = Correo });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Password", Value = Password });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
