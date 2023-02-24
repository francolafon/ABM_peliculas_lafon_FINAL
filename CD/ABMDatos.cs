using CE;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace CD
{
    public class ABMDatos
    {
        public List<Peliculas> ObtenerPeliculas()
        {
            var conn = new OleDbConnection();
            var comando = new OleDbCommand();
            var base_de_datos = new ConexionBD();
            List<Peliculas> lista = new List<Peliculas>();

            string orden = "Select Id_pel, titulo From Peliculas";
            OleDbCommand cmd = new OleDbCommand(orden, conn);
            OleDbDataReader dr;
            try
            {
                conn = base_de_datos.Abrir();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Peliculas P = new Peliculas();// instancio P como un objeto Pelicula
                    P.Id_pel = dr.GetInt32(0);
                    P.Titulo = dr.GetString(4);
                    lista.Add(P);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Rubros", e);
            }
            finally
            {
                conn = base_de_datos.Cerrar();
                cmd.Dispose();
            }
            return lista;
        }
    }
}

