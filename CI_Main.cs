using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class CI_Main : Form
    {
        public CI_Main()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CicluriInvatamant_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Ciclu,NumeCiclu FROM cicluriinvatamant";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                int idCiclu = reader.GetInt32(0);
                                string numeCiclu = reader.GetString(1);
                                string listItem = string.Format("ID: {0} - Nume Ciclu: {1}", idCiclu, numeCiclu);
                                listBox1.Items.Add(listItem);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                    finally
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }

        }
        private void Insert(object sender, EventArgs e)
        {
            CI_InputDialogBox inputDialog = new CI_InputDialogBox();
            DialogResult result = inputDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string numeCiclu = inputDialog.NumeCicluValue;
                int idCiclu = inputDialog.IDValue;

                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    try
                    {
                        string query = "INSERT INTO cicluriinvatamant (ID_Ciclu, NumeCiclu) VALUES (@idCiclu, @numeCiclu)";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idCiclu", idCiclu);
                        command.Parameters.AddWithValue("@numeCiclu", numeCiclu);

                        connection.Open();
                        command.ExecuteNonQuery();
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
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Insert(sender, e);
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            CI_DeleteDialog Delete_CI = new CI_DeleteDialog();
            Delete_CI.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
            Delete_CI.Show();

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        string query = "SELECT ID_Ciclu,NumeCiclu FROM cicluriinvatamant";

                        MySqlCommand command = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            listBox1.Items.Clear();

                            while (reader.Read())
                            {
                                int idCiclu = reader.GetInt32(0);
                                string numeCiclu = reader.GetString(1);
                                string listItem = string.Format("ID: {0} - Nume Ciclu: {1}", idCiclu, numeCiclu);
                                listBox1.Items.Add(listItem);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A apărut o eroare: " + ex.Message);
                    }
                    finally
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }
    }

}
