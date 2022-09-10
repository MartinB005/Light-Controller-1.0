using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Light_Controller_1._0
{
    class CustomForm : Form
    {
        private string title;
        private Label titleLabel;
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private EventHandler resultAction;
        private ColorHolder[][] colors;
        private Stopwatch stopWatch;
        private int beatsCount;
        public bool[] selectedLights = new bool[4];
        private Preset preset;
        private Label bpm;
        private Action actionBeat;
        private MainGUI mainGUI;
        public static Guna.UI.WinForms.GunaLabel serialMonitor;
        private Guna.UI.WinForms.GunaCheckBox autoScroll;

        public CustomForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.FromArgb(64, 64, 64);
            RootCloseButton();
            RootTitle();
            CenterToParent();
            MouseDown += Form_MouseDown;
            MouseUp += Form_MouseUp;
            MouseMove += Form_MouseMove;
            Paint += OnPaint;
            SizeChanged += Size_Changed;
        }

        private void Size_Changed(object sender, EventArgs e)
        {
            RootTitle();
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                titleLabel.Text = value;
                title = value;
            }
        }

        public void setOnResultMethod(EventHandler eventHandler)
        {
            resultAction = eventHandler;
            RootOkCancel();
        }

        private void RootTitle()
        {
            if (Controls.Contains(titleLabel)) Controls.Remove(titleLabel);
            titleLabel = new Label();
            titleLabel.Font = new Font(titleLabel.Font.Name, 16F);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(2, 2);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Width = ClientRectangle.Width;
            titleLabel.MouseDown += Form_MouseDown;
            titleLabel.MouseMove += Form_MouseMove;
            titleLabel.MouseUp += Form_MouseUp;
            Controls.Add(titleLabel);
        }

        private void RootOkCancel()
        {
            Guna.UI.WinForms.GunaButton ok = new Guna.UI.WinForms.GunaButton();
            ok.Text = "OK";
            ok.BaseColor = Color.FromArgb(50, 80, 130);
            ok.OnHoverBaseColor = Color.FromArgb(40, 70, 120);
            ok.Location = new Point(Width - 60, Height - ok.Height);
            ok.Size = new Size(55, 25);
            ok.Image = null;
            ok.Click += resultAction;
            ok.TextAlign = HorizontalAlignment.Center;
            Controls.Add(ok);
            Guna.UI.WinForms.GunaButton cancel = new Guna.UI.WinForms.GunaButton();
            cancel.Text = "CANCEL";
            cancel.BaseColor = Color.FromArgb(50, 80, 130);
            cancel.OnHoverBaseColor = Color.FromArgb(40, 70, 120);
            cancel.Location = new Point(Width - ok.Width - 65, Height - cancel.Height);
            cancel.Size = new Size(55, 25);
            cancel.Image = null;
            cancel.Click += CloseButton_Click;
            cancel.TextAlign = HorizontalAlignment.Center;
            Controls.Add(cancel);
        }

        private void RootCloseButton()
        {
            Guna.UI.WinForms.GunaLabel label = new Guna.UI.WinForms.GunaLabel();
            label.Text = "✕";
            label.BackColor = Color.Transparent;
            label.Font = new Font(label.Font.FontFamily, 10, FontStyle.Bold);
            label.Click += CloseButton_Click;
            label.MouseEnter += CloseButton_Enter;
            label.MouseLeave += CloseButton_Leave;
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            label.Location = new Point(Width - 38, 1);
            label.ForeColor = Color.White;
            Controls.Add(label);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            serialMonitor = null;
            Close();
        }

        private void CloseButton_Enter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.FromArgb(150, 255, 0, 0);
        }

        private void CloseButton_Leave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.Transparent;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = ClientRectangle;
            rectangle.Size = new Size(rectangle.Width - 1, rectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
        }

        public void CreateLightsChooser()
        {
            Text = "New Color Group";
            for (int j = 0; j < 4; j++) selectedLights[j] = true;
            for (int i = 0; i < 4; i++)
            {
                Guna.UI.WinForms.GunaCheckBox checkBox = new Guna.UI.WinForms.GunaCheckBox();
                checkBox.Text = "Light " + (i + 1);
                checkBox.Location = new Point(20 + i * 65, 60);
                checkBox.ForeColor = Color.White;
                checkBox.Tag = i;
                checkBox.Checked = true;
                checkBox.CheckedChanged += checked_Change;
                checkBox.CheckedOnColor = Color.FromArgb(50, 80, 130);
                Controls.Add(checkBox);
            }
        }

        public void CreatePresetDialog(Preset preset)
        {
            this.preset = preset;
            string[] speeds = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            string[] optionsNames = new string[] { "Name", "Color Speed", "Brightness" };
            string[] defaultValues = new string[] { preset.name, speeds[preset.colorSpeed],
                preset.brightness + "" };
            for (int i = 0; i < optionsNames.Length; i++)
            {
                Guna.UI.WinForms.GunaLabel label = new Guna.UI.WinForms.GunaLabel();
                label.Text = optionsNames[i];
                label.Location = new Point(10, i * 60 + 30);
                label.ForeColor = Color.White;
                label.Height = 20;
                Guna.UI.WinForms.GunaLineTextBox textBox = new Guna.UI.WinForms.GunaLineTextBox();
                textBox.Location = new Point(10, i * 60 + 50);
                textBox.Text = defaultValues[i];
                textBox.Tag = optionsNames[i];
                textBox.LineColor = Color.FromArgb(50, 80, 130);
                textBox.FocusedLineColor = Color.Blue;
                Controls.Add(label);
                Controls.Add(textBox);
            }
            CreateCheckBoxes(preset);
        }

        private void CreateCheckBoxes(Preset preset)
        {
            colors = preset.colors;
            Guna.UI.WinForms.GunaCheckBox fadeIn = new Guna.UI.WinForms.GunaCheckBox();
            fadeIn.Checked = preset.fadeIn;
            fadeIn.Location = new Point(10, Height - 100);
            fadeIn.ForeColor = Color.White;
            fadeIn.CheckedOnColor = Color.FromArgb(50, 80, 130);
            fadeIn.Text = "Fade In";
            fadeIn.Tag = "Fade In";
            Guna.UI.WinForms.GunaCheckBox fadeOut = new Guna.UI.WinForms.GunaCheckBox();
            fadeOut.Checked = preset.fadeOut;
            fadeOut.Location = new Point(100, Height - 100);
            fadeOut.ForeColor = Color.White;
            fadeOut.CheckedOnColor = Color.FromArgb(50, 80, 130);
            fadeOut.Text = "Fade Out";
            fadeOut.Tag = "Fade Out";
            Controls.Add(fadeIn);
            Controls.Add(fadeOut);
        }

        public Preset CreatePreset()
        {
            Preset preset = new Preset();
            preset.colors = colors;
            preset.presetIndex = this.preset.presetIndex;
            string[] speeds = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            foreach (Control control in Controls)
            {
                try
                {
                    if (control.Tag != null)
                    {
                        switch (control.Tag.ToString())
                        {
                            case "Name":
                                preset.name = control.Text;
                                break;
                            case "Color Speed":
                                preset.colorSpeed = Array.IndexOf(speeds, control.Text);
                                break;
                            case "Brightness":
                                preset.brightness = Convert.ToInt32(control.Text);
                                break;
                            case "Fade In":
                                preset.fadeIn = ((Guna.UI.WinForms.GunaCheckBox)control).Checked;
                                break;
                            case "Fade Out":
                                preset.fadeOut = ((Guna.UI.WinForms.GunaCheckBox)control).Checked;
                                break;
                        }
                    }
                }
                catch
                {
                    control.ForeColor = Color.Red;
                    return null;
                }
            }
            return preset;
        }

        public Preset GetShowedPreset()
        {
            return preset;
        }

        private void checked_Change(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaCheckBox checkBox = (Guna.UI.WinForms.GunaCheckBox)sender;
            int number = Convert.ToInt32(checkBox.Tag.ToString());
            selectedLights[number] = checkBox.Checked;
        }

        public void CreateSerialController()
        {
            Guna.UI.WinForms.GunaLineTextBox textBox = new Guna.UI.WinForms.GunaLineTextBox();
            textBox.Location = new Point(10, 30);
            textBox.Width = 450;
            textBox.LineColor = Color.FromArgb(50, 80, 130);
            textBox.FocusedLineColor = Color.Blue;
            textBox.KeyDown += EnterClicked;
            Controls.Add(textBox);
            Panel panel = new Panel();
            panel.Location = new Point(10, 70);
            panel.Size = new Size(450, 200);
            serialMonitor = new Guna.UI.WinForms.GunaLabel();
            serialMonitor.ForeColor = Color.White;
            serialMonitor.AutoSize = true;
            serialMonitor.TextChanged += Serial_text_Changed;
            panel.Controls.Add(serialMonitor);
            panel.AutoScroll = true;
            panel.MouseDown += Form_MouseDown;
            panel.MouseMove += Form_MouseMove;
            panel.MouseUp += Form_MouseUp;
            autoScroll = new Guna.UI.WinForms.GunaCheckBox();
            autoScroll.Checked = true;
            autoScroll.Location = new Point(10, Height - 25);
            autoScroll.ForeColor = Color.White;
            autoScroll.CheckedOnColor = Color.FromArgb(50, 80, 130);
            autoScroll.Text = "Auto Scroll";
            Controls.Add(autoScroll);
            serialMonitor.Text = "Serial Monitor Started At " + DateTime.Now.ToString("HH:mm:ss");
            Controls.Add(panel);
        }


        private void Serial_text_Changed(object sender, EventArgs e)
        {
            if (autoScroll.Checked)
            {
                Panel panel = (Panel)serialMonitor.Parent;
                int scroll = panel.VerticalScroll.Value;
                Control control = new Control();
                control.Location = new Point(0, serialMonitor.Height - scroll);
                panel.Controls.Add(control);
                Console.WriteLine("changed");
                panel.ScrollControlIntoView(control);
            }
        }

        void EnterClicked(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Guna.UI.WinForms.GunaLineTextBox textBox = (Guna.UI.WinForms.GunaLineTextBox)sender;
                SerialPort port = MainGUI.port;
                if ((port != null) && (port.IsOpen)) port.Write(textBox.Text);
                textBox.Clear();
                e.Handled = true;
            }
        }

        internal void CreateBeatTapper(MainGUI gui)
        {
            Guna.UI.WinForms.GunaButton tap = new Guna.UI.WinForms.GunaButton();
            tap.Text = "TAP";
            tap.BaseColor = Color.DarkGray;
            tap.OnHoverBaseColor = Color.LightGray;
            tap.Location = new Point(100, 50);
            tap.Size = new Size(100, 100);
            tap.Image = null;
            tap.Click += TapPressed;
            tap.TextAlign = HorizontalAlignment.Center;
            Controls.Add(tap);
            bpm = new Label();
            bpm.ForeColor = Color.White;
            bpm.Location = new Point(120, 250);
            Controls.Add(bpm);
            mainGUI = gui;
        }

        private void TapPressed(object sender, EventArgs e)
        {
            beatsCount++;
            if ((stopWatch == null)||(stopWatch.ElapsedMilliseconds / beatsCount > 900)) 
                stopWatch = Stopwatch.StartNew();
            else
            {
                int distance = Convert.ToInt32(stopWatch.ElapsedMilliseconds / beatsCount);
                bpm.Text = "BPM: " + Math.Round(60d / distance * 1000d);
                mainGUI.tapBeat(distance);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CustomForm";
            this.ResumeLayout(false);

        }
    }
}
