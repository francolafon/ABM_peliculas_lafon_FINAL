using System;
using System.Windows.Forms;

namespace CP
{
    public partial class FormMain : Form
    {
        private object cb_Peliculas;

        public FormMain()
        {
            InitializeComponent();
        }

        private void LlenarCombos()
        {

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
            this.FormClosed += new FormClosedEventHandler(btnSalir_Click);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GrillaBD_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
