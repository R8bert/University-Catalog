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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicatie
{
    public partial class DI_Adaugare : Form
    {
        public DI_Adaugare()
        {
            InitializeComponent();
        }

        private void button_Ad_Click(object sender, EventArgs e)
        {
            if (textBox_IDD.Text != "" && textBox_ND.Text != "" && textBox_AD.Text != "" && textBox_NC.Text != "" && textBox_IDA.Text != "")
            {
                string idd = textBox_IDD.Text;
                string nd = textBox_ND.Text;
                string ad = textBox_AD.Text;
                string nc = textBox_NC.Text;
                string ida = textBox_IDA.Text;
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO `planuriinvatamant` (ID_Disciplina,NumeDisciplina,AcronimDisciplina,NumarCredite,ID_An) VALUES ('";
                            query += idd + "','" + nd + "','" + ad + "','" + nc + "','" + ida + "');";
                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                            }
                            MessageBox.Show("Disciplina Adaugata");
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
                MessageBox.Show("Nu se poate adauga o disciplina cu date incomplete", "Eroare");
            }
        }
    }
}
