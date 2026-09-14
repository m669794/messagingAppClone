using MySql.Data.MySqlClient;

namespace WhatsAppClone;

public class DatabaseConnection
{
    private string connectionString = "Server=localhost;Database=WhatsApp;Uid=root;Pwd=1234";

    public MySqlConnection con;

    public DatabaseConnection()
    {
        con = new MySqlConnection(connectionString);
    }
}