using CN;
using CE;

namespace CP
{
    public partial class FormAlta : Form
    {
        Peliculas peliculas;
        FormMain formMain;
        NegPeliculas negPeliculas = new NegPeliculas();
        NegProductora negProductora = new NegProductora();
        NegDirector negDirector = new NegDirector();
        NegCategoria negCategoria = new NegCategoria();

        public FormAlta(FormMain Alta)
        {
            InitializeComponent();
            formMain = Alta;
            //formMain = new FormMain();
            //llenado de cbx
            LlenarCbxProductoras();
            LlenarCbxDirectores();
            LlenarCbxCategorias();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {

        }

        private void btn_alta_dir_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAltaDirector();
            formulario.Show();
        }

        private void btn_alta_prod_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAltaProductora();
            formulario.Show();
        }

        private void btn_cancel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtp_pel_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha_pel = dtp_pel.Value;
            string fecha_pel_anio = fecha_pel.ToString("yyyy");
            int fecha_pel_anio_2 = Int32.Parse(fecha_pel_anio);
        }

        private void btn_alta_pel_Click(object sender, EventArgs e)
        {
            if (txt_titulo_pel.Text != "" && cb_dir.Text != "" && cb_prod.Text != "" && cb_cat.Text != "" && txt_desc.Text != "")//faltan agregar campos
            {
                int nGrabados = -1;

                //manipulacion de calendario para mandar por parametro
                DateTime fecha_pel = dtp_pel.Value;
                string fecha_pel_anio = fecha_pel.ToString("yyyy");
                int fecha_pel_anio_2 = Int32.Parse(fecha_pel_anio);

                //peliculas = new Peliculas(Convert.ToInt32(cb_dir.SelectedValue), Convert.ToInt32(cb_prod.SelectedValue), Convert.ToInt32(cb_cat.SelectedValue), txt_titulo_pel.Text, txt_desc.Text, Convert.ToInt32(txt_cant.Text), fecha_pel_anio_2);
                peliculas = new Peliculas(Convert.ToInt32(cb_dir.SelectedValue), Convert.ToInt32(cb_prod.SelectedValue), Convert.ToInt32(cb_cat.SelectedValue), txt_titulo_pel.Text, txt_desc.Text, Convert.ToInt32(nud_cant.Value), fecha_pel_anio_2);
                nGrabados = negPeliculas.ABM_Pelicula("INSERT", peliculas);

                if (nGrabados == -1)
                {
                    MessageBox.Show("No se pudo grabar el en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    formMain.Cargar_dgv_peliculas();
                    MessageBox.Show("El  fue agregado correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("ERROR NO ENTRA", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btn_cancel1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_alta_dir_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FormAltaDirector();
            formulario.Show();
        }

        private void btn_alta_prod_Click_1(object sender, EventArgs e)
        {
            Form formulario = new FormAltaProductora();
            formulario.Show();
        }

        //Combo box

        void LlenarCbxProductoras()
        {
            cb_prod.DataSource = negProductora.ObtenerProductoras();
            cb_prod.ValueMember = "id_productora";
            cb_prod.DisplayMember = "nomb_productora";

        }
        
        void LlenarCbxDirectores() 
            {
                cb_dir.DataSource = negDirector.ObtenerDirectores();
                cb_dir.ValueMember = "id_director";
                cb_dir.DisplayMember = "nomb_director";
            }
            void LlenarCbxCategorias()
            {
            cb_cat.DataSource = negCategoria.ObtenerCategorias();
            cb_cat.ValueMember = "id_categoria";
            cb_cat.DisplayMember = "nomb_categoria";
        }

        private void nud_cant_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
