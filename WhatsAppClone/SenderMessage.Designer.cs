using System.ComponentModel;

namespace WhatsAppClone;

partial class SenderMessage
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
        messageLabel = new System.Windows.Forms.Label();
        TimeLabel = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // messageLabel
        // 
        messageLabel.Location = new System.Drawing.Point(12, 9);
        messageLabel.Name = "messageLabel";
        messageLabel.Size = new System.Drawing.Size(311, 69);
        messageLabel.TabIndex = 0;
        messageLabel.Text = "label1";
        // 
        // TimeLabel
        // 
        TimeLabel.Location = new System.Drawing.Point(187, 78);
        TimeLabel.Name = "TimeLabel";
        TimeLabel.Size = new System.Drawing.Size(100, 30);
        TimeLabel.TabIndex = 1;
        TimeLabel.Text = "label2";
        TimeLabel.Click += label2_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(293, 78);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(30, 30);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // SenderMessage
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightGreen;
        Controls.Add(pictureBox1);
        Controls.Add(TimeLabel);
        Controls.Add(messageLabel);
        Size = new System.Drawing.Size(335, 120);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label TimeLabel;

    private System.Windows.Forms.Label messageLabel;

    #endregion
}