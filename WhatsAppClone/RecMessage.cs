namespace WhatsAppClone;

public partial class RecMessage : UserControl
{
    public RecMessage(string message, string time)
    {
        InitializeComponent();
        this.messageLabel.Text = message;
        this.TimeLabel.Text = time;
        this.BackColor = Color.LightGray;
    }
}