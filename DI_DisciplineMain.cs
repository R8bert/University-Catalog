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
    public partial class DI_DisciplineMain : Form
    {
        public DI_DisciplineMain()
        {
            InitializeComponent();
        }

        private void Discipline_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Disciplina,NumeDisciplina,AcronimDisciplina,NumarCredite,ID_An FROM planuriinvatamant";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                string idd = reader.GetString(0);
                                string nd = reader.GetString(1);
                                string ad = reader.GetString(2);
                                string nc = reader.GetString(3);
                                string ida = reader.GetString(4);
                                dataGridView1.Rows.Add(idd, nd, ad, nc, ida);
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

        private void buttonAd_Click(object sender, EventArgs e)
        {
            DI_Adaugare dia = new DI_Adaugare();
            dia.FormClosing += new FormClosingEventHandler(this.Discipline_Load);
            dia.ShowDialog();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            DI_Stergere dis = new DI_Stergere();
            dis.FormClosing += new FormClosingEventHandler(this.Discipline_Load);
            dis.ShowDialog();
        }
    }
}
