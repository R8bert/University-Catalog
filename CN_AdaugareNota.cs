using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class CN_AdaugareNota : Form
    {
        public CN_AdaugareNota()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Ad_Click(object sender, EventArgs e)
        {
            string idc = textBox_IDC.Text;
            string ids = textBox_IDS.Text;
            string idd = textBox_IDD.Text;
            float nota = float.Parse(textBox_N.Text);
            if (!(nota < 0 || nota > 10))
            {
                int er = 0;
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        try
                        {
                            string query = "INSERT INTO cataloage(ID_Catalog,ID_Student,ID_Disciplina,Nota) Values(" + idc + "," + ids + "," + idd + "," + nota + ");";

                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();
                           // MessageBox.Show("Nota adaugata");
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                // listBox1.Items.Clear();

                                while (reader.Read())
                                {
                                    int idCatalog = reader.GetInt32(0);
                                    int idStudent = reader.GetInt32(1);
                                    int idDisciplina = reader.GetInt32(2);
                                    int Nota = reader.GetInt32(3);
                                    string listItem = string.Format("ID Catalog: {0} - ID Student: {1} - ID Disciplina: {2} - Nota: {3}", idCatalog, idStudent, idDisciplina, Nota);
                                    //  listBox1.Items.Add(listItem);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("A apărut o eroare: " + ex.Message);
                            er++;
                        }
                        finally
                        {
                            connection.Close();
                        }
                        if (er == 0)
                        {
                            MessageBox.Show("Nota adaugata");
                            textBox_N.Text = "";
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
                MessageBox.Show("Valoare incorecta a notei", "Eroare");
            }
        }

    }
}
