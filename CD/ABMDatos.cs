using System;
using System.Data;
using System.Data.OleDb;
using CE;


namespace CD
{
    public class ABMDatos : ConexionBD
    {
        //CARGA DE LISTADO
        public DataSet listaPeliculas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Cargar")
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.id_categoria, Director.id_director, Productora.id_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora WHERE id_pel = " + int.Parse(cual) + ";";
            
            else
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.nomb_categoria, Director.nomb_director, Productora.nomb_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora;";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Peliculas", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }

        //ALTA BAJA Y MODIFICAR
        public int ABM_Pelicula(string accion, Peliculas ObjPelicula)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "INSERT")

                orden = "INSERT INTO Peliculas (id_director,id_categoria,id_productora,titulo,desc_pel,cant_pel,anio_pel) VALUES(" + ObjPelicula.Id_director + ", " + ObjPelicula.Id_categoria + ", " + ObjPelicula.Id_productora + ", '" + ObjPelicula.Titulo + "', '" + ObjPelicula.Desc_pel + "'," + ObjPelicula.Cant_pel + "," + ObjPelicula.Anio_pel + "); ";

            if (accion == "DELETE")
                orden = "DELETE FROM Peliculas WHERE(id_pel = " + ObjPelicula.Id_pel + ")";
            

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de Agregar, Borrar o Modificar una pelicula", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        //BUSCAR Peliculas
        public DataSet BuscarPeliculas(string cual, string dato)
        {
            string orden = string.Empty;

            if (cual != "Buscar")
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.id_categoria, Director.id_director, Productora.id_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora WHERE Peliculas.id_pel LIKE " + int.Parse(dato) + ";";
                


            else
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.id_categoria, Director.id_director, Productora.id_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora WHERE Peliculas.id_pel LIKE ('%" + dato + "%');";

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar las Pelicula", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}

