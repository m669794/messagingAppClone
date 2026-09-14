namespace WhatsAppClone;

public partial class UserCard : UserControl
{
    public UserCard()
    {
        InitializeComponent();
    }

    private void UserCard_Load(object sender, EventArgs e)
    {
        
    }

    public UserCard(byte[] currentdp, string currentName)
    {
        InitializeComponent();
        this.userNameLabel.Text = currentName;
        ImageConverter converter = new ImageConverter();
        this.userDpPb.BackgroundImage = (Image)converter.ConvertFrom(currentdp);
    }
}