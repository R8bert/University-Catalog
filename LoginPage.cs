using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;


namespace Aplicatie
{
    public partial class LoginPage : Form
    {
        //string connectionString = "datasource=127.0.0.1;port=3306;database=catalog;user=root;password=";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enterUsername = enteredUsername.Text;
            string enterPassword = enteredPassword.Text;

            //string connectionString = "your_connection_string_here"; // Înlocuiți cu detaliile corespunzătoare ale conexiunii la baza de date



            using (MySqlConnection connection = new MySqlConnection(Global.connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM utilizatori WHERE NumeUtilizator = @username AND ParolaUtilizator = @password";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", enterUsername);
                    command.Parameters.AddWithValue("@password", enterPassword);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        // Autentificare reușită
                        MessageBox.Show("Autentificare reușită!");
                        FirstPage afterLogin = new FirstPage();
                        afterLogin.Show();
                        this.Hide();
                        //this.Close();
                    }
                    else
                    {
                        // Autentificare eșuată
                        MessageBox.Show("Autentificare eșuată!");

                    }
                }
                catch (Exception ex)
                {
                    // Tratarea erorilor
                    MessageBox.Show("A apărut o eroare: " + ex.Message);
                }
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void enteredPassword_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
public static class Global
{
    public const string connectionString = "server=www.db4free.net;port=3306;database=catalog;user=proiectpoo;password=proiectpoo;";

}