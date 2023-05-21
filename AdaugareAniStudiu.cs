using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class AdaugareAniStudiu : Form
    {
        public static int Id_Program;
        public AdaugareAniStudiu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string numeAn = textBox2.Text;
                        int idan = int.Parse(textBox1.Text);
                        string insertQuery = "INSERT INTO anistudii(ID_An, NumeAn, ID_Program) VALUE (@idan, @numean, @idprogram)";

                        connection.Open();
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@idan", idan);
                            cmd.Parameters.AddWithValue("@numean", numeAn);
                            cmd.Parameters.AddWithValue("@idprogram", Id_Program);

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
                        string query = "SELECT ID_Program,NumeProgram FROM programestudii";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idProgram = reader.GetInt32(0);
                                string numeProgram = reader.GetString(1);
                                comboBox1.Items.Add(numeProgram);
                                Id_Program = idProgram;
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
