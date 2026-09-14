namespace WhatsAppClone;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        passwordVisibleEyeIMG = new System.Windows.Forms.PictureBox();
        emailTB = new System.Windows.Forms.TextBox();
        passwordTB = new System.Windows.Forms.TextBox();
        signInBTN = new System.Windows.Forms.Button();
        signUpBTN = new System.Windows.Forms.Button();
        panel1 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        ((System.ComponentModel.ISupportInitialize)passwordVisibleEyeIMG).BeginInit();
        SuspendLayout();
        // 
        // passwordVisibleEyeIMG
        // 
        passwordVisibleEyeIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
        passwordVisibleEyeIMG.Image = ((System.Drawing.Image)resources.GetObject("passwordVisibleEyeIMG.Image"));
        passwordVisibleEyeIMG.Location = new System.Drawing.Point(321, 179);
        passwordVisibleEyeIMG.Name = "passwordVisibleEyeIMG";
        passwordVisibleEyeIMG.Size = new System.Drawing.Size(62, 43);
        passwordVisibleEyeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        passwordVisibleEyeIMG.TabIndex = 2;
        passwordVisibleEyeIMG.TabStop = false;
        passwordVisibleEyeIMG.Click += pictureBox1_Click;
        // 
        // emailTB
        // 
        emailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        emailTB.Font = new System.Drawing.Font("Segoe UI", 24F);
        emailTB.ForeColor = System.Drawing.Color.Gray;
        emailTB.Location = new System.Drawing.Point(84, 99);
        emailTB.Name = "emailTB";
        emailTB.Size = new System.Drawing.Size(210, 43);
        emailTB.TabIndex = 3;
        emailTB.Text = "Email";
        emailTB.Enter += emailTB_Enter;
        emailTB.Leave += emailTB_Leave;
        // 
        // passwordTB
        // 
        passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        passwordTB.Font = new System.Drawing.Font("Segoe UI", 24F);
        passwordTB.ForeColor = System.Drawing.Color.Gray;
        passwordTB.Location = new System.Drawing.Point(84, 179);
        passwordTB.Name = "passwordTB";
        passwordTB.Size = new System.Drawing.Size(210, 43);
        passwordTB.TabIndex = 4;
        passwordTB.Text = "Password";
        passwordTB.Enter += passwordTB_Enter;
        passwordTB.Leave += passwordTB_Leave;
        // 
        // signInBTN
        // 
        signInBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
        signInBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
        signInBTN.FlatStyle = System.Windows.Forms.FlatStyle.System;
        signInBTN.Location = new System.Drawing.Point(84, 289);
        signInBTN.Name = "signInBTN";
        signInBTN.Size = new System.Drawing.Size(116, 56);
        signInBTN.TabIndex = 5;
        signInBTN.Text = "Sign In";
        signInBTN.UseVisualStyleBackColor = true;
        signInBTN.Click += signInBTN_Click;
        // 
        // signUpBTN
        // 
        signUpBTN.Location = new System.Drawing.Point(224, 289);
        signUpBTN.Name = "signUpBTN";
        signUpBTN.Size = new System.Drawing.Size(116, 56);
        signUpBTN.TabIndex = 6;
        signUpBTN.Text = "Sign Up";
        signUpBTN.UseVisualStyleBackColor = true;
        signUpBTN.Click += signUpBTN_Click;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.DimGray;
        panel1.Location = new System.Drawing.Point(84, 140);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(210, 2);
        panel1.TabIndex = 7;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.DimGray;
        panel2.Location = new System.Drawing.Point(84, 220);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(210, 2);
        panel2.TabIndex = 8;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.ControlLightLight;
        ClientSize = new System.Drawing.Size(404, 451);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(signUpBTN);
        Controls.Add(signInBTN);
        Controls.Add(passwordTB);
        Controls.Add(emailTB);
        Controls.Add(passwordVisibleEyeIMG);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)passwordVisibleEyeIMG).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox passwordTB;
    private System.Windows.Forms.Button signInBTN;
    private System.Windows.Forms.Button signUpBTN;

    private System.Windows.Forms.TextBox emailTB;

    private System.Windows.Forms.PictureBox passwordVisibleEyeIMG;

    #endregion
}