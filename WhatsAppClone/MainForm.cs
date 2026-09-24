﻿﻿
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WhatsAppClone;

public partial class MainForm : Form
{
    // 1. Import the native Windows libraries
    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    // 2. Define the Windows Message constants
    private const int WM_NCLBUTTONDOWN = 0xA1;
    private const int HT_CAPTION = 0x2;
    
    private string loggedinName;
    private string loggedinEmail;
    public string currentEmail;
    private byte[]? loggedinPB;
    
    public MainForm(string name, byte[]? image, string email)
    {
        InitializeComponent();
        
        // 3. Attach the MouseDown event to your custom panel
        TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;

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
        
        DatabaseConnection connection = new DatabaseConnection();
        connection.con.Open();
        MySqlCommand cmd;
        cmd = connection.con.CreateCommand();
        
        cmd.CommandText = "select * from users where email!=@loggedinemail";
        cmd.Parameters.AddWithValue("@loggedinemail", loggedinEmail);
        
        MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            byte[] currentdp = (byte[])reader[3];
            string currentname = (string)reader[2];
            string currentemail = (string)reader[0];
            
            UserCard currentUser = new UserCard(currentdp, currentname, this, currentemail,loggedinEmail);
            UserCardsFP.Controls.Add(currentUser);
            
        }
        reader.Close();
        foreach (UserCard user in UserCardsFP.Controls)
        {
            reader.Close();
            cmd.CommandText = "select count(*) from messages where reciever=@loggedinemail and sender=@currentemail";
            //cmd.CommandText = "select count(*) from messages where reciever=@loggedinemail and sender=@currentemail and status='NRead'";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@loggedinemail", loggedinEmail);
            cmd.Parameters.AddWithValue("@currentemail", user.currentEmail);
            
            
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                if ((Int64)reader[0] != 0)
                {
                    user.newMessagesCountLBL.Text = reader[0].ToString();
                    user.newMessagesCountLBL.Visible = true;
                }
                
            }
            reader.Close();
            
            cmd.CommandText = "select message from messages where reciever=@loggedinemail and sender=@currentemail or reciever=@currentemail and sender=@loggedinemail order by sendingtime desc limit 1";
            reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                user.lastMessageLBL.Text = reader[0].ToString();
                user.lastMessageLBL.Visible = true;
            }
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@loggedinemail", loggedinEmail);
            cmd.Parameters.AddWithValue("@currentemail", user.currentEmail);
        }

        connection.con.Close();
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
        Application.Exit();
    }

    private void sendPB_Click(object sender, EventArgs e)
    {
        string messageText = messageRTB.Text.Trim();
        if (string.IsNullOrEmpty(messageText) || string.IsNullOrEmpty(currentEmail))
            return;

        DateTime timestamp = DateTime.Now;
        string formattedTime = timestamp.ToString("yyyy-MM-dd HH:mm:ss");

        try
        {
            DatabaseConnection connection = new DatabaseConnection();
            using (connection.con)
            {
                connection.con.Open();
                using (MySqlCommand cmd = connection.con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO messages (sender, reciever, message, sendingtime) " +
                                      "VALUES (@loggedinemail, @currentemail, @message, @datetime)";

                    cmd.Parameters.Add("@loggedinemail", MySqlDbType.VarChar).Value = loggedinEmail;
                    cmd.Parameters.Add("@currentemail", MySqlDbType.VarChar).Value = currentEmail;
                    cmd.Parameters.Add("@message", MySqlDbType.VarChar).Value = messageText;
                    cmd.Parameters.Add("@datetime", MySqlDbType.VarChar).Value = formattedTime;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        AddSenderMessage(messageText, timestamp.ToString("dd/MM/yyyy HH:mm"));
                        messageRTB.Clear();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Log exception and notify the user to prevent silent failure states
            MessageBox.Show("Failed to deliver message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public void AddSenderMessage(string message, string time)
    {
        SenderMessage sm = new SenderMessage(message, time);
        int availableWidth = messagesFP.ClientSize.Width;
        int leftMargin = Math.Max(0, availableWidth - sm.Width - 15);
        sm.Margin = new Padding(leftMargin, 5, 10, 5);
        messagesFP.Controls.Add(sm);
        messagesFP.ScrollControlIntoView(sm);
    }

    public void AddReceiverMessage(string message, string time)
    {
        RecMessage rm = new RecMessage(message, time);
        rm.Margin = new Padding(10, 5, 5, 5);
        messagesFP.Controls.Add(rm);
        messagesFP.ScrollControlIntoView(rm);
    }

    private void messagesFP_SizeChanged(object? sender, EventArgs e)
    {
        AdjustMessagePositions();
    }

    public void AdjustMessagePositions()
    {
        messagesFP.SuspendLayout();
        int availableWidth = messagesFP.ClientSize.Width;
        foreach (Control ctrl in messagesFP.Controls)
        {
            if (ctrl is SenderMessage sm)
            {
                int leftMargin = Math.Max(0, availableWidth - sm.Width - 15);
                sm.Margin = new Padding(leftMargin, 5, 10, 5);
            }
            else if (ctrl is RecMessage rm)
            {
                rm.Margin = new Padding(10, 5, 5, 5);
            }
        }
        messagesFP.ResumeLayout();
    }

    private void RefreshPB_Click(object sender, EventArgs e)
    {
        UserCardsFP.Controls.Clear();
        MainForm_Load(sender,e);
    }

    private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
    {
        // Only drag if it's a left mouse click
        if (e.Button == MouseButtons.Left)
        {
            // Release the mouse capture from the panel
            ReleaseCapture();
                
            // Send a message to Windows telling it that the title bar was clicked
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}