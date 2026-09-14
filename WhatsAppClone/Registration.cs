using MySql.Data.MySqlClient;

namespace WhatsAppClone;

public partial class Registration : Form
{
    private bool _bPassword1Visible = false;
    private bool _bPassword2Visible = false;
    
    private readonly Image _eyeOpen = Image.FromFile(Path.Combine(Application.StartupPath, "Icons", "icons8-eye-80.png"));
    private readonly Image _eyeClosed = Image.FromFile(Path.Combine(Application.StartupPath, "Icons", "icons8-invisible-80.png"));
    private readonly Image _userImg = Image.FromFile(Path.Combine(Application.StartupPath, "Icons", "icons8-user-100.png"));
    
    public Registration()
    {
        InitializeComponent();
        password1VisibleEyeIMG.Image = _bPassword1Visible ? _eyeOpen : _eyeClosed;
        password2VisibleEyeIMG.Image = _bPassword2Visible ? _eyeOpen : _eyeClosed;
        dpPB.Image = _userImg;
    }

    private void nameTB_Enter(object sender, EventArgs e)
    {
        if(nameTB.Text == "Name" && nameTB.ForeColor == Color.Gray)
        {
            nameTB.Text = "";
            nameTB.ForeColor = Color.Black;
        }
    }

    private void nameTB_Leave(object sender, EventArgs e)
    {
        if(nameTB.Text == "")
        {
            nameTB.Text = "Name";
            nameTB.ForeColor = Color.Gray;
        }
    }

    private void emailTB_Enter(object sender, EventArgs e)
    {
        if(emailTB.Text == "Email" && emailTB.ForeColor == Color.Gray)
        {
            emailTB.Text = "";
            emailTB.ForeColor = Color.Black;
        }
    }

    private void emailTB_Leave(object sender, EventArgs e)
    {
        if(emailTB.Text == "")
        {
            emailTB.Text = "Email";
            emailTB.ForeColor = Color.Gray;
        }
    }

    private void password1TB_Enter(object sender, EventArgs e)
    {
        if(password1TB.Text == "Password" && password1TB.ForeColor == Color.Gray)
        {
            password1TB.Text = "";
            password1TB.ForeColor = Color.Black;
            if(!_bPassword1Visible)
            {
                password1TB.PasswordChar = '*';
            }
        }
    }

    private void password1TB_Leave(object sender, EventArgs e)
    {
        if(password1TB.Text == "")
        {
            password1TB.Text = "Password";
            password1TB.ForeColor = Color.Gray;
            password1TB.PasswordChar = '\0';
        }
    }

    private void password2TB_Enter(object sender, EventArgs e)
    {
        if(password2TB.Text == "Repeat Password" && password2TB.ForeColor == Color.Gray)
        {
            password2TB.Text = "";
            password2TB.ForeColor = Color.Black;
            if(!_bPassword2Visible)
            {
                password2TB.PasswordChar = '*';
            }
        }
    }

    private void password2TB_Leave(object sender, EventArgs e)
    {
        if(password2TB.Text == "")
        {
            password2TB.Text = "Repeat Password";
            password2TB.ForeColor = Color.Gray;
            password2TB.PasswordChar = '\0';
        }
    }

    private void password1VisibleEyeIMG_Click(object sender, EventArgs e)
    {
        _bPassword1Visible = !_bPassword1Visible;
        if (password1TB.ForeColor != Color.Gray)
        {
            password1TB.PasswordChar = _bPassword1Visible ? '\0' : '*';
        }
        
        password1VisibleEyeIMG.Image = _bPassword1Visible ? _eyeOpen : _eyeClosed;
    }

    private void password2VisibleEyeIMG_Click(object sender, EventArgs e)
    {
        _bPassword2Visible = !_bPassword2Visible;
        if (password2TB.ForeColor != Color.Gray)
        {
            password2TB.PasswordChar = _bPassword2Visible ? '\0' : '*';
        }
        
        password2VisibleEyeIMG.Image = _bPassword2Visible ? _eyeOpen : _eyeClosed;
    }

    private void signUpBTN_Click(object sender, EventArgs e)
    {
        if(nameTB.Text == "" || nameTB.ForeColor == Color.Gray)
        {
            MessageBox.Show("Name cannot be empty");
            return;
        }
        
        if(emailTB.Text == "" || emailTB.ForeColor == Color.Gray)
        {
            MessageBox.Show("Email cannot be empty");
            return;
        }
        
        if(password1TB.Text == "" || password1TB.ForeColor == Color.Gray)
        {
            MessageBox.Show("Password cannot be empty");
            return;
        }
        
        if(password1TB.Text != password2TB.Text)
        {
            MessageBox.Show("Passwords do not match");
            return;
        }
        
        progressBar1.Value = 20;
        
        DatabaseConnection connection = new DatabaseConnection();
        MySqlCommand cmd = connection.con.CreateCommand();
        
        progressBar1.Value = 40;
        
        cmd.CommandText = "insert into users values(@email,@name,@password, @dp, @lastseen)";
        cmd.Parameters.AddWithValue("@email", emailTB.Text);
        cmd.Parameters.AddWithValue("@name", nameTB.Text);
        cmd.Parameters.AddWithValue("@password", password1TB.Text);
        progressBar1.Value = 60;

        byte[] image;
        ImageConverter converter = new ImageConverter();
        if (dpPB.Image != null)
        {
            image = (byte[])converter.ConvertTo(dpPB.Image, typeof(byte[]));
        }
        else
        {
            image = null;
        }
        
        cmd.Parameters.AddWithValue("@dp", image);
        cmd.Parameters.AddWithValue("@lastseen", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        
        try
        {
            connection.con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            connection.con.Close();
            progressBar1.Value = 100;
            if(rowAffected > 0)
            {
                MessageBox.Show("User registered successfully");
            }
        }
        catch(Exception ex)
        {
            //MessageBox.Show("Error: User with this email already exists");
            MessageBox.Show("Error: " + ex.Message);
            progressBar1.Value = 0;
        }
    }

    private void Registration_Load(object sender, EventArgs e)
    {
        progressBar1.Value = 0;
    }

    private void SelectDpPb_Click(object sender, EventArgs e)
    {
        OpenFileDialog open = new OpenFileDialog();
        open.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
        if(open.ShowDialog() == DialogResult.OK)
        {
            dpPB.Image = new Bitmap(open.FileName);
        }
    }
}