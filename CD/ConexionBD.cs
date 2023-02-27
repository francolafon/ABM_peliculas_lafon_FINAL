using System;
using System.Data;
using System.Data.OleDb;

namespace CD
{
    public class ConexionBD
    {
        protected OleDbConnection conexion;
        public OleDbDataReader reader;
        protected string cadenaCon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Franco\\source\\repos\\francolafon\\ABM_peliculas_lafon_FINAL\\CDAT\\BDpelis.accdb";

        public ConexionBD()
        {
            conexion = new OleDbConnection(cadenaCon);
        }
        public void AbrirConexion()//Abre conexión.
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error\n\n", e);
            }
        }
        public void CerrarConexion()//Cierra conexión.
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error\n\n", e);
            }
        }
    }
}