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
    public partial class Grupe : Form
    {
        public Grupe()
        {
            InitializeComponent();
        }
        private void Grupe_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT NumeStudent,PrenumeStudent,DataInscriere,ID_Ciclu,MediaInscriere, id_grupa ,ID_ProgramStudii, ID_Student FROM studenti";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string numeStudent = reader.GetString(0);
                                string prenumeStudent = reader.GetString(1);
                                DateTime dataInscriere = reader.GetDateTime(2);
                                int idCiclu = reader.GetInt32(3);
                                int mediaInscriere = (int)reader.GetDouble(4);
                                int program = reader.GetInt32(6);
                                int grupa = reader.GetInt32(5);
                                int idStudent = reader.GetInt32(6);
                                dataGridView1.Rows.Add(idStudent, numeStudent, prenumeStudent, program, idCiclu, dataInscriere.ToString("yyyy-MM-dd"), mediaInscriere);
                            }

                            dataGridView1.Refresh();

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                GenerareGrupe generare = new GenerareGrupe();
                generare.Show();
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
                ImportareGrupe import = new ImportareGrupe();
                import.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                EditareGrupe edit = new EditareGrupe();
                edit.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
            
        }
    }
}
