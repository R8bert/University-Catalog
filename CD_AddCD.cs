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
    public partial class CD_AddCD : Form
    {
        public CD_AddCD()
        {
            InitializeComponent();
        }

        private void CD_AddCD_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nume = textBox2.Text;
            string prenume = textBox3.Text;
            string marcaangajat = textBox4.Text;
            string titlu = textBox5.Text;
            string post = textBox6.Text;


            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                try
                {

                    string query = "INSERT INTO cadredidactice (ID_CadruDidactic, NumeCadruDidactic,PrenumeCadruDidactic,MarcaAngajat   ,Titlu,Post) VALUES (@id, @nume, @prenume, @marcaangajat, @titlu, @post)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nume", nume);
                    command.Parameters.AddWithValue("@prenume", prenume);
                    command.Parameters.AddWithValue("@marcaangajat", marcaangajat);
                    command.Parameters.AddWithValue("@titlu", titlu);
                    command.Parameters.AddWithValue("@post", post);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
                finally
                {
                    this.Close();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
