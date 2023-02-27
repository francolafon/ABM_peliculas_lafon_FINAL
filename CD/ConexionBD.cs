using System;
using System.Data;
using System.Data.OleDb;

namespace CD
{
    public class ConexionBD
    {
        protected OleDbConnection conexion;
        public OleDbDataReader reader;
        protected string cadenaCon = @"Provider=Microsoft.Jet.OLEDB.4.0;;Data Source=C:\DataBases\PersFinal.mdb";

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