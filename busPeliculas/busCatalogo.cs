using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BlockBuster.Peliculas.Business.Entity;
using BlockBuster.Peliclas.Data;

namespace BlockBuster.Peliculas.Business
{
    public class busCatalogo
    {
        public List<entGenero> ObtenerGenero()
        {
            DataTable dt = new datCatalogos().ObtenerGenero();
            List<entGenero> lst = new List<entGenero>();
            foreach (DataRow dr in dt.Rows)
            {
                entGenero ent = new entGenero();
                ent.id = Convert.ToInt32(dr["GEN_ID"]);
                ent.Nombre = dr["GEN_NOMB"].ToString();
                ent.Descripcion = dr["GEN_DESC"].ToString();
                lst.Add(ent);

            }
            return lst;
        }

        public List<entClasificacion> ObtenerClasificacion()
        {
            DataTable dt = new datCatalogos().ObtenerClasificacion();
            List<entClasificacion> lst = new List<entClasificacion>();
            foreach (DataRow dr in dt.Rows)
            {
                entClasificacion ent = new entClasificacion();
                ent.id = Convert.ToInt32(dr["CLAS_ID"]);
                ent.Nombre = dr["CLAS_NOMB"].ToString();
                ent.Descripcion = dr["CLAS_DESC"].ToString();
                lst.Add(ent);

            }
            return lst;
        }
    }
}
