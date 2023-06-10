using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class ProgrameStudii : Form
    {
        public ProgrameStudii()
        {
            InitializeComponent();
        }

        private void ProgrameStudii_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                try
                {
                    string query = "SELECT ID_Program, NumeProgram, ID_Ciclu FROM programestudii";

                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idProgram = reader.GetInt32(0);
                                string numeProgram = reader.GetString(1);
                                int idCiclu = reader.GetInt32(2);
                                dataGridView1.Rows.Add(idProgram, numeProgram, idCiclu);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adaugare_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
            AdaugareProgrameStudii adaugareprograme = new AdaugareProgrameStudii();
            adaugareprograme.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
            StergereProgrameStudii stergereprograme = new StergereProgrameStudii();
            stergereprograme.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
           
        }
    }
}
