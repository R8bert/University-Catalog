using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(130, 148, 196);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CicluriInvatamant cicluriPanel = new CicluriInvatamant();
            cicluriPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgrameStudii programeStudii = new ProgrameStudii();
            programeStudii.Show();
        }
    }
}
