using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{

    public partial class AdaugareProgrameStudii : Form
    {
        public static string ValoareNumarProgram = "";
        public static string ValoareNumeProgram = "";
        public static string ValoareIdCiclu = "";
        public AdaugareProgrameStudii()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cicluri_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void AdaugareProgrameStudii_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {

                try
                {
                    string query = "SELECT ID_Ciclu,NumeCiclu FROM cicluriinvatamant";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cicluri.Items.Add(reader.GetString("NumeCiclu"));
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {

                try
                {
                    string insertQuery = "INSERT INTO programestudii(ID_Program,NumeProgram, ID_Ciclu) VALUE ('" + NumarProgram.Text + "','" + NumeProgram.Text + "','" + Cicluri.SelectedIndex + "')";
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(insertQuery, connection);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Date inserate");
                    }
                    else
                    {
                        MessageBox.Show("Date neinserate");
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                Close();
            }
        }
    }
}
