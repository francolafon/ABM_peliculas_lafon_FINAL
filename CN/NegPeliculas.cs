using CE;
using CD;
using System.Data;
namespace CN
{
    public class NegPeliculas
    {
        ABMDatos DatosObjPeliculas = new ABMDatos();

        //ALTA BAJA MODIFICAR
        public int ABM_Pelicula(string accion, Peliculas ObjPelicula)
        { 
            return DatosObjPeliculas.ABM_Pelicula(accion, ObjPelicula);
        }
      
        //LISTADO DE DATOS
        public DataSet lista_de_peliculas(string cual)
        {
            return DatosObjPeliculas.listaPeliculas(cual);
        }
    }
}

