using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

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

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]+$";
            bool esteNumar = Regex.IsMatch(txtID.Text, pattern);
            if (esteNumar)
            {
                NumeCicluValue = txtNumeCiclu.Text;
                IDValue = Convert.ToInt32(txtID.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Puteti introduce doar numere in campul ID");

            }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}