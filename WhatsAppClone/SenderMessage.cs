namespace WhatsAppClone;

public partial class SenderMessage : UserControl
{
    public SenderMessage(string message, string time)
    {
        InitializeComponent();
        this.messageLabel.Text = message;
        this.TimeLabel.Text = time;
        this.BackColor = Color.LightGreen;
    }

    private void label2_Click(object sender, EventArgs e)
    {
        
    }
}