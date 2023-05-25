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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicatie
{
    public partial class EditareGrupe : Form
    {
        public EditareGrupe()
        {
            InitializeComponent();
        }

        private void adaugareStudent_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {

            
            int studentId = int.Parse(textBox1.Text);
            int groupId = int.Parse(textBox2.Text);

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand("UPDATE studenti SET id_grupa = @grupa WHERE ID_Student = @id", connection);
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.Parameters.AddWithValue("@grupa", groupId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Studentul a fost actualizat cu succes în grupa " + groupId);
                        }
                        else
                        {
                            MessageBox.Show("Studentul nu a putut fi actualizat în grupa " + groupId);
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
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }

        private void stergeStudent_Click(object sender, EventArgs e)
        {
            if (Global.utilizator == "admin" || Global.utilizator == "secreatar")
            {

            
            int studentId = int.Parse(textBox1.Text);
            int groupId = int.Parse(textBox2.Text);

            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();

                        MySqlCommand cmd = new MySqlCommand("UPDATE studenti SET id_grupa = NULL WHERE ID_Student = @id AND id_grupa = @grupa", connection);
                        cmd.Parameters.AddWithValue("@id", studentId);
                        cmd.Parameters.AddWithValue("@grupa", groupId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Studentul a fost eliminat cu succes din grupa " + groupId);
                        }
                        else
                        {
                            MessageBox.Show("Studentul nu a fost găsit în grupa " + groupId);
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
            else
            {
                MessageBox.Show("Nu aveti permisiunea");
            }
        }
    }
}
