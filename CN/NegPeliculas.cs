using CE;
using CD;
using System.Data;
namespace CN
{
    public class NegPeliculas
    {
        ABMDatos DatosObjPeliculas = new ABMDatos();

        //public int ABM_Peliculas(string accion, Peliculas objPelicula)
        //{
        //    return DatosObjPeliculas.listaPeliculas(accion, objPelicula); //aqui esta el problema
        //}
        public DataSet lista_de_peliculas(string cual)
        {
            return DatosObjPeliculas.listaPeliculas(cual);
        }
    }
}

