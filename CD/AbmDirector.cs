using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE;


namespace CD
{
    public class AbmDirector : ConexionBD
    {
        public List<Directores> ObtenerDirectores()
        {
            List<Directores> lista = new List<Directores>();
            string orden = "SELECT id_director, nomb_director FROM Director";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Directores dir = new Directores();
                    dir.Id_director = Convert.ToInt32(dr["id_director"]);
                    dir.Nomb_director = dr["nomb_director"].ToString();
                    lista.Add(dir);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Directores", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return lista;
        }
    }
}
