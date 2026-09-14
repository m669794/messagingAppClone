using System.ComponentModel;

namespace WhatsAppClone;

partial class Registration
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
        nameTB = new System.Windows.Forms.TextBox();
        emailTB = new System.Windows.Forms.TextBox();
        password1TB = new System.Windows.Forms.TextBox();
        password2TB = new System.Windows.Forms.TextBox();
        panel1 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        panel3 = new System.Windows.Forms.Panel();
        panel4 = new System.Windows.Forms.Panel();
        signUpBTN = new System.Windows.Forms.Button();
        password1VisibleEyeIMG = new System.Windows.Forms.PictureBox();
        password2VisibleEyeIMG = new System.Windows.Forms.PictureBox();
        progressBar1 = new System.Windows.Forms.ProgressBar();
        dpPB = new WhatsAppClone.CircularPB();
        SelectDpPb = new WhatsAppClone.CircularPB();
        ((System.ComponentModel.ISupportInitialize)password1VisibleEyeIMG).BeginInit();
        ((System.ComponentModel.ISupportInitialize)password2VisibleEyeIMG).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dpPB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)SelectDpPb).BeginInit();
        SuspendLayout();
        // 
        // nameTB
        // 
        nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        nameTB.Font = new System.Drawing.Font("Segoe UI", 24F);
        nameTB.ForeColor = System.Drawing.Color.Gray;
        nameTB.Location = new System.Drawing.Point(24, 142);
        nameTB.Name = "nameTB";
        nameTB.Size = new System.Drawing.Size(293, 43);
        nameTB.TabIndex = 0;
        nameTB.Text = "Name";
        nameTB.Enter += nameTB_Enter;
        nameTB.Leave += nameTB_Leave;
        // 
        // emailTB
        // 
        emailTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        emailTB.Font = new System.Drawing.Font("Segoe UI", 24F);
        emailTB.ForeColor = System.Drawing.Color.Gray;
        emailTB.Location = new System.Drawing.Point(24, 198);
        emailTB.Name = "emailTB";
        emailTB.Size = new System.Drawing.Size(293, 43);
        emailTB.TabIndex = 1;
        emailTB.Text = "Email";
        emailTB.Enter += emailTB_Enter;
        emailTB.Leave += emailTB_Leave;
        // 
        // password1TB
        // 
        password1TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        password1TB.Font = new System.Drawing.Font("Segoe UI", 24F);
        password1TB.ForeColor = System.Drawing.Color.Gray;
        password1TB.Location = new System.Drawing.Point(24, 254);
        password1TB.Name = "password1TB";
        password1TB.Size = new System.Drawing.Size(293, 43);
        password1TB.TabIndex = 2;
        password1TB.Text = "Password";
        password1TB.Enter += password1TB_Enter;
        password1TB.Leave += password1TB_Leave;
        // 
        // password2TB
        // 
        password2TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        password2TB.Font = new System.Drawing.Font("Segoe UI", 24F);
        password2TB.ForeColor = System.Drawing.Color.Gray;
        password2TB.Location = new System.Drawing.Point(24, 310);
        password2TB.Name = "password2TB";
        password2TB.Size = new System.Drawing.Size(293, 43);
        password2TB.TabIndex = 3;
        password2TB.Text = "Repeat Password";
        password2TB.Enter += password2TB_Enter;
        password2TB.Leave += password2TB_Leave;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.DimGray;
        panel1.Location = new System.Drawing.Point(24, 351);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(292, 2);
        panel1.TabIndex = 4;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.DimGray;
        panel2.Location = new System.Drawing.Point(25, 295);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(292, 2);
        panel2.TabIndex = 5;
        // 
        // panel3
        // 
        panel3.BackColor = System.Drawing.Color.DimGray;
        panel3.Location = new System.Drawing.Point(24, 239);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(292, 2);
        panel3.TabIndex = 6;
        // 
        // panel4
        // 
        panel4.BackColor = System.Drawing.Color.DimGray;
        panel4.Location = new System.Drawing.Point(24, 183);
        panel4.Name = "panel4";
        panel4.Size = new System.Drawing.Size(292, 2);
        panel4.TabIndex = 7;
        // 
        // signUpBTN
        // 
        signUpBTN.Font = new System.Drawing.Font("Segoe UI", 24F);
        signUpBTN.Location = new System.Drawing.Point(123, 359);
        signUpBTN.Name = "signUpBTN";
        signUpBTN.Size = new System.Drawing.Size(145, 62);
        signUpBTN.TabIndex = 8;
        signUpBTN.Text = "Sign Up";
        signUpBTN.UseVisualStyleBackColor = true;
        signUpBTN.Click += signUpBTN_Click;
        // 
        // password1VisibleEyeIMG
        // 
        password1VisibleEyeIMG.Location = new System.Drawing.Point(323, 247);
        password1VisibleEyeIMG.Name = "password1VisibleEyeIMG";
        password1VisibleEyeIMG.Size = new System.Drawing.Size(65, 50);
        password1VisibleEyeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        password1VisibleEyeIMG.TabIndex = 9;
        password1VisibleEyeIMG.TabStop = false;
        password1VisibleEyeIMG.Click += password1VisibleEyeIMG_Click;
        // 
        // password2VisibleEyeIMG
        // 
        password2VisibleEyeIMG.Location = new System.Drawing.Point(323, 303);
        password2VisibleEyeIMG.Name = "password2VisibleEyeIMG";
        password2VisibleEyeIMG.Size = new System.Drawing.Size(65, 50);
        password2VisibleEyeIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        password2VisibleEyeIMG.TabIndex = 10;
        password2VisibleEyeIMG.TabStop = false;
        password2VisibleEyeIMG.Click += password2VisibleEyeIMG_Click;
        // 
        // progressBar1
        // 
        progressBar1.Location = new System.Drawing.Point(36, 427);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new System.Drawing.Size(340, 12);
        progressBar1.TabIndex = 11;
        // 
        // dpPB
        // 
        dpPB.Location = new System.Drawing.Point(138, 12);
        dpPB.Name = "dpPB";
        dpPB.Size = new System.Drawing.Size(120, 120);
        dpPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        dpPB.TabIndex = 12;
        dpPB.TabStop = false;
        // 
        // SelectDpPb
        // 
        SelectDpPb.Image = ((System.Drawing.Image)resources.GetObject("SelectDpPb.Image"));
        SelectDpPb.Location = new System.Drawing.Point(228, 96);
        SelectDpPb.Name = "SelectDpPb";
        SelectDpPb.Size = new System.Drawing.Size(40, 40);
        SelectDpPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        SelectDpPb.TabIndex = 13;
        SelectDpPb.TabStop = false;
        SelectDpPb.Click += SelectDpPb_Click;
        // 
        // Registration
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.White;
        ClientSize = new System.Drawing.Size(404, 451);
        Controls.Add(SelectDpPb);
        Controls.Add(dpPB);
        Controls.Add(progressBar1);
        Controls.Add(password2VisibleEyeIMG);
        Controls.Add(password1VisibleEyeIMG);
        Controls.Add(signUpBTN);
        Controls.Add(panel4);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(password2TB);
        Controls.Add(password1TB);
        Controls.Add(emailTB);
        Controls.Add(nameTB);
        Text = "Registration";
        Load += Registration_Load;
        ((System.ComponentModel.ISupportInitialize)password1VisibleEyeIMG).EndInit();
        ((System.ComponentModel.ISupportInitialize)password2VisibleEyeIMG).EndInit();
        ((System.ComponentModel.ISupportInitialize)dpPB).EndInit();
        ((System.ComponentModel.ISupportInitialize)SelectDpPb).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private WhatsAppClone.CircularPB SelectDpPb;

    private WhatsAppClone.CircularPB dpPB;

    private System.Windows.Forms.ProgressBar progressBar1;

    private System.Windows.Forms.PictureBox password1VisibleEyeIMG;

    private System.Windows.Forms.PictureBox password2VisibleEyeIMG;

    private System.Windows.Forms.Button signUpBTN;

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel4;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TextBox nameTB;
    private System.Windows.Forms.TextBox emailTB;
    private System.Windows.Forms.TextBox password1TB;
    private System.Windows.Forms.TextBox password2TB;

    #endregion
}