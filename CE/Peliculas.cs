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

        public Peliculas(int idDir, int idCat, int idProd, string tit, string desc, int cant, int anio)
        { 
            id_director = idDir;
            id_productora = idProd;
            id_categoria = idCat;
            titulo = tit;
            desc_pel = desc;
            cant_pel = cant;
            anio_pel = anio;

        }
        public Peliculas()
        {
            id_director = 0;
            id_categoria = 0;
            id_director = 0;
            id_productora = 0;
            titulo = "";
            desc_pel = "";
            cant_pel = 0;
            anio_pel = 0;
        }

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
