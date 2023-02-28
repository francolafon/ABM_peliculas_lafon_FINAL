using CE;
using CN;
namespace CP
{
    public partial class FormModificar : Form
    {
        Peliculas peliculas;
        FormMain formMain;
        NegPeliculas negPeliculas = new NegPeliculas();
        NegProductora negProductora = new NegProductora();
        NegDirector negDirector = new NegDirector();
        NegCategoria negCategoria = new NegCategoria();

        public FormModificar(FormMain Alta)
        {
            InitializeComponent();
            formMain = Alta;
            //formMain = new FormMain();
            //llenado de cbx
            LlenarCbxProductoras();
            LlenarCbxDirectores();
            LlenarCbxCategorias();
            MostrarDatos();
        }

        private void MostrarDatos()
        {
            peliculas = new Peliculas();
            txt_titulo_pel_mod.Text = peliculas.Titulo;
            txt_desc_mod.Text = peliculas.Desc_pel;
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {

        }

        private void txt_desc_mod_TextChanged(object sender, EventArgs e)
        {

        }
        void LlenarCbxProductoras()
        {
            cb_prod_mod.DataSource = negProductora.ObtenerProductoras();
            cb_prod_mod.ValueMember = "id_productora";
            cb_prod_mod.DisplayMember = "nomb_productora";

        }

        void LlenarCbxDirectores()
        {
            cb_dir_mod.DataSource = negDirector.ObtenerDirectores();
            cb_dir_mod.ValueMember = "id_director";
            cb_dir_mod.DisplayMember = "nomb_director";
        }
        void LlenarCbxCategorias()
        {
            cb_cat_mod.DataSource = negCategoria.ObtenerCategorias();
            cb_cat_mod.ValueMember = "id_categoria";
            cb_cat_mod.DisplayMember = "nomb_categoria";
        }
    }
}
