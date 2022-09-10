using System;
using System.Drawing;
using System.Windows.Forms;

namespace Light_Controller_1._0
{
    public partial class ColorPicker : Form
    {

        private bool shown;
        private bool dragging;
        private bool draggingPen;
        private Action resultAction;
        private Color selectedColor;

        public ColorPicker()
        {
            Activate();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            shown = true;
            InitializeComponent();
            initColors();
            loadPresetColors();
            newColor.BaseColor = selectedColor = CurrentColor;
            StartPosition = FormStartPosition.Manual;
            Left = Screen.PrimaryScreen.Bounds.Width / 2 - Width / 2;
            Top = Screen.PrimaryScreen.Bounds.Height / 2 - Height / 2;
        }
        
        private void initColors()
        {
            Bitmap bitmap = new Bitmap(383, 250);
            ColorHolder colorHolder = ColorHolder.fromColor(Color.Red);
            int[] color = { 0, 255, 0};
            int pixelX = 0;
            for (int i = 0; i < 6; i++)
            {
                while((i % 2 == 0 && color[i % 3] <= 251) || (i % 2 != 0 && color[i % 3] >= 4))
                {
                    if (i % 2 == 0) color[i % 3] += 4;
                    else color[i % 3] -= 4;
                    colorHolder = ColorHolder.fromColor(Color.FromArgb(color[1], color[0], color[2]));
                    drawColumn(bitmap, colorHolder, pixelX);
                    pixelX++;
                }
                if (i % 2 != 0) color[i % 3] = 0;
                else color[i % 3] = 255;
                colorHolder = ColorHolder.fromColor(Color.FromArgb(color[1], color[0], color[2]));
                if (pixelX < bitmap.Width)
                {
                    
                    Console.WriteLine(colorHolder.createColor());
                    drawColumn(bitmap, colorHolder, pixelX);
                    pixelX++;
                } 
            }
            picker.BackgroundImage = bitmap;
        }

        private void drawColumn(Bitmap bitmap, ColorHolder colorHolder, int pixelX)
        {
            colorHolder.brightness = 255;
            for (int j = 0; j < bitmap.Height; j++)
            {
                bitmap.SetPixel(pixelX, j, colorHolder.createColor());
                if (j > 10) colorHolder.brightness--;
            }
        }

        private async void updateBrightnessPicker()
        {
            Bitmap bitmap = new Bitmap(brightnessPicker.Width, 1);
            ColorHolder colorHolder = ColorHolder.fromColor(selectedColor);
            for(int i = 0; i < bitmap.Width; i++)
            {
                bitmap.SetPixel(i, 0, colorHolder.createColor());
                if(i > 100) colorHolder.brightness++;
            }
            brightnessPicker.Invoke(new Action(() => brightnessPicker.BackgroundImage = bitmap));
        }

        private void loadPresetColors()
        {
            Color[] colors = { Color.Red, Color.Orange, Color.Yellow, Color.YellowGreen, 
                Color.Lime, Color.Green, Color.DarkGreen, Color.Cyan, Color.DodgerBlue, 
                Color.Blue, Color.Purple, Color.Pink };
            int x = 0;
            foreach (Color color in colors)
            {
                Label label = new();
                label.AutoSize = false;
                label.Size = new Size(33, 33);
                label.BackColor = color;
                label.Location = new Point(x, 0);
                label.MouseEnter += ColorHover;
                label.MouseLeave += ColorLeave;
                label.Click += ColorClick;
                label.Cursor = Cursors.Hand;
                label.Tag = color.Name;
                label.ForeColor = Color.White;
                label.TextAlign = ContentAlignment.MiddleCenter;
                presetColors.Controls.Add(label);
                x += 33;
            }
        }

        private void ColorHover(object sender, EventArgs e)
        {
            ActivateColor(sender as Label);
        }

        private void ColorLeave(object sender, EventArgs e)
        {
            DeactivateColor(sender as Label);
        }


        private void ActivateColor(Label label)
        {
            Color color = label.BackColor;
            colorName.Text = String.Format("{0}\nR: {1}  G: {2}  B: {3}", color.Name, color.R, color.G, color.B);
            label.BackColor = Color.FromArgb(150, label.BackColor.R, label.BackColor.G, label.BackColor.B);
        }

        public int PresetIndex
        {
            set
            {
               foreach (Control control in presetColors.Controls)
                {
                    Label label = control as Label;
                    Invoke(() => DeactivateColor(label));
                    if(presetColors.Controls.GetChildIndex(control) == value)
                    {
                        Invoke(() =>
                        {
                            newColor.BaseColor = label.BackColor;
                            selectedColor = label.BackColor;
                            ActivateColor(label);
                        });
                    }
                }
            }
        }

        public int GetPresetCount()
        {
            return presetColors.Controls.Count;
        }

        private void ColorClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            DeactivateColor(label);
            newColor.BaseColor = label.BackColor;
            selectedColor = label.BackColor;
        }

