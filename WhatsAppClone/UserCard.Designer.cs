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
        circularPB1 = new WhatsAppClone.CircularPB();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        circularLabel1 = new WhatsAppClone.CircularLabel();
        ((System.ComponentModel.ISupportInitialize)circularPB1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // circularPB1
        // 
        circularPB1.Location = new System.Drawing.Point(0, 0);
        circularPB1.Name = "circularPB1";
        circularPB1.Size = new System.Drawing.Size(55, 55);
        circularPB1.TabIndex = 0;
        circularPB1.TabStop = false;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(61, 0);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(73, 29);
        label1.TabIndex = 1;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(100, 26);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(73, 29);
        label2.TabIndex = 2;
        label2.Text = "label2";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(71, 32);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(23, 22);
        pictureBox1.TabIndex = 3;
        pictureBox1.TabStop = false;
        // 
        // circularLabel1
        // 
        circularLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        circularLabel1.Location = new System.Drawing.Point(289, 15);
        circularLabel1.Name = "circularLabel1";
        circularLabel1.Size = new System.Drawing.Size(34, 33);
        circularLabel1.TabIndex = 5;
        circularLabel1.Text = "1";
        // 
        // UserCard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(circularLabel1);
        Controls.Add(pictureBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(circularPB1);
        Size = new System.Drawing.Size(323, 55);
        Load += UserCard_Load;
        ((System.ComponentModel.ISupportInitialize)circularPB1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private WhatsAppClone.CircularLabel circularLabel1;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private WhatsAppClone.CircularPB circularPB1;

    #endregion
}