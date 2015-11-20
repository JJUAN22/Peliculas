using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockBuster.Peliculas.Business.Entity
{
    public class entPelicula
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public DateTime AnioLanzamiento { get; set; }

        public DateTime FehaAlta { get; set; }

        public bool Estatus { get; set; }

        public string Sinopsis { get; set; }

        public string Trailer { get; set; }

        public string FotoMini { get; set; }

        public string FotoPortada { get; set; }

        private entGenero genero;

        public entGenero Genero
        {
            get 
            {
                if (genero == null)
                    genero = new entGenero();
                return genero; 
            }
            set 
            {
                if (genero == null)
                    genero = new entGenero();                  
                genero = value; 
            }  
        }

        private entClasificacion clasificacion;

        public entClasificacion Clasificacion
        {
            get 
            {
                if (clasificacion == null)
                    clasificacion = new entClasificacion();
                    return clasificacion; 
            }
            set
            {
                if (clasificacion == null)
                    clasificacion = new entClasificacion();
                    clasificacion =value;
            }   
        }
    }
}
