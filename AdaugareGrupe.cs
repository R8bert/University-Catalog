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
    public partial class AdaugareGrupe : Form
    {
        public static int Id_An;
        public AdaugareGrupe()
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
                        string numeGrupa = textBox2.Text;
                        int idgrupa = int.Parse(textBox1.Text);
                        string insertQuery = "INSERT INTO grupe(ID_Grupa, NumeGrupa, ID_An) VALUE (@idgrupa, @numgrupa, @idan)";

                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@idgrupa", idgrupa);
                            cmd.Parameters.AddWithValue("@numegrupa", numeGrupa);
                            cmd.Parameters.AddWithValue("@idan", Id_An);

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

        private void AdaugareAniStudiu_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_An,NumeAn FROM anistudii";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idAn = reader.GetInt32(0);
                                string numeAn = reader.GetString(1);
                                comboBox1.Items.Add(numeAn);
                                Id_An = idAn;
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
