using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE;


namespace CD
{
    public class AbmProductora : ConexionBD
    {
        public List<Productoras> ObtenerProductoras()
        {
            List<Productoras> lista = new List<Productoras>();
            string orden = "SELECT id_productora, nomb_productora FROM Productora";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Productoras pro = new Productoras();
                    pro.Id_productora = Convert.ToInt32(dr["id_productora"]);
                    pro.Nomb_productora = dr["nomb_productora"].ToString();
                    lista.Add(pro);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Productoras", e);
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
