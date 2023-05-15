using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Aplicatie
{
    public static class BazaDate
    {
    public static SqlConnection GetConnection()
    {
        string connectionString = "server=www.db4free.net;database=catalog;user=proiectpoo;password=proiectpoo;";
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        return connection;
    }

}
}
