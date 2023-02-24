using CD;
using CE;
using System.Collections.Generic;


namespace CN
{
    public class NegPeliculas
    {
        ABMDatos objDatosPeliculas = new ABMDatos();
        public List<Peliculas> ListarPeliculas()
        {
            return objDatosPeliculas.ObtenerPeliculas();
        }
    }

}
