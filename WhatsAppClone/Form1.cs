using MySql.Data.MySqlClient;
using WebMatrix.Data;

namespace WhatsAppClone;

public partial class Form1 : Form
{
    private bool bPasswordVisible = false;
    
    private readonly Image eyeOpen = Image.FromFile(Path.Combine(Application.StartupPath, "Icons", "icons8-eye-80.png"));
    private readonly Image eyeClosed = Image.FromFile(Path.Combine(Application.StartupPath, "Icons", "icons8-invisible-80.png"));
    
    public Form1()
    {
        InitializeComponent();
        passwordVisibleEyeIMG.Image = bPasswordVisible ? eyeOpen : eyeClosed;

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        bPasswordVisible = !bPasswordVisible;
        if (passwordTB.ForeColor != Color.Gray)
        {
            passwordTB.PasswordChar = bPasswordVisible ? '\0' : '*';
        }
        
        passwordVisibleEyeIMG.Image = bPasswordVisible ? eyeOpen : eyeClosed;
        
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

    private void passwordTB_Enter(object sender, EventArgs e)
    {
        if(passwordTB.Text == "Password" && passwordTB.ForeColor == Color.Gray)
        {
            passwordTB.Text = "";
            passwordTB.ForeColor = Color.Black;
            if(!bPasswordVisible)
            {
                passwordTB.PasswordChar = '*';
            }
        }
    }

    private void passwordTB_Leave(object sender, EventArgs e)
    {
        if(passwordTB.Text == "")
        {
            passwordTB.Text = "Password";
            passwordTB.ForeColor = Color.Gray;
            passwordTB.PasswordChar = '\0';
        }
    }

    private void signUpBTN_Click(object sender, EventArgs e)
    {
        Registration rForm = new Registration();
        rForm.FormClosing += delegate { this.Show(); };
        this.Hide();
        rForm.Show();
    }

    private void signInBTN_Click(object sender, EventArgs e)
    {
        if (emailTB.ForeColor != Color.Gray || passwordTB.ForeColor != Color.Gray)
        {
            DatabaseConnection connection = new DatabaseConnection();
            MySqlCommand cmd = connection.con.CreateCommand();
        
            cmd.CommandText = "SELECT * FROM users WHERE email = @email AND password = @password";
            cmd.Parameters.AddWithValue("@email", emailTB.Text);
            cmd.Parameters.AddWithValue("@password", passwordTB.Text);
            
            connection.con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                string email = (string)reader[0];
                string name = (string)reader[1];
                string password = (string)reader[2];
                byte[]? image = null;
                if ((byte[]?)reader[3] != null)
                {
                    image = (byte[])reader[3];
                }
                reader.Close();
                cmd.CommandText = $"update users set lastseen='online' where email='{emailTB.Text}'";
                cmd.ExecuteNonQuery();
                
                connection.con.Close();
                MainForm mainForm = new MainForm(name, image, email);
                mainForm.Show();
                this.Hide();
            }
            
            /*
            try
            {
                
                int rows = (int)cmd.ExecuteScalar();
                if (rows == 1)
                {
                    MessageBox.Show("Login successful!");
                }
                else
                {
                    MessageBox.Show("Invalid email or password!");
                }
                connection.con.Close();

            }
            catch(Exception ex)
            {
            
            }
            */
        }

        
        
    }
}