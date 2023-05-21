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
        public static int Id_Ciclu;

        public AdaugareProgrameStudii()
        {
            InitializeComponent();
        }

        private void AdaugareProgrameStudii_Load(object sender, EventArgs e)
        {
            LoadDataToCicluri();
        }

        private void LoadDataToCicluri()
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Ciclu,NumeCiclu FROM cicluriinvatamant";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idCiclu = reader.GetInt32(0);
                                string numeCiclu = reader.GetString(1);
                                Cicluri.Items.Add(numeCiclu);
                                Id_Ciclu = idCiclu;
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        int idProgram;

                        if (!Int32.TryParse(NumarProgram.Text, out idProgram))
                        {
                            MessageBox.Show("Numarul programului trebuie să fie un număr întreg.");
                            return;
                        }

                        string numeProgram = NumeProgram.Text;

                        string insertQuery = "INSERT INTO programestudii(ID_Program, NumeProgram, ID_Ciclu) VALUE (@idProgram, @numeProgram, @idCiclu)";

                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@idProgram", idProgram);
                            cmd.Parameters.AddWithValue("@numeProgram", numeProgram);
                            cmd.Parameters.AddWithValue("@idCiclu", Id_Ciclu);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Date inserate");
                            }
                            else
                            {
                                MessageBox.Show("Date neinserate");
                            }
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
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }
    }
}

