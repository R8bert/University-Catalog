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
    public partial class AniStudiu : Form
    {
        public AniStudiu()
        {
            InitializeComponent();
        }

        private void AniStudiu_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                try
                {
                    string query = "SELECT ID_An, NumeAn, ID_Program FROM anistudii";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.Rows.Clear();
                        foreach (DataRow item in dataTable.Rows)
                        {
                            int n = dataGridView1.Rows.Add();
                            dataGridView1.Rows[n].Cells[0].Value = $"{item[0]}";
                            dataGridView1.Rows[n].Cells[1].Value = $"{item[1]}";
                            dataGridView1.Rows[n].Cells[2].Value = $"{item[2]}";
                        }
                        dataGridView1.ReadOnly = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"A apărut o eroare: {ex.Message}");
                }
                finally
                {
                    if (connection.State != ConnectionState.Closed)
                    { connection.Close(); }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                AdaugareAniStudiu adauga = new AdaugareAniStudiu();
                adauga.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                StergereAniStudiu sterge = new StergereAniStudiu();
                sterge.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
            
        }
    }
}
