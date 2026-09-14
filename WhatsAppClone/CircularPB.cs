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
}