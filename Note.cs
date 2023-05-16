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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Note_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Catalog,ID_Student,ID_Disciplina,Nota FROM cataloage";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                int idCatalog = reader.GetInt32(0);
                                int idStudent = reader.GetInt32(0);
                                int idDisciplina = reader.GetInt32(0);
                                int Nota = reader.GetInt32(0);
                                string listItem = string.Format("ID Catalog: {0} - ID Student: {1} - ID Disciplina: {2} - Nota: {3}", idCatalog, idStudent, idDisciplina, Nota);
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

        private void button_adn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "INSERT INTO cataloage(ID_Catalog,ID_Student,ID_Disciplina,Nota) Values(2,10045,50,6)";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                int idCatalog = reader.GetInt32(0);
                                int idStudent = reader.GetInt32(0);
                                int idDisciplina = reader.GetInt32(0);
                                int Nota = reader.GetInt32(0);
                                string listItem = string.Format("ID Catalog: {0} - ID Student: {1} - ID Disciplina: {2} - Nota: {3}", idCatalog, idStudent, idDisciplina, Nota);
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

        private void button_gc_Click(object sender, EventArgs e)
        {

        }
    }
}
