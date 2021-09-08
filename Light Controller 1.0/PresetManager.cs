using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Controller_1._0
{
    public partial class PresetManager : Form
    {
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public PresetManager()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            loadPresets();
            Paint += OnPaint;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }

        private void Maximize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }


        private void Minimize(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ShowRed(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
        }

        private void HideRed(object sender, EventArgs e)
        {
            close.BackColor = Color.Transparent;
        }

        private void ShowMinimizeBlue(object sender, EventArgs e)
        {
            minimize.BackColor = Color.LightSlateGray;
        }

        private void HideMinimizeBlue(object sender, EventArgs e)
        {
            minimize.BackColor = Color.Transparent;
        }

        private void ShowMaximizeBlue(object sender, EventArgs e)
        {
            maximize.BackColor = Color.LightSlateGray;
        }

        private void HideMaximizeBlue(object sender, EventArgs e)
        {
            maximize.BackColor = Color.Transparent;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = ClientRectangle;
            rectangle.Size = new Size(rectangle.Width - 1, rectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
        }

        private void loadPresets()
        {
            List<Preset> presets = Preset.GetLocalPresets();
            string[] speeds = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            foreach (Preset preset in presets)
            {
                presetName.Text = preset.name;
                presetValues.Text = "Color Speed: " + speeds[preset.colorSpeed] +
                    ", Brightness: " + preset.brightness + ",\nFade In: "
                    + (preset.fadeIn ? "ON" : "OFF") + ", Fade Out: "
                    + (preset.fadeOut ? "ON" : "OFF") + ", Bar Sync: "
                    + (preset.barSync ? "ON" : "OFF");
                Panel panel = new Panel();
                foreach (Control control in presetPanel.Controls)panel.Controls.Add(control);
                flowLayoutPanel.Controls.Add(panel);
            }
        }


        public void nextBeat(int beat)
        {

              //  Label[] lights = new Label[] { light1, light2, light3, light4 };
          //  Color[][] colors = preset.colors;
           // for (int i = 0; i < 4; i++) lights[i].ForeColor = colors[beat - 1][i];
        }
    }
}
