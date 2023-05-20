using Google.Protobuf.WellKnownTypes;
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
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Aplicatie
{
    public partial class GenerareGrupe : Form
    {
        public GenerareGrupe()
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
                        string query = "SELECT ID_Student,DataInscriere FROM studenti";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int numarGrupe = int.Parse(textBox1.Text);
                                int id = reader.GetInt32(0);
                                DateTime data = reader.GetDateTime(1);
                                DateTime date = Convert.ToDateTime(data);
                                int an = date.Year;
                                if (an == int.Parse(textBox2.Text))
                                {
                                    int var = numarGrupe;
                                    for (int i = 0; i <= numarGrupe; i++)
                                    {
                                        string idgrupa = i.ToString();
                                        string numeGrupa = "Grupa " + i;
                                        string insertQuery = "INSERT INTO grupe(ID_Grupa,NumeGrupa, ID_An) VALUES (@idgrupa,@numegrupa,@idan)";
                                        string insertQuery2 = "UPDATE studenti SET id_grupa=@idgrupa WHERE ID_Student =@id";
                                        MySqlCommand cmd = new MySqlCommand();
                                        cmd.CommandText = insertQuery;
                                        cmd.Parameters.AddWithValue("@idgrupa", idgrupa);
                                        cmd.Parameters.AddWithValue("@numegrupa", numeGrupa);
                                        cmd.Parameters.AddWithValue("@idan", an);
                                        cmd.ExecuteNonQuery();
                                        MySqlCommand cmd2 = new MySqlCommand();
                                        cmd2.CommandText = insertQuery2;
                                        cmd2.Parameters.AddWithValue("@idgrupa", idgrupa);
                                        cmd2.Parameters.AddWithValue("@id", id);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerareGrupe_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    MessageBox.Show("conexiune reusita");
                }
                else
                {
                    MessageBox.Show("conexiune esuata");
                }
            }

        }
    }
}
