using CN;
using CE;

namespace CP
{
    public partial class FormAlta : Form
    {
        Peliculas peliculas;
        //NegPeliculas negPeliculas;
        FormMain formMain;
        NegPeliculas negPeliculas = new NegPeliculas();
        NegProductora negProductora = new NegProductora();

        public FormAlta()
        {
            InitializeComponent();
            LlenarCbxProductoras();
            //CombBoxs
            //cb_dir.Items.Add(1);
            //cb_prod.Items.Add(1);
            //cb_cat.Items.Add(1);
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

        private void btn_alta_pel_Click(object sender, EventArgs e)
        {
            if (txt_titulo_pel.Text != "" && cb_dir.Text != "" && cb_prod.Text != "" && cb_cat.Text != "" && txt_desc.Text != "")//faltan agregar campos
            {
                int nGrabados = -1;

                peliculas = new Peliculas(Convert.ToInt32(cb_dir.SelectedItem), Convert.ToInt32(cb_prod.SelectedItem), Convert.ToInt32(cb_cat.SelectedItem), txt_titulo_pel.Text, txt_desc.Text, Convert.ToInt32(txt_cant.Text), Convert.ToInt32(cal_pel_3.Text));
                //prueba de carga
                //peliculas = new Peliculas(1,1,1,"prueba 5", "prueba 5 desc",3,2025);
                nGrabados = negPeliculas.ABM_Pelicula("INSERT", peliculas);

                if (nGrabados == -1)
                {
                    MessageBox.Show("No se pudo grabar el Alumno en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //formMain.Cargar_dgv_peliculas();
                    MessageBox.Show("El alumno fue agregado correctamente.", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            cb_prod.DisplayMember = "id_productora";
            cb_prod.DisplayMember = "nomb_productora";
        }


    }
}
