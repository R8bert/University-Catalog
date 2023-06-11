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
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT grupe.Id_Grupa, grupe.NumeGrupa, studenti.ID_Student, grupe.ID_An FROM grupe INNER JOIN studenti ON grupe.ID_Grupa = studenti.ID_Grupa";
                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                int idGrupa = reader.GetInt32(0);
                                string numeGrupa = reader.GetString(1);
                                int idStudent = reader.GetInt32(2);
                                int idAn = reader.GetInt32(3);
                                dataGridView1.Rows.Add(idGrupa, numeGrupa, idStudent, idAn);
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

        private void Grupe_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                AdaugareGrupe adaugare = new AdaugareGrupe();
                adaugare.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {
                AdaugareGrupe adaugare = new AdaugareGrupe();
                adaugare.Show();
            }
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }
    }
}
