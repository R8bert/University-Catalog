using System;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class CI_InputDialogBox : Form
    {
        public string NumeCicluValue { get; private set; }
        public int IDValue { get; private set; }

        public CI_InputDialogBox()
        {
            InitializeComponent();
        }
        private void InputDialogBox_Load(object sender, EventArgs e)
        {
            // Orice cod necesar pentru încărcarea dialogului
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NumeCicluValue = txtNumeCiclu.Text;
            IDValue = Convert.ToInt32(txtID.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtNumeCiclu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}