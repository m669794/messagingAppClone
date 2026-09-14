
using MySql.Data.MySqlClient;

namespace WhatsAppClone;

public partial class MainForm : Form
{
    private string loggedinName;
    private string loggedinEmail;
    private byte[]? loggedinPB;
    
    public MainForm(string name, byte[]? image, string email)
    {
        InitializeComponent();

        this.loggedinName = name;
        this.loggedinPB = image;
        this.loggedinEmail = email;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        loggedinNameLabel.Text = loggedinName;
        if (loggedinPB != null)
        {
            ImageConverter converter = new ImageConverter();
            loggedinDpPB.BackgroundImage = (Image)converter.ConvertFrom(loggedinPB);
        }
        
    }

    private void closePB_Click(object sender, EventArgs e)
    {
        DatabaseConnection connection = new DatabaseConnection();
        connection.con.Open();
        MySqlCommand cmd;
        cmd = connection.con.CreateCommand();

        cmd.CommandText = "update users set lastseen=@current where email=@loggedinemail";
        cmd.Parameters.AddWithValue("@loggedinemail", loggedinEmail);
        cmd.Parameters.AddWithValue("@current", DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
        cmd.ExecuteNonQuery();
        connection.con.Close();
        this.Close();
    }
}