using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EduNova.WinForms.Controls
{
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 12;

        public RoundedPanel()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                path.AddArc(Width - CornerRadius - 1, 0, CornerRadius, CornerRadius, 270, 90);
                path.AddArc(Width - CornerRadius - 1, Height - CornerRadius - 1, CornerRadius, CornerRadius, 0, 90);
                path.AddArc(0, Height - CornerRadius - 1, CornerRadius, CornerRadius, 90, 90);
                path.CloseFigure();
                Region = new Region(path);
            }
        }
    }
}
