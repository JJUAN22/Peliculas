﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlockBuster.Peliculas.Business.Entity;
using System.Data;
using BlockBuster.Peliclas.Data;

namespace BlockBuster.Peliculas.Business
{
    public class busPelicula
    {
        public List<entPelicula> Obtener()
        {
            DataTable dt = new datPelicula().Obtener();
            List<entPelicula> lst = new List<entPelicula>();
            lst = ob(dt);
            return lst;
        }

        public List<entPelicula> Obtener(int id)
        {
            DataTable dt = new datPelicula().Obtener(id);
            List<entPelicula> lst = new List<entPelicula>();
            lst = ob(dt);
            return lst;
        }

        public List<entPelicula> ObtenerClasificacion(int idClas)
        {
            DataTable dt = new datPelicula().ObtenerClasificacion(idClas);
            List<entPelicula> lst = new List<entPelicula>();
            lst = ob(dt);
            return lst;
        }

        public List<entPelicula> ObtenerGenero(int idGen)
        {
            DataTable dt = new datPelicula().ObtenerGenero(idGen);
            List<entPelicula> lst = new List<entPelicula>();
            lst = ob(dt);
            return lst;
        }

        public List<entPelicula> ObtenerEstrenos()
        {
            DataTable dt = new datPelicula().ObtenerEstrenos();
            List<entPelicula> lst = new List<entPelicula>();
            lst = ob(dt);
            return lst;
        }

        public List<entPelicula> ObtenerUltimas()
        {
            DataTable dt = new datPelicula().ObtenerUltimas();
            List<entPelicula> lst = new List<entPelicula>();
            lst = ob(dt);
            return lst;
        }

        private List<entPelicula> ob(DataTable dt)
        {
            List<entPelicula> lst = new List<entPelicula>();
            foreach (DataRow dr in dt.Rows)
            {
                entPelicula ent = new entPelicula();
                ent.Id = Convert.ToInt32(dr["PELI_ID"]);
                ent.Nombre = dr["PELI_NOMB"].ToString();
                ent.AnioLanzamiento = Convert.ToDateTime(dr["PELI_ANIO_LANZ"]);
                ent.Estatus = Convert.ToBoolean(dr["PELI_ESTA"]);
                ent.Sinopsis = dr["PELI_SINO"].ToString();
                ent.Trailer = dr["PELI_TRAI"].ToString();
                ent.FotoPortada = dr["PELI_FOTO_PORT"].ToString();
                ent.FotoMini = dr["PELI_FOTO_MINI"].ToString();
                ent.Clasificacion.Nombre = dr["CLAS_NOMB"].ToString();
                ent.Genero.Nombre = dr["GEN_NOMB"].ToString();
                ent.Clasificacion.id = Convert.ToInt32(dr["PELI_CLAS_ID"]);
                ent.Genero.id = Convert.ToInt32(dr["PELI_GENE_ID"]);
                lst.Add(ent);
            }

            return lst;
        }

        public void Actualizar(entPelicula ent)
        {
            int filas = new datPelicula().Actualizar(ent.Nombre, ent.AnioLanzamiento, ent.Clasificacion.id, ent.Genero.id, ent.Estatus, ent.Sinopsis, ent.Trailer, ent.FotoPortada, ent.FotoMini, ent.Id);
            if (filas != 1)
            {
                throw new ApplicationException("Error al Actualizar ");
            }
        }

        public void Guardar(entPelicula ent)
        {

            int filas = new datPelicula().Insertar(ent.Nombre, ent.AnioLanzamiento, ent.Clasificacion.id, ent.Genero.id, ent.FehaAlta, ent.Estatus, ent.Sinopsis, ent.Trailer, ent.FotoPortada, ent.FotoMini);
            if (filas != 1)
            {
                throw new ApplicationException("Error al Actualizar ");
            }
        }

        public void Eliminar(int id)
        {
            int filas = new datPelicula().Eliminar(id);

            if (filas != 1)

                throw new ApplicationException("Error al Actualizar ");
        }
    }
}
