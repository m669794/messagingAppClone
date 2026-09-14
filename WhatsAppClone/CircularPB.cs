using System.Drawing.Drawing2D;

namespace WhatsAppClone;

public class CircularPB : PictureBox
{
    protected override void OnPaint(PaintEventArgs pe)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddEllipse(0, 0, Width, Height);
        this.Region = new System.Drawing.Region(path);
        base.OnPaint(pe);
    }
    
    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        if (Width > 0 && Height > 0)
        {
            using GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            this.Region = new Region(path);
        }
    }
}