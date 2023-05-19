using MySql.Data.MySqlClient;
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
    public partial class ST_AdaugareStudent : Form
    {
        public ST_AdaugareStudent()
        {
            InitializeComponent();
        }

        private void button_Ad_Click(object sender, EventArgs e)
        {
            if (textBox_IDS.Text != "" && textBox_NM.Text != "" && textBox_N.Text != "" && textBox_P.Text != "" && textBox_IT.Text != "" && textBox_CNP.Text != "" && textBox_IDC.Text != "" && textBox_MI.Text != "")
            {
                string idst = textBox_IDS.Text;
                string nrm = textBox_NM.Text;
                string nst = textBox_N.Text;
                string pst = textBox_P.Text;
                string inta = textBox_IT.Text;
                string Cnp = textBox_CNP.Text;
                string dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string idci = textBox_IDC.Text;
                string md = textBox_MI.Text;
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO `studenti` (`ID_Student`, `NumarMatricol`, `NumeStudent`, `PrenumeStudent`, `InitialaTata`, `CNP`, `DataInscriere`, `ID_Ciclu`, `MediaInscriere`) VALUES ('";
                            query += idst + "','" + nrm + "','" + nst + "','" + pst + "','" + inta + "','" + Cnp + "','" + dt + "','" + idci + "','" + md + "');";
                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                            }
                            MessageBox.Show("Student Adaugat");
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
            else
            {
                MessageBox.Show("Nu se poate adauga un student cu date incomplete", "Eroare");
            }
        }
    }
}
