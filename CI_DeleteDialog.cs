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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf.WellKnownTypes;


namespace Aplicatie
{



    public partial class CI_DeleteDialog : Form
    {
        public CI_DeleteDialog()
        {
            InitializeComponent();
        }
        private void CI_DeleteDialog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CI_Delete_Confirm_Click(object sender, EventArgs e)
        {
            string pattern = "^[0-9]+$";
            bool esteNumar = Regex.IsMatch(CI_DeleteIDTextBox.Text, pattern);
            //string idCiclu = CI_DeleteIDTextBox.Text;
            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))

            {
                if(connection != null)
                {
                    if (esteNumar)
                    {
                        try
                        {
                            int ID_CI = Convert.ToInt32(CI_DeleteIDTextBox.Text);
                            string query = "DELETE FROM cicluriinvatamant WHERE ID_Ciclu = @ID_CI";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@ID_CI", ID_CI);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ciclu de învățământ șters cu succes!");
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a putut șterge ciclul de învățământ.");
                            }
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
                    else
                    {
                        MessageBox.Show("Trebuie introdus un numar!");

                    }
                }
                else
                {
                    MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                }
            }
        }

        private void CI_DeleteIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
