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
    public partial class ST_StudentiMain : Form
    {
        public ST_StudentiMain()
        {
            InitializeComponent();
        }
        private void Studenti_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Student,NumarMatricol,NumeStudent,PrenumeStudent,InitialaTata,CNP,DataInscriere,ID_Ciclu,MediaInscriere FROM studenti";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();
                            while (reader.Read())
                            {
                                string ids = reader.GetString(0);
                                string nm = reader.GetString(1);
                                string ns = reader.GetString(2);
                                string ps = reader.GetString(3);
                                string it = reader.GetString(4);
                                string cnp = reader.GetString(5);
                                string di = reader.GetString(6);
                                string idc = reader.GetString(7);
                                string mi = reader.GetString(8);
                                dataGridView1.Rows.Add(ids,nm,ns,ps,it,cnp,di,idc,mi);
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

        private void button_Ad_Click(object sender, EventArgs e)
        {
            ST_AdaugareStudent ada = new ST_AdaugareStudent();
            ada.FormClosing += new FormClosingEventHandler(this.Studenti_Load);
            ada.ShowDialog();
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            ST_StergereStudent ads = new ST_StergereStudent();
            ads.FormClosing += new FormClosingEventHandler(this.Studenti_Load);
            ads.ShowDialog();
        }
    }
}
