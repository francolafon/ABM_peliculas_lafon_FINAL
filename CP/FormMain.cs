using System;
using System.Windows.Forms;

namespace CP
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAlta();
            formulario.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formulario = new FormModificar();
            formulario.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void labeltitulo1_Click(object sender, EventArgs e)
        {

        }

        private void lblbuscar_Click(object sender, EventArgs e)
        {

        }

        private void labeltitulo1_Click_1(object sender, EventArgs e)
        {

        }

        #region DGV_Peliculas
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void crear_dgv_peliculas()
        {
            dgv_peliculas.Columns.Add("0", "ID");
            dgv_peliculas.Columns.Add("1", "DIRECTOR");
            dgv_peliculas.Columns.Add("2", "CATEGORIA");
            dgv_peliculas.Columns.Add("3", "PRODUCTORA");
            dgv_peliculas.Columns.Add("4", "TITULO");
            dgv_peliculas.Columns.Add("5", "DESCRIPCION");
            dgv_peliculas.Columns.Add("6", "CANTIDAD");
            dgv_peliculas.Columns.Add("7", "AÑO");

            dgv_peliculas.Columns[0].Width = 100;
            dgv_peliculas.Columns[1].Width = 100;
            dgv_peliculas.Columns[2].Width = 100;
            dgv_peliculas.Columns[3].Width = 100;
            dgv_peliculas.Columns[4].Width = 100;
            dgv_peliculas.Columns[5].Width = 100;
            dgv_peliculas.Columns[6].Width = 100;

        }
        #endregion

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
