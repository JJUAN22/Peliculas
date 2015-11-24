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

        public DataTable ObtenerUltimas()
        {
            SqlCommand com = new SqlCommand("spObtenerUltimas", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public int Actualizar(string nombre, DateTime fechaLanz, int clasificacion, int genero, bool estatus, string sinopsis, string trailer, string fotoPortada, string fotoMini, int id)
        {
            SqlCommand com = new SqlCommand("spObtenerActualizarPeli", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Nombre", Value = nombre });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@FechaLanz", Value = fechaLanz });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@ClasId", Value = clasificacion });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@GeneId", Value = genero });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, ParameterName = "@Estatus", Value = estatus });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Sinopsis", Value = sinopsis });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Trailer", Value = trailer });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoPortada", Value = fotoPortada });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoMini", Value = fotoMini });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@id" });

            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }

        }

        public int Insertar(string nombre, DateTime fechaLanz, int clasificacion, int genero, DateTime fechaAlta, bool estatus, string sinopsis, string trailer, string fotoPortada, string fotoMini)
        {
            SqlCommand com = new SqlCommand("spObtenerActualizarPeli", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Nombre", Value = nombre });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@FechaLanz", Value = fechaLanz });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@ClasId", Value = clasificacion });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@GeneId", Value = genero });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.DateTime, ParameterName = "@FechaAlta", Value = fechaAlta });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, ParameterName = "@Estatus", Value = estatus });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Sinopsis", Value = sinopsis });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Trailer", Value = trailer });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoPortada", Value = fotoPortada });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoMini", Value = fotoMini });

            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }
        }

        public int Eliminar(int Id)
        {
            SqlCommand com = new SqlCommand("spObtenerActualizarPeli", con);
            com.CommandType = CommandType.StoredProcedure;

            try
            {
                con.Open();
                int filas = com.ExecuteNonQuery();
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }


        }
    }
}
