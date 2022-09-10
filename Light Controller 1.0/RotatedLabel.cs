using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Light_Controller_1._0
{
    internal class RotatedLabel : Label
    {
        public int RotateAngle { get; set; }  // to rotate your text
        public string RotatedText { get; set; }   // to draw text
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush b = new SolidBrush(this.ForeColor);
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(this.RotateAngle);
            e.Graphics.DrawString(this.RotatedText, this.Font, b, 0f, 0f);
            base.OnPaint(e);
        }

    }
}
