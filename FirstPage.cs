using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            CI_Main cicluriPanel = new CI_Main();
            cicluriPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProgrameStudii programeStudii = new ProgrameStudii();
            programeStudii.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Note note = new Note();
            note.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginPage logout = new LoginPage();
            logout.Show();
            this.Close();

        }


        private void btn_CadreDidactice_Click(object sender, EventArgs e)
        {
            CD_Main CD = new CD_Main();
            CD.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            ST_StudentiMain studenti = new ST_StudentiMain();
            studenti.ShowDialog();
        }

        private void btn_grupe_Click(object sender, EventArgs e)
        {
            Grupe grupe = new Grupe();
            grupe.ShowDialog();
        }

        private void btn_anistudiu_Click(object sender, EventArgs e)
        {
            AniStudiu ani = new AniStudiu();
            ani.ShowDialog();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            DI_DisciplineMain DI = new DI_DisciplineMain();
            DI.ShowDialog();
        }
    }
}
