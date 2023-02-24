using System;
using System.Windows.Forms;

namespace CP
{
    public partial class FormAltaProductora : Form
    {
        public FormAltaProductora()
        {
            InitializeComponent();
        }

        private void FormAltaProductora_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_prod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