        private void DeactivateColor(Label label)
        {
            Console.WriteLine(label.Tag);
            label.BackColor = Color.FromName(label.Tag.ToString());
            Color color = selectedColor;
            colorName.Text = String.Format("{0}\nR: {1}  G: {2}  B: {3}", color.Name, color.R, color.G, color.B);
        }

        private void pen_MouseDown(object sender, MouseEventArgs e)
        {
            draggingPen = true;
            pen_MouseMove(sender, e);
        }

        private void picker_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            picker_MouseMove(sender, e);
        }

        private void picker_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = draggingPen = false;
        }


        private void pen_MouseMove(object sender, MouseEventArgs e)
        {
            if (draggingPen)
            {
                int x = e.Location.X + pen.Location.X;
                int y = e.Location.Y + pen.Location.Y;
                if (x > 0 && x < picker.Width && y > 0 && y < picker.Height)
                {
                    pen.Location = new Point(x - pen.Width / 2, y - pen.Height / 2);
                    UpdateColor();
                }
            }
        }

        private void picker_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                int x = e.Location.X;
                int y = e.Location.Y;
                if (x > 0 && x < picker.Width - pen.Width && y > 0 && y < picker.Height)
                {
                    pen.Location = new Point(x - pen.Width / 2, y - pen.Height / 2);
                    UpdateColor();
                }
            }
        }

        public Color CurrentColor
        {
            get { return currentColor.BaseColor; }
            set { 
                currentColor.BaseColor = selectedColor = value;
                findColor(value);
                Color color = selectedColor;
                colorName.Text = String.Format("{0}\nR: {1}  G: {2}  B: {3}", color.Name, color.R, color.G, color.B);
                Bitmap bitmap = new Bitmap(brightnessPicker.Width, 1);
                ColorHolder colorHolder = ColorHolder.fromColor(selectedColor);
                for (int i = 0; i < bitmap.Width; i++)
                {
                    bitmap.SetPixel(i, 0, colorHolder.createColor());
                    if (i > 100) colorHolder.brightness++;
                }
                brightnessPicker.BackgroundImage = bitmap;
            }
        }

        public bool IsShown
        {
            get {
                return shown;
            } 
        }

        private void pickerClosed(object sender, FormClosedEventArgs e)
        {
            shown = false;
        }

        private void findColor(Color color)
        {
            Bitmap bitmap = picker.BackgroundImage as Bitmap;
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if (bitmap.GetPixel(x, y) == color)
                    {
                        pen.Location = new Point(x - pen.Width / 2, y - pen.Height / 2);
                        break;
                    }
                }
            }
        }

        private async void UpdateColor()
        {
            Color color = getPickerColor();
            selectedColor = color;
            updateBrightnessPicker();
            Bitmap bitmap = brightnessPicker.BackgroundImage as Bitmap;
            brightnessPen.Invoke(() => color = bitmap.GetPixel(brightnessPen.Location.X, 0));
            colorName.Invoke(() => newColor.BaseColor = selectedColor = color);
            colorName.Invoke(new Action(() => colorName.Text = String.Format("{0}\nR: {1}  G: {2}  B: {3}", color.Name, color.R, color.G, color.B)));
        }

        private Color getPickerColor()
        {
            int x = pen.Location.X + pen.Width / 2 - 1;
            int y = pen.Location.Y + pen.Height / 2;
            Bitmap bitmap = picker.BackgroundImage as Bitmap;
            if(x < bitmap.Width) return bitmap.GetPixel(x, y);
            else return bitmap.GetPixel(bitmap.Width - 1, y);
        }

        private void brightnessPicker_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            brightnessPicker_MouseMove(sender, e);
        }

        private void brightnessPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging) UpdateBrightness(e.X);
        }

        private void UpdateBrightness(int x)
        {
            Bitmap bitmap = brightnessPicker.BackgroundImage as Bitmap;
            if (x > 0 && x < bitmap.Width)
            {
                Invoke(() =>
                {
                    brightnessPen.Location = new Point(x, -3);
                    Color color = bitmap.GetPixel(x, 0);
                    newColor.BaseColor = selectedColor = color;
                    colorName.Text = String.Format("{0}\nR: {1}  G: {2}  B: {3}", color.Name, color.R, color.G, color.B);
                });
            }
        }

        public Point PenLocation
        {
            get
            {
                return pen.Location;
            }
            set
            {
                Console.WriteLine(value);
                pen.Invoke(() => pen.Location = value);
                UpdateColor();
            }
        }

        public Label Pen
        {
            get { return pen; }
        }

        public Panel Picker
        {
            get => picker;
        }

        public int Brightness
        {
            get
            {
                return brightnessPen.Location.X;
            }
            set
            {
                UpdateBrightness(value);
            }
        }

        private void brightnessPicker_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public Action OnResult
        {
            get {
                return resultAction;
            }
            set
            {
                resultAction = value;
            }
        }

        public Color SelectedColor
        {
            get { return selectedColor; }
        } 

        private void okButton_Click(object sender, EventArgs e)
        {
            Invoke(resultAction);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
