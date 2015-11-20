using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BlockBuster.Peliclas.Data
{
    public class datPelicula
    {
        public SqlConnection con;

        public datPelicula()
        {
            con = new SqlConnection("Data Source=SOPORTETECNICO\\MSSQLSERVER2012; Initial Catalog=Cinepolis; User Id=sa; Password=12345;");
        }

        public DataTable ObtenerEstrenos()
        {
            SqlCommand com = new SqlCommand("spObtenerEstrenos", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Obtener(int Id)
        {
            SqlCommand com = new SqlCommand("spObtenerPelicula", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = Id });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Obtener()
        {
            SqlCommand com = new SqlCommand("spObtenerPeliculaid", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ObtenerGenero(int Id)
        {
            SqlCommand com = new SqlCommand("spObtenerGeneroid", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = Id });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ObtenerClasificacion(int Id)
        {
            SqlCommand com = new SqlCommand("spObtenerClasificacionid", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = Id });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Obtener(string Nombre,int Clasificacionid,int GeneroId,DateTime FechaLanz )
        {
            SqlCommand com = new SqlCommand("spObtenerPeliculas", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar , ParameterName = "@Nombre", Value = Nombre });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int , ParameterName = "@ClasificacionId", Value = Clasificacionid });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int , ParameterName = "@GeneroId", Value = GeneroId });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime , ParameterName = "@AnioLanz", Value = FechaLanz });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
