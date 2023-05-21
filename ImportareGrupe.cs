using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class ImportareGrupe : Form
    {
        public ImportareGrupe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = $"SELECT ID_Student, DataInscriere, MediaInscriere FROM studenti WHERE YEAR(DataInscriere)<YEAR('{DateTime.Now.Year}')";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DateTime dateInserted = DateTime.ParseExact(textBox2.Text, "yyyy", CultureInfo.CurrentCulture);
                            int numarGrupe = int.Parse(textBox1.Text);
                            int numarStudenti = 0;

                            while (reader.Read())
                            {
                                int idStudent = reader.GetInt32(0);
                                DateTime data = reader.GetDateTime(1);
                                int mediaInscriere = reader.GetInt32(2);
                                if (data.Year < DateTime.Now.Year && data.Year == dateInserted.Year && mediaInscriere >= 5)
                                {
                                    numarStudenti += 1;
                                }
                            }

                            int counter = 0;
                            int idGrupa = 0;
                            reader.Close();
                            MySqlCommand cmdUpdate;
                            string updateQuery;

                            while (counter < numarStudenti)
                            {
                                query = $"SELECT ID_Student, DataInscriere, ID_Grupa, MediaInscriere FROM studenti WHERE YEAR(DataInscriere)<YEAR('{DateTime.Now.Year}') AND DataInscriere='{dateInserted.Date:yyyy-MM-dd}' AND MediaInscriere>=5";
                                command = new MySqlCommand(query, connection);

                                using (MySqlDataReader newReader = command.ExecuteReader())
                                {
                                    while (newReader.Read())
                                    {
                                        int idStudent = newReader.GetInt32(0);
                                        DateTime data = newReader.GetDateTime(1);
                                        int idGrupaValue = newReader.GetInt32(2);

                                        if (data.Date == dateInserted.Date)
                                        {
                                            idGrupa = (counter % numarGrupe) + 1;

                                            if (idGrupaValue != idGrupa)
                                            {
                                                cmdUpdate = new MySqlCommand();
                                                updateQuery = "UPDATE studenti SET id_grupa = @idgrupa WHERE ID_Student = @id";
                                                cmdUpdate.CommandText = updateQuery;
                                                cmdUpdate.Parameters.AddWithValue("@idgrupa", idGrupa);
                                                cmdUpdate.Parameters.AddWithValue("@id", idStudent);
                                                cmdUpdate.ExecuteNonQuery();

                                                counter += 1;
                                            }

                                            if (counter >= numarStudenti)
                                            {
                                                break;
                                            }
                                        }
                                    }
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
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }
    }
}
