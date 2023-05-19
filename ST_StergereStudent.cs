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
    public partial class ST_StergereStudent : Form
    {
        public ST_StergereStudent()
        {
            InitializeComponent();
        }

        private void button_St_Click(object sender, EventArgs e)
        {
            if(textBox_IDS.Text!="")
            {
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "DELETE FROM studenti WHERE ID_Student=";
                            query += textBox_IDS.Text;

                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                             
                            }
                            MessageBox.Show("Student sters");
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
            else
            {
                MessageBox.Show("Introduceti ID Student");
            }
        }
    }
}
