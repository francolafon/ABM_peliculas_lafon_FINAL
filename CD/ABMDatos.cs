using System;
using System.Data;
using System.Data.OleDb;


namespace CD
{
    public class ABMDatos : ConexionBD
    {
        public DataSet listaPeliculas(string cual)
        {
            string orden = string.Empty;

            if (cual != "Cargar")
                // orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Peliculas.id_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas WHERE id_pel = " + int.Parse(cual) + ";";
                //orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Peliculas.id_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas WHERE id_pel = " + int.Parse(cual) + ";";
                orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Categoria.nomb_categoria, Director.nomb_director, Productora.nomb_productora, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Productora INNER JOIN(Director INNER JOIN(Categoria INNER JOIN Peliculas ON Categoria.id_categoria = Peliculas.id_categoria) ON Director.id_director = Peliculas.id_director) ON Productora.id_productora = Peliculas.id_productora WHERE id_pel = " + int.Parse(cual) + ";";
            else
                //orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Peliculas.id_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas;";
                //orden = "SELECT Peliculas.id_pel, Peliculas.titulo, Peliculas.id_categoria, Director.nomb_director, Peliculas.id_productora,  Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas INNER JOIN Director ON Peliculas.id_director =Director.id_director;";
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
                throw new Exception("Error al listar Profesores", e);
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

