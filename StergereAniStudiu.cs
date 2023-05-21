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
    public partial class StergereAniStudiu : Form
    {
        public StergereAniStudiu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {

                try
                {
                    int idprogram = int.Parse(textBox1.Text);
                    string query = "DELETE FROM anistudii WHERE ID_Program = @idprogram;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idprogram", idprogram);
                    connection.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Datele au fost sterse");
                    }
                    else
                    {
                        MessageBox.Show("Datele nu au fost sterse");
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
        }
    }
}
