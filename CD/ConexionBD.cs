using System.Data.OleDb;

namespace CD
{
    internal class ConexionBD
    {
        private readonly string _connString;
        public ConexionBD()
        {
            //Cadena de conexion para Access 2019
            _connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\Franco\\source\\repos\\CP\\CD\\BDpelis.accdb";
        }

        public OleDbConnection Abrir()
        {
            var conn = new OleDbConnection(_connString);
            conn.Open();
            return conn;

        }
        public OleDbConnection Cerrar()
        {
            var conn = new OleDbConnection(_connString);
            conn.Close();
            return conn;
        }

    }
}
