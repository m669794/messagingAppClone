using MySql.Data.MySqlClient;

namespace WhatsAppClone;

public partial class UserCard : UserControl
{
    private MainForm mform;
    private string loggedinEmail;
    public string currentEmail;
    
    public UserCard()
    {
        InitializeComponent();
    }

    private void UserCard_Load(object sender, EventArgs e)
    {
        
    }

    public UserCard(byte[] currentdp, string currentName, MainForm mform, string currentEmail, string loggedinEmail)
    {
        InitializeComponent();
        this.userNameLabel.Text = currentName;
        ImageConverter converter = new ImageConverter();
        this.userDpPb.BackgroundImage = (Image)converter.ConvertFrom(currentdp);
        this.mform = mform;
        this.currentEmail = currentEmail;
        //this.mform.currentEmail = this.currentEmail;
        this.loggedinEmail = loggedinEmail;
    }

    private void UserCard_Click(object sender, EventArgs e)
    {
        mform.currentUserDpPb.BackgroundImage = this.userDpPb.BackgroundImage;
        mform.currentUserNameLabel.Text = this.userNameLabel.Text;
        mform.currentEmail = this.currentEmail;
        
        DatabaseConnection connection = new DatabaseConnection();
        connection.con.Open();
        MySqlCommand cmd;
        cmd = connection.con.CreateCommand();
        
        cmd.CommandText = "Select lastseen from users where email = @email";
        cmd.Parameters.AddWithValue("@email", currentEmail);
        
        MySqlDataReader reader = cmd.ExecuteReader();

        reader.Read();
        try
        {
            mform.currentUserLastSeenLabel.Text = (string)reader[0];
        }
        catch (Exception ex)
        {
            
        }
        reader.Close();
        cmd.CommandText = "select * from messages where sender=@loggedinuser and reciever=@currentuser or sender=@currentuser and reciever=@loggedinuser";
        cmd.Parameters.AddWithValue("@loggedinuser", loggedinEmail);
        cmd.Parameters.AddWithValue("@currentuser", currentEmail);
        
        reader = cmd.ExecuteReader();
        mform.messagesFP.Controls.Clear();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                string senderEmail = (string)reader[0];
                DateTime time = new DateTime();
                time = Convert.ToDateTime((string)reader[3]);
                if (senderEmail == loggedinEmail)
                {
                    mform.AddSenderMessage((string)reader[2], time.ToString("HH:mm"));
                }
                else
                {
                    mform.AddReceiverMessage((string)reader[2], time.ToString("HH:mm"));
                }
            }
            reader.Close();
            
            //cmd.CommandText = "update messages set status='read' where sender=@currentuser and reciever=@loggedinuser";
            //cmd.ExecuteNonQuery();
        }
        else
        {
            reader.Close();
        }
        connection.con.Close();
    }

    private void lastMessageLBL_Click(object sender, EventArgs e)
    {
        UserCard_Click(sender, e);
    }

    private void userNameLabel_Click(object sender, EventArgs e)
    {
        UserCard_Click(sender, e);
    }

    private void userDpPb_Click(object sender, EventArgs e)
    {
        UserCard_Click(sender, e);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        UserCard_Click(sender, e);
    }

    private void newMessagesCountLBL_Click(object sender, EventArgs e)
    {
        UserCard_Click(sender, e);
    }
}