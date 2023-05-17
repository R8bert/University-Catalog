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
    public partial class CD_Main : Form
    {
        public CD_Main()
        {
            InitializeComponent();
        }

        private void CD_Main_Load(object sender, EventArgs e)
        {
            //using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            //{
            //    if (connection != null)
            //    {
            //        try
            //        {
            //            string query = "SELECT ID_CadruDidactic,NumeCadruDidactic,PrenumeCadruDidactic,MarcaAngajat,Titlu,Post FROM cadredidactice";

            //            MySqlCommand command = new MySqlCommand(query, connection);

            //            connection.Open();

            //            using (MySqlDataReader reader = command.ExecuteReader())
            //            {
            //                listBox1.Items.Clear();

            //                while (reader.Read())
            //                {
            //                    int idCadru = reader.GetInt32(0);
            //                    string Nume = reader.GetString(1);
            //                    string Prenume = reader.GetString(2);
            //                    string MarcaAngajat = reader.GetString(3);
            //                    string Titlu = reader.GetString(4);
            //                    string Post = reader.GetString(5);
            //                    string listItem = string.Format("ID_CadruDidactic: {0} - Nume : {1} - Prenume {2} - MarcaAngajat {3} - Titlu {4} - Post {5}", idCadru, Nume, Prenume, MarcaAngajat, Titlu, Post);
            //                    listBox1.Items.Add(listItem);
            //                }
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("A apărut o eroare: " + ex.Message);
            //        }
            //        finally
            //        {

            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
            //    }
            //}
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_CadruDidactic, NumeCadruDidactic, PrenumeCadruDidactic, MarcaAngajat, Titlu, Post FROM cadredidactice";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();

                            while (reader.Read())
                            {
                                int idCadru = reader.GetInt32(0);
                                string Nume = reader.GetString(1);
                                string Prenume = reader.GetString(2);
                                string MarcaAngajat = reader.GetString(3);
                                string Titlu = reader.GetString(4);
                                string Post = reader.GetString(5);

                                dataGridView1.Rows.Add(idCadru, Nume, Prenume, MarcaAngajat, Titlu, Post);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CD_AddCD ADD_CadruD = new CD_AddCD();
            ADD_CadruD.FormClosing += new FormClosingEventHandler(this.Insert_FormClosing);
            ADD_CadruD.ShowDialog();
        }
        private async void Insert_FormClosing(object sender, FormClosingEventArgs e)
        {
            await Task.Delay(2000);

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_CadruDidactic, NumeCadruDidactic, PrenumeCadruDidactic, MarcaAngajat, Titlu, Post FROM cadredidactice";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridView1.Rows.Clear();

                            while (reader.Read())
                            {
                                int idCadru = reader.GetInt32(0);
                                string Nume = reader.GetString(1);
                                string Prenume = reader.GetString(2);
                                string MarcaAngajat = reader.GetString(3);
                                string Titlu = reader.GetString(4);
                                string Post = reader.GetString(5);

                                dataGridView1.Rows.Add(idCadru, Nume, Prenume, MarcaAngajat, Titlu, Post);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CD_DeleteDialog cD_DeleteDialog = new CD_DeleteDialog();
            cD_DeleteDialog.FormClosing += new FormClosingEventHandler(this.Insert_FormClosing);
            cD_DeleteDialog.ShowDialog();


        }
    }
}
