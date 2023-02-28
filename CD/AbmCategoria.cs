using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CE;


namespace CD
{
    public class AbmCategoria : ConexionBD
    {
        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> lista = new List<Categorias>();
            string orden = "SELECT id_categoria, nomb_categoria FROM Categoria";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            OleDbDataReader dr;
            try
            {
                AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Categorias cat = new Categorias();
                    cat.Id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    cat.Nomb_categoria = dr["nomb_categoria"].ToString();
                    lista.Add(cat);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Categorias", e);
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
