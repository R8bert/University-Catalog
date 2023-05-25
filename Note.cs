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
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar" || Global.utilizator=="cadru")
            {
                CN_AdaugareNota adn = new CN_AdaugareNota();
                adn.FormClosing += new FormClosingEventHandler(this.Note_Load);
                adn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
            
        }

        private void button_gc_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar" || Global.utilizator=="cadru")
            {
                CN_Salvare sv = new CN_Salvare();
                sv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
