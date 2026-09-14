using System.Drawing.Drawing2D;

namespace WhatsAppClone;

public class CircularLabel : Label
{
    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath g = new GraphicsPath();
        g.AddEllipse(0, 0, Width, Height);
        this.Region = new System.Drawing.Region(g);
        base.OnPaint(e);
    }
}