using System.ComponentModel;

namespace WhatsAppClone;

partial class UserCard
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        userDpPb = new WhatsAppClone.CircularPB();
        userNameLabel = new System.Windows.Forms.Label();
        lastMessageLBL = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        newMessagesCountLBL = new WhatsAppClone.CircularLabel();
        ((System.ComponentModel.ISupportInitialize)userDpPb).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // userDpPb
        // 
        userDpPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        userDpPb.Location = new System.Drawing.Point(0, 0);
        userDpPb.Name = "userDpPb";
        userDpPb.Size = new System.Drawing.Size(55, 55);
        userDpPb.TabIndex = 0;
        userDpPb.TabStop = false;
        userDpPb.Click += userDpPb_Click;
        // 
        // userNameLabel
        // 
        userNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        userNameLabel.Location = new System.Drawing.Point(61, 0);
        userNameLabel.Name = "userNameLabel";
        userNameLabel.Size = new System.Drawing.Size(73, 29);
        userNameLabel.TabIndex = 1;
        userNameLabel.Text = "label1";
        userNameLabel.Click += userNameLabel_Click;
        // 
        // lastMessageLBL
        // 
        lastMessageLBL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lastMessageLBL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        lastMessageLBL.Location = new System.Drawing.Point(100, 32);
        lastMessageLBL.Name = "lastMessageLBL";
        lastMessageLBL.Size = new System.Drawing.Size(167, 29);
        lastMessageLBL.TabIndex = 2;
        lastMessageLBL.Text = "label2";
        lastMessageLBL.Visible = false;
        lastMessageLBL.Click += lastMessageLBL_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(71, 32);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(23, 22);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // newMessagesCountLBL
        // 
        newMessagesCountLBL.BackColor = System.Drawing.Color.LawnGreen;
        newMessagesCountLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        newMessagesCountLBL.Location = new System.Drawing.Point(289, 15);
        newMessagesCountLBL.Name = "newMessagesCountLBL";
        newMessagesCountLBL.Size = new System.Drawing.Size(18, 24);
        newMessagesCountLBL.TabIndex = 5;
        newMessagesCountLBL.Text = "1";
        newMessagesCountLBL.Visible = false;
        newMessagesCountLBL.Click += newMessagesCountLBL_Click;
        // 
        // UserCard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(newMessagesCountLBL);
        Controls.Add(pictureBox1);
        Controls.Add(lastMessageLBL);
        Controls.Add(userNameLabel);
        Controls.Add(userDpPb);
        Size = new System.Drawing.Size(323, 55);
        Load += UserCard_Load;
        Click += UserCard_Click;
        ((System.ComponentModel.ISupportInitialize)userDpPb).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    

    private System.Windows.Forms.PictureBox pictureBox1;
    
    public WhatsAppClone.CircularLabel newMessagesCountLBL;
    public System.Windows.Forms.Label userNameLabel;
    public System.Windows.Forms.Label lastMessageLBL;

    private WhatsAppClone.CircularPB userDpPb;

    #endregion
}