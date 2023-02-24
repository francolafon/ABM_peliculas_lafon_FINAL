namespace CE
{
    public class Categorias
    {
        private int id_categoria;
        private int id_ubicacion;
        private int nomb_categoria;

        public int Id_categoria
        {
            get { return id_categoria; }
            set { id_categoria = value; }
        }
        public int Id_ubicacion
        {
            get { return id_ubicacion; }
            set { id_ubicacion = value; }
        }

        public int Nomb_categoria
        {
            get { return nomb_categoria; }
            set { nomb_categoria = value; }
        }
    }
}
