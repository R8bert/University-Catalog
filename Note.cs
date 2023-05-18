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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                int idCatalog = reader.GetInt32(0);
                                int idStudent = reader.GetInt32(1);
                                int idDisciplina = reader.GetInt32(2);
                                float Nota = reader.GetInt32(3);
                                dataGridView1.Rows.Add(idCatalog, idStudent, idDisciplina, Nota);
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
            CN_AdaugareNota adn = new CN_AdaugareNota();
            adn.FormClosing += new FormClosingEventHandler(this.Note_Load);
            adn.ShowDialog();
            //adn.Show();
        }

        private void button_gc_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV File|*.csv";
            saveFileDialog1.Title = "Save a CSV File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter csv = new StreamWriter(saveFileDialog1.FileName);
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
                                csv.WriteLine("ID Catalog,ID Student,Id Disciplina,Nota");
                                while (reader.Read())
                                {
                                    int idCatalog = reader.GetInt32(0);
                                    int idStudent = reader.GetInt32(1);
                                    int idDisciplina = reader.GetInt32(2);
                                    float Nota = reader.GetInt32(3);
                                    csv.WriteLine(idCatalog.ToString()+","+idStudent.ToString()+","+idDisciplina.ToString()+","+Nota.ToString());
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
                csv.Close();
                MessageBox.Show("Fisier salvat");
            }
        }
    }
}
