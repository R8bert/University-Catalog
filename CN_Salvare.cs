using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Aplicatie
{
    public partial class CN_Salvare : Form
    {
        public CN_Salvare()
        {
            InitializeComponent();
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            string id=textBox_ID.Text;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV File|*.csv";
            saveFileDialog1.Title = "Save a CSV File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int[] ids = new int[125];
                int nrid = 0;
                TextWriter csv = new StreamWriter(saveFileDialog1.FileName);
                using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
                {
                    if (connection != null)
                    {
                        int nrs = 0;
                        try
                        {
                            string query = "SELECT DISTINCT ID_Student FROM cataloage";
                            MySqlCommand command = new MySqlCommand(query, connection);

                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int idst = reader.GetInt32(0);
                                    ids[nrid] = idst;
                                    nrid++;
                                }
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
                        csv.WriteLine("Nume,Prenume,Note");
                        for (int i = 0; i < nrid; i++)
                        {
                            try
                            {
                                // string query = "SELECT ID_Catalog,ID_Student,ID_Disciplina,Nota FROM cataloage";
                                // string query = "SELECT Nota FROM cataloage WHERE ID_Student=";
                                // string query = "SELECT cataloage.ID_Student, planuriinvatamant.AcronimDisciplina, cataloage.Nota \r\nFROM `cataloage`\r\nINNER JOIN planuriinvatamant ON cataloage.ID_Disciplina=planuriinvatamant.ID_Disciplina\r\nWHERE id_catalog=2";
                                // string query = "SELECT studenti.NumeStudent,studenti.PrenumeStudent, planuriinvatamant.AcronimDisciplina, cataloage.Nota \r\nFROM `cataloage`\r\nINNER JOIN planuriinvatamant ON cataloage.ID_Disciplina=planuriinvatamant.ID_Disciplina\r\nINNER JOIN studenti ON cataloage.ID_Student=studenti.ID_Student\r\nWHERE ID_Student=";
                                string query= "SELECT studenti.NumeStudent,studenti.PrenumeStudent, planuriinvatamant.AcronimDisciplina, cataloage.Nota FROM `cataloage` INNER JOIN planuriinvatamant ON cataloage.ID_Disciplina = planuriinvatamant.ID_Disciplina INNER JOIN studenti ON cataloage.ID_Student = studenti.ID_Student WHERE cataloage.ID_Student =";
                                query += ids[i].ToString();
                                query += " AND ID_Catalog=";
                                query += id;
                                float media = 0;
                                float nr = 0;
                                int restantier = 0;
                                MySqlCommand command = new MySqlCommand(query, connection);
                                connection.Open();
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    int x = 0;   
                                    while (reader.Read())
                                    {
                                        string nume = reader.GetString(0);
                                        string prenume = reader.GetString(1);
                                        string Disciplina = reader.GetString(2);
                                        float Nota = reader.GetFloat(3);
                                        if (Nota >= 0 && Nota <= 10)
                                        {
                                            media += Nota;
                                            nr++;
                                        }
                                        if (x == 0)
                                        {
                                            csv.Write(nume + "," + prenume + "," + Nota.ToString());
                                        }
                                        else
                                        {
                                            csv.Write("," + Nota);
                                        }
                                        if(Nota<5)
                                        {
                                            restantier++;
                                        }
                                        x++;
                                    }
                                    media /= nr;
                                    csv.Write(", ," + media.ToString());
                                    if(restantier==0)
                                    {
                                        csv.WriteLine(",integralist");
                                    }
                                    else
                                    {
                                        csv.WriteLine(",restantier");
                                    }
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
                    else
                    {
                        MessageBox.Show("Conexiunea la baza de date nu a putut fi stabilită!");
                    }
                }
                csv.Close();
                MessageBox.Show("Fisier salvat");
            }
        
        }
    }
}
