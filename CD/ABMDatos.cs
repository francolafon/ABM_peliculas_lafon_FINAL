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
                orden = "SELECT Peliculas.id_pel, Peliculas.id_director, Peliculas.id_categoria, Peliculas.id_productora, Peliculas.titulo, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas WHERE id_pel = " + int.Parse(cual) + ";";
            else
                orden = "SELECT Peliculas.id_pel, Peliculas.id_director, Peliculas.id_categoria, Peliculas.id_productora, Peliculas.titulo, Peliculas.desc_pel, Peliculas.cant_pel, Peliculas.anio_pel FROM Peliculas;";

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

