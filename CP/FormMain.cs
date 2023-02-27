using CN;
using System.Data;

namespace CP
{
    public partial class FormMain : Form
    {
        NegPeliculas ObjPeliculas = new NegPeliculas();

        public FormMain()
        {
            InitializeComponent();
            Crear_dgv_peliculas();
            Cargar_dgv_peliculas();
        }

        private void BtnAlta_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAlta();
            formulario.Show();
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormModificar();
            formulario.Show();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void Labeltitulo1_Click(object sender, EventArgs e)
        {

        }

        private void Lblbuscar_Click(object sender, EventArgs e)
        {

        }

        private void Labeltitulo1_Click_1(object sender, EventArgs e)
        {

        }

        #region DGV_Peliculas
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Crear_dgv_peliculas()
        {
            dgv_peliculas.Columns.Add("0", "ID");
            dgv_peliculas.Columns.Add("4", "TITULO");
            dgv_peliculas.Columns.Add("2", "CATEGORIA");
            dgv_peliculas.Columns.Add("1", "DIRECTOR");
            dgv_peliculas.Columns.Add("3", "PRODUCTORA");
            dgv_peliculas.Columns.Add("5", "DESCRIPCION");
            dgv_peliculas.Columns.Add("6", "CANTIDAD");
            dgv_peliculas.Columns.Add("7", "AÑO");

            dgv_peliculas.Columns[0].Width = 100;
            dgv_peliculas.Columns[1].Width = 300;
            dgv_peliculas.Columns[2].Width = 100;
            dgv_peliculas.Columns[3].Width = 150;
            dgv_peliculas.Columns[4].Width = 150;
            dgv_peliculas.Columns[5].Width = 300;
            dgv_peliculas.Columns[6].Width = 100;
            dgv_peliculas.Columns[7].Width = 120;
        }

        private void Cargar_dgv_peliculas()
        {
            dgv_peliculas.Rows.Clear();
            dgv_peliculas.Rows.Add();
            DataSet ds = new DataSet();
            ds = ObjPeliculas.lista_de_peliculas("Cargar");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_peliculas.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());
                }
            }
            else
                MessageBox.Show("No hay Peliculas cargadas en el sistema");
        }

        #endregion


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dgv_peliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
