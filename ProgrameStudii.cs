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
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Program,NumeProgram, ID_Ciclu FROM programestudii";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                int idProgram = reader.GetInt32(0);
                                string numeProgram = reader.GetString(1);
                                int idCiclu = reader.GetInt32(2);
                                string listItem = string.Format("ID: {0} - Nume Program: {1} - ID Ciclu: {2}", idProgram, numeProgram, idCiclu);
                                listBox1.Items.Add(listItem);
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
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adaugare_Click(object sender, EventArgs e)
        {

            AdaugareProgrameStudii adaugareprograme = new AdaugareProgrameStudii();
            adaugareprograme.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StergereProgrameStudii stergereprograme = new StergereProgrameStudii();
            stergereprograme.Show();
        }
    }
}
