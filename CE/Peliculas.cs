using System;

namespace CE
{
    public class Peliculas
    {
        private int id_pel;
        private int id_director;
        private int id_categoria;
        private int id_productora;
        private string titulo;
        private string desc_pel;
        private int cant_pel;
        private int anio_pel;

        public int ABM_Peliculas(string v, string accion, Peliculas objPeliculas)
        {
            throw new NotImplementedException();
        }

        public int Id_pel
        {
            get { return id_pel; }
            set { id_pel = value; }
        }

        public int Id_director
        {
            get { return id_director; }
            set { id_director = value; }
        }

        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }

        public int Id_productora
        {
            get { return id_productora; }
            set { id_director = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Desc_pel
        {
            get { return desc_pel; }
            set { desc_pel = value; }
        }
        public int Cant_pel
        {
            get { return cant_pel; }
            set { cant_pel = value; }
        }
        public int Anio_pel
        {
            get { return anio_pel; }
            set { anio_pel = value; }
        }
        #region "Metodos"
    }
}
#endregion
