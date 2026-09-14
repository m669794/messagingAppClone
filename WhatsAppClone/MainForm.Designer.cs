using System.ComponentModel;

namespace WhatsAppClone;

partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        panel1 = new System.Windows.Forms.Panel();
        closePB = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        circularPB3 = new WhatsAppClone.CircularPB();
        loggedinNameLabel = new System.Windows.Forms.Label();
        loggedinDpPB = new WhatsAppClone.CircularPB();
        panel3 = new System.Windows.Forms.Panel();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        circularPB2 = new WhatsAppClone.CircularPB();
        UserCardsFP = new System.Windows.Forms.FlowLayoutPanel();
        flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)closePB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)circularPB3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)loggedinDpPB).BeginInit();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)circularPB2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panel1.BackColor = System.Drawing.Color.Green;
        panel1.Controls.Add(closePB);
        panel1.Controls.Add(pictureBox2);
        panel1.Location = new System.Drawing.Point(-18, -41);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(839, 91);
        panel1.TabIndex = 0;
        // 
        // closePB
        // 
        closePB.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        closePB.Location = new System.Drawing.Point(773, 41);
        closePB.Name = "closePB";
        closePB.Size = new System.Drawing.Size(45, 45);
        closePB.TabIndex = 0;
        closePB.TabStop = false;
        closePB.Click += closePB_Click;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new System.Drawing.Point(773, 43);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(45, 45);
        pictureBox2.TabIndex = 0;
        pictureBox2.TabStop = false;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.WhiteSmoke;
        panel2.Controls.Add(circularPB3);
        panel2.Controls.Add(loggedinNameLabel);
        panel2.Controls.Add(loggedinDpPB);
        panel2.Location = new System.Drawing.Point(1, 46);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(326, 51);
        panel2.TabIndex = 1;
        // 
        // circularPB3
        // 
        circularPB3.BackgroundImage = ((System.Drawing.Image)resources.GetObject("circularPB3.BackgroundImage"));
        circularPB3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        circularPB3.Location = new System.Drawing.Point(272, 10);
        circularPB3.Name = "circularPB3";
        circularPB3.Size = new System.Drawing.Size(30, 30);
        circularPB3.TabIndex = 2;
        circularPB3.TabStop = false;
        // 
        // loggedinNameLabel
        // 
        loggedinNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        loggedinNameLabel.Location = new System.Drawing.Point(54, 7);
        loggedinNameLabel.Name = "loggedinNameLabel";
        loggedinNameLabel.Size = new System.Drawing.Size(83, 33);
        loggedinNameLabel.TabIndex = 1;
        loggedinNameLabel.Text = "label1";
        // 
        // loggedinDpPB
        // 
        loggedinDpPB.BackgroundImage = ((System.Drawing.Image)resources.GetObject("loggedinDpPB.BackgroundImage"));
        loggedinDpPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        loggedinDpPB.Location = new System.Drawing.Point(3, 3);
        loggedinDpPB.Name = "loggedinDpPB";
        loggedinDpPB.Size = new System.Drawing.Size(45, 45);
        loggedinDpPB.TabIndex = 0;
        loggedinDpPB.TabStop = false;
        // 
        // panel3
        // 
        panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panel3.BackColor = System.Drawing.Color.WhiteSmoke;
        panel3.Controls.Add(label1);
        panel3.Controls.Add(label2);
        panel3.Controls.Add(circularPB2);
        panel3.Location = new System.Drawing.Point(323, 46);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(477, 51);
        panel3.TabIndex = 2;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        label1.Location = new System.Drawing.Point(54, 33);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(120, 18);
        label1.TabIndex = 3;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(54, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(74, 33);
        label2.TabIndex = 2;
        label2.Text = "label2";
        // 
        // circularPB2
        // 
        circularPB2.BackgroundImage = ((System.Drawing.Image)resources.GetObject("circularPB2.BackgroundImage"));
        circularPB2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        circularPB2.Location = new System.Drawing.Point(3, 3);
        circularPB2.Name = "circularPB2";
        circularPB2.Size = new System.Drawing.Size(45, 45);
        circularPB2.TabIndex = 1;
        circularPB2.TabStop = false;
        // 
        // UserCardsFP
        // 
        UserCardsFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        UserCardsFP.BackColor = System.Drawing.Color.WhiteSmoke;
        UserCardsFP.Location = new System.Drawing.Point(1, 95);
        UserCardsFP.Name = "UserCardsFP";
        UserCardsFP.Size = new System.Drawing.Size(323, 355);
        UserCardsFP.TabIndex = 3;
        // 
        // flowLayoutPanel2
        // 
        flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        flowLayoutPanel2.BackColor = System.Drawing.Color.LightCoral;
        flowLayoutPanel2.BackgroundImage = ((System.Drawing.Image)resources.GetObject("flowLayoutPanel2.BackgroundImage"));
        flowLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        flowLayoutPanel2.Location = new System.Drawing.Point(323, 95);
        flowLayoutPanel2.Name = "flowLayoutPanel2";
        flowLayoutPanel2.Size = new System.Drawing.Size(477, 315);
        flowLayoutPanel2.TabIndex = 4;
        // 
        // richTextBox1
        // 
        richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        richTextBox1.Location = new System.Drawing.Point(323, 408);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(402, 41);
        richTextBox1.TabIndex = 5;
        richTextBox1.Text = "";
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        pictureBox1.Location = new System.Drawing.Point(725, 408);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(74, 40);
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        ControlBox = false;
        Controls.Add(pictureBox1);
        Controls.Add(richTextBox1);
        Controls.Add(flowLayoutPanel2);
        Controls.Add(UserCardsFP);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Text = "MainForm";
        Load += MainForm_Load;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)closePB).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)circularPB3).EndInit();
        ((System.ComponentModel.ISupportInitialize)loggedinDpPB).EndInit();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)circularPB2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox closePB;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Label label1;

    private WhatsAppClone.CircularPB circularPB3;

    private System.Windows.Forms.Label label2;

    private WhatsAppClone.CircularPB circularPB2;
    private System.Windows.Forms.Label loggedinNameLabel;

    private WhatsAppClone.CircularPB loggedinDpPB;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

    private System.Windows.Forms.FlowLayoutPanel UserCardsFP;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    #endregion
}