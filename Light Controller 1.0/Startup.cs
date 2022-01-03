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
    public partial class Startup : Form
    {
        public Startup()
        {
            FormBorderStyle = FormBorderStyle.None;
            Paint += OnPaint;
            InitializeComponent();
            LoadMainGui();
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = ClientRectangle;
            rectangle.Size = new Size(rectangle.Width - 1, rectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
        }

        private async void LoadMainGui()
        {
            MainGUI mainGUI = new MainGUI();
            await Task.Delay(3000);
            mainGUI.Show();
            Hide();
        }
    }
}
