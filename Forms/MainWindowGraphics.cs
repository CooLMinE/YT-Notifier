using System.Drawing;
using System.Windows.Forms;

namespace YTNotifier
{
    partial class MainWindow
    {
        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(0, 0, statusStrip1.Width, statusStrip1.Height);
            System.Drawing.Drawing2D.LinearGradientBrush b = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.White, Color.Silver, System.Drawing.Drawing2D.LinearGradientMode.Vertical);

            g.FillRectangle(b, rect);
        }

        //draw items background
        private void listBoxControl1_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            if (_invalidChannelIndex != -1)
            {
                if (e.Index == _invalidChannelIndex)
                {
                    e.Appearance.BackColor = Color.LightPink;
                }
            }
        }
    }
}
