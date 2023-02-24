using System;
using System.Windows.Forms;

namespace CP
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
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
    }
}
