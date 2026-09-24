﻿﻿using System.ComponentModel;

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
        TitleBarPanel = new System.Windows.Forms.Panel();
        closePB = new System.Windows.Forms.PictureBox();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        panel2 = new System.Windows.Forms.Panel();
        RefreshPB = new WhatsAppClone.CircularPB();
        loggedinNameLabel = new System.Windows.Forms.Label();
        loggedinDpPB = new WhatsAppClone.CircularPB();
        panel3 = new System.Windows.Forms.Panel();
        currentUserLastSeenLabel = new System.Windows.Forms.Label();
        currentUserNameLabel = new System.Windows.Forms.Label();
        currentUserDpPb = new WhatsAppClone.CircularPB();
        UserCardsFP = new System.Windows.Forms.FlowLayoutPanel();
        messagesFP = new System.Windows.Forms.FlowLayoutPanel();
        messageRTB = new System.Windows.Forms.RichTextBox();
        sendPB = new WhatsAppClone.CircularPB();
        TitleBarPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)closePB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)RefreshPB).BeginInit();
        ((System.ComponentModel.ISupportInitialize)loggedinDpPB).BeginInit();
        panel3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)currentUserDpPb).BeginInit();
        ((System.ComponentModel.ISupportInitialize)sendPB).BeginInit();
        SuspendLayout();
        // 
        // TitleBarPanel
        // 
        TitleBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        TitleBarPanel.BackColor = System.Drawing.Color.Green;
        TitleBarPanel.Controls.Add(closePB);
        TitleBarPanel.Controls.Add(pictureBox2);
        TitleBarPanel.Location = new System.Drawing.Point(-18, -41);
        TitleBarPanel.Name = "TitleBarPanel";
        TitleBarPanel.Size = new System.Drawing.Size(839, 91);
        TitleBarPanel.TabIndex = 0;
        TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
        // 
        // closePB
        // 
        closePB.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        closePB.BackgroundImage = ((System.Drawing.Image)resources.GetObject("closePB.BackgroundImage"));
        closePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
        panel2.Controls.Add(RefreshPB);
        panel2.Controls.Add(loggedinNameLabel);
        panel2.Controls.Add(loggedinDpPB);
        panel2.Location = new System.Drawing.Point(1, 46);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(326, 51);
        panel2.TabIndex = 1;
        // 
        // RefreshPB
        // 
        RefreshPB.BackgroundImage = ((System.Drawing.Image)resources.GetObject("RefreshPB.BackgroundImage"));
        RefreshPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        RefreshPB.Location = new System.Drawing.Point(272, 10);
        RefreshPB.Name = "RefreshPB";
        RefreshPB.Size = new System.Drawing.Size(30, 30);
        RefreshPB.TabIndex = 2;
        RefreshPB.TabStop = false;
        RefreshPB.Click += RefreshPB_Click;
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
        panel3.Controls.Add(currentUserLastSeenLabel);
        panel3.Controls.Add(currentUserNameLabel);
        panel3.Controls.Add(currentUserDpPb);
        panel3.Location = new System.Drawing.Point(323, 46);
        panel3.Name = "panel3";
        panel3.Size = new System.Drawing.Size(477, 51);
        panel3.TabIndex = 2;
        // 
        // currentUserLastSeenLabel
        // 
        currentUserLastSeenLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        currentUserLastSeenLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        currentUserLastSeenLabel.Location = new System.Drawing.Point(54, 33);
        currentUserLastSeenLabel.Name = "currentUserLastSeenLabel";
        currentUserLastSeenLabel.Size = new System.Drawing.Size(120, 18);
        currentUserLastSeenLabel.TabIndex = 3;
        currentUserLastSeenLabel.Text = "label1";
        // 
        // currentUserNameLabel
        // 
        currentUserNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        currentUserNameLabel.Location = new System.Drawing.Point(54, 0);
        currentUserNameLabel.Name = "currentUserNameLabel";
        currentUserNameLabel.Size = new System.Drawing.Size(74, 33);
        currentUserNameLabel.TabIndex = 2;
        currentUserNameLabel.Text = "label2";
        // 
        // currentUserDpPb
        // 
        currentUserDpPb.BackgroundImage = ((System.Drawing.Image)resources.GetObject("currentUserDpPb.BackgroundImage"));
        currentUserDpPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        currentUserDpPb.Location = new System.Drawing.Point(3, 3);
        currentUserDpPb.Name = "currentUserDpPb";
        currentUserDpPb.Size = new System.Drawing.Size(45, 45);
        currentUserDpPb.TabIndex = 1;
        currentUserDpPb.TabStop = false;
        // 
        // UserCardsFP
        // 
        UserCardsFP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left));
        UserCardsFP.AutoScroll = true;
        UserCardsFP.BackColor = System.Drawing.Color.WhiteSmoke;
        UserCardsFP.Location = new System.Drawing.Point(1, 95);
        UserCardsFP.Name = "UserCardsFP";
        UserCardsFP.Size = new System.Drawing.Size(323, 355);
        UserCardsFP.TabIndex = 3;
        // 
        // messagesFP
        // 
        messagesFP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        messagesFP.AutoScroll = true;
        messagesFP.BackColor = System.Drawing.Color.LightCoral;
        messagesFP.BackgroundImage = ((System.Drawing.Image)resources.GetObject("messagesFP.BackgroundImage"));
        messagesFP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        messagesFP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
        messagesFP.Location = new System.Drawing.Point(323, 95);
        messagesFP.Name = "messagesFP";
        messagesFP.Size = new System.Drawing.Size(477, 315);
        messagesFP.TabIndex = 4;
        messagesFP.WrapContents = false;
        messagesFP.SizeChanged += messagesFP_SizeChanged;
        // 
        // messageRTB
        // 
        messageRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        messageRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
        messageRTB.Location = new System.Drawing.Point(323, 408);
        messageRTB.Name = "messageRTB";
        messageRTB.Size = new System.Drawing.Size(402, 41);
        messageRTB.TabIndex = 5;
        messageRTB.Text = "";
        // 
        // sendPB
        // 
        sendPB.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
        sendPB.BackgroundImage = ((System.Drawing.Image)resources.GetObject("sendPB.BackgroundImage"));
        sendPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        sendPB.Location = new System.Drawing.Point(728, 408);
        sendPB.Name = "sendPB";
        sendPB.Size = new System.Drawing.Size(72, 41);
        sendPB.TabIndex = 6;
        sendPB.TabStop = false;
        sendPB.Click += sendPB_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        ControlBox = false;
        Controls.Add(sendPB);
        Controls.Add(messageRTB);
        Controls.Add(messagesFP);
        Controls.Add(UserCardsFP);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(TitleBarPanel);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        MaximizeBox = false;
        MdiChildrenMinimizedAnchorBottom = false;
        MinimizeBox = false;
        Text = "MainForm";
        Load += MainForm_Load;
        TitleBarPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)closePB).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)RefreshPB).EndInit();
        ((System.ComponentModel.ISupportInitialize)loggedinDpPB).EndInit();
        panel3.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)currentUserDpPb).EndInit();
        ((System.ComponentModel.ISupportInitialize)sendPB).EndInit();
        ResumeLayout(false);
    }

    private WhatsAppClone.CircularPB sendPB;

    private System.Windows.Forms.PictureBox closePB;

    private System.Windows.Forms.PictureBox pictureBox2;

    public System.Windows.Forms.Label currentUserLastSeenLabel;

    private WhatsAppClone.CircularPB RefreshPB;

    public System.Windows.Forms.Label currentUserNameLabel;

    public WhatsAppClone.CircularPB currentUserDpPb;
    private System.Windows.Forms.Label loggedinNameLabel;

    private WhatsAppClone.CircularPB loggedinDpPB;

    private System.Windows.Forms.RichTextBox messageRTB;

    public System.Windows.Forms.FlowLayoutPanel messagesFP;

    private System.Windows.Forms.FlowLayoutPanel UserCardsFP;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel TitleBarPanel;

    #endregion
}