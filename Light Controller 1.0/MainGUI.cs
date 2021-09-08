using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Controller_1._0
{

    public partial class MainGUI : Form
    {
        private int colorR;
        private int colorG;
        private int colorB;
        private Stopwatch beat8Time;
        private Stopwatch beatComparer;
        private int beat;
        private int anotherDeskBeat;
        private int totalBeats;
        private int anotherDeskBeats;
        private int comparingBpm;
        private int speedMemory;
        private int beatDistance;
        private int colorCount;
        private bool playingDesk1;
        private bool disableChanging;
        private bool dragging;
        private bool detectorRunning;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private CustomForm newPresetForm;
        private SerialPort port;

        public MainGUI()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) portSelection.Items.Insert(0, port);
            FormBorderStyle = FormBorderStyle.None;
            RootColorButtons();
            Paint += OnPaint;
        }

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = ClientRectangle;
            rectangle.Size = new Size(rectangle.Width - 1, rectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
        }

        private void RootColorButtons()
        {
            bool[] lights = new bool[4];
            for (int j = 0; j < 4; j++) lights[j] = true;
            for (int i = 0; i < 4; i++) createColorGroup(lights);
        }

        private Panel createColorGroup(bool[] lights)
        {
            Panel linePanel = new Panel();
            int scroll = panel1.VerticalScroll.Value;
            linePanel.Location = new Point(0,  45 * colorCount - scroll);
            linePanel.Size = new Size(290, 40);
            linePanel.Tag = colorCount;
            for (int j = 0; j < 4; j++)
            {
                if (lights[j])
                {
                    Guna.UI.WinForms.GunaButton button = NewColorButton(j);
                    linePanel.Controls.Add(button);
                }
            }
            panel1.Controls.Add(linePanel);
            linePanel.Controls.Add(NewRemovingButton());
            colorCount++;
            return linePanel;
        }

        private Guna.UI.WinForms.GunaButton NewColorButton(int number)
        {
            Guna.UI.WinForms.GunaButton button = new Guna.UI.WinForms.GunaButton();
            button.Name = "color" + (number + 1);
            button.Location = new Point(65 * number, 0);
            button.Size = new Size(60, 40);
            button.Click += colorButtonClick;
            button.Tag = number;
            button.Text = "▬";
            button.ForeColor = Color.Black;
            button.BaseColor = Color.Silver;
            button.Image = null;
            button.TextAlign = HorizontalAlignment.Center;
            button.OnHoverForeColor = button.ForeColor;
            button.Font = new Font(button.Font.FontFamily, 20);
            return button;
        }

        private Guna.UI.WinForms.GunaButton NewRemovingButton()
        {
            Guna.UI.WinForms.GunaButton button = new Guna.UI.WinForms.GunaButton();
            button.Location = new Point(265, 10);
            button.Size = new Size(20, 20);
            button.BaseColor = Color.DodgerBlue;
            button.TextAlign = HorizontalAlignment.Center;
            button.Text = "-";
            button.Tag = "Remove";
            button.Image = null;
            button.TextAlign = HorizontalAlignment.Center;
            button.Font = new Font(button.Font.FontFamily, 20);
            button.OnHoverBaseColor = Color.LightSkyBlue;
            button.Click += removeGroupClick;
            return button;
        }

            private void selectPort(object sender, EventArgs e)
        {
            string selectedPort = "";
            try
            {
                bool connectedBefore = port != null && port.IsOpen;
                if (port != null) port.Close();
                string[] ports = SerialPort.GetPortNames();
                selectedPort = ports[ports.Length - 1 - portSelection.SelectedIndex];
                port = new SerialPort(selectedPort, 115200);
                port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                port.Open();
                if (!connectedBefore) port.Close();
                ShowOnDisplay("Connected to port " + selectedPort);
            }
            catch
            {
                MessageBox.Show("Unable to connect to port " + selectedPort, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //WINDOW SETTINGS
        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
        }


        private void Maximize(object sender, EventArgs e) {
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

        private void colorButtonClick(object sender, EventArgs e)
        {
            colorSelection(sender);
        }

        private async void colorSelection(object sender)
        {
            Guna.UI.WinForms.GunaButton button = (Guna.UI.WinForms.GunaButton)sender;
            string tag = button.Tag.ToString();
            string parentTag = button.Parent.Tag.ToString();
            ColorDialog dialog = new ColorDialog();
            dialog.Color = button.ForeColor;
            //Cursor.Position = new Point(Location.X + button.Location.X + 80, Location.Y + button.Location.Y + 50);
            await Task.Delay(5);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Color color = dialog.Color;
                button.ForeColor = button.OnHoverForeColor = color;
                SendToArduino("setColor", tag + "," + parentTag + ">" + color.R + "/" + color.G + "/" + color.B);
            }
        }

        private void TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            gunaLabel1.Text = "Progress: " + e.NewValue;
           // progressBar.Value = e.NewValue;
            colorR = Convert.ToInt32(e.NewValue * 2.55);
            progressBar.ProgressMaxColor = Color.FromArgb(colorR, colorG, colorB);
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


        //PROGRAM

        private void TrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            colorG = Convert.ToInt32(e.NewValue * 2.55);
            progressBar.ProgressMaxColor = Color.FromArgb(colorR, colorG, colorB);
        }

        private void TrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            colorB = Convert.ToInt32(e.NewValue * 2.55);
            progressBar.ProgressMaxColor = Color.FromArgb(colorR, colorG, colorB);
        }

        private void brigthnessTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            SendToArduino("brightness", Convert.ToString(e.NewValue));
            ShowOnDisplay("Brightness: " + e.NewValue);
        }

        private void speedTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            string[] values = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            int speed = Convert.ToInt32(e.NewValue / 24);
            if (speed != speedMemory)
            {
                SendToArduino("colorSpeed", Convert.ToString(speed));
                speedMemory = speed;
            }
            ShowOnDisplay("Color Speed: " + values[speed]);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            detectorRunning = !detectorRunning;
            string buttonText = detectorRunning ? "STOP" : "START";
            startButton.Text = buttonText;
            if (detectorRunning)
            {
                anotherDeskBeats = 0;
                playingDesk1 = true;
                beat8Time = Stopwatch.StartNew();
                beatComparer = Stopwatch.StartNew();
                var ts = new ThreadStart(BackgroundMethod);
                var backgroundThread = new Thread(ts);
                backgroundThread.Start();
            }
        }

        void BackgroundMethod()
        {
            while (detectorRunning)
            {
                CaptureApplication("virtualdj");
                Thread.Sleep(1);
            }
        }

        private void ButtonsDesk_Change(object sender, EventArgs e)
        {
            if(!disableChanging) ChangeDecks();
        }

        private void ChangeDecks()
        {
            anotherDeskBeats = 0;
            disableChanging = true;
            playingDesk1 = !playingDesk1;
            Label[] labels = new Label[] { beat1, beat2, beat3, beat4 };
            foreach (Label label in labels)
            {
                label.ForeColor = playingDesk1 ? Color.MediumTurquoise : Color.Red;
            }
            ShowDeskOnDisplay();
        }

        public async void ShowDeskOnDisplay()
        {
            string desk = playingDesk1 ? "Desk 1" : "Desk 2";
            SendToArduino("lcd", "Playing " + desk);
            displayView.Invoke(new Action(() => displayView.Text = "Playing " + desk));
            await Task.Delay(2000);
            displayView.Invoke(new Action(() => displayView.Text = ""));
            SendToArduino("lcd", "");
        }

        public async void ShowOnDisplay(string text)
        {
            displayView.Invoke(new Action(() => displayView.Text = text));
            await Task.Delay(2000);
            if(displayView.Text.Equals(text)) 
                displayView.Invoke(new Action(() => displayView.Text = ""));
        }

        private void guna2TrackBar3_ValueChanged(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Progress: " + e;
        }

        public void CaptureApplication(string procName)
        {
            try
            {
                var bmp = new Bitmap(100, 30, PixelFormat.Format32bppArgb);
                using (Graphics graphics = Graphics.FromImage(bmp))
                {
                    graphics.CopyFromScreen(590, 0, 0, 0, new Size(bmp.Width, bmp.Height), CopyPixelOperation.SourceCopy);
                    //ShowPartOfScreen(bmp);
                    //Console.WriteLine(bmp.GetPixel(20, 10).B);
                 
                 detectBeat(bmp);
                 //pictureBox1.Image = bmp;
                }
            } catch
            {
             
            }
     
        }

        private void detectBeat(Bitmap bitmap)
        {
            int posY = playingDesk1 ? 10 : 20;
            //bitmap.SetPixel(20, 10, Color.Red);
            Label[] beatCounter = new Label[] { beat1, beat2, beat3, beat4 };
            int x = 0;
            foreach (Label label in beatCounter)
            {
                x += 20;
                Color pixel = bitmap.GetPixel(x, posY);
                int pixelColor = playingDesk1 ? pixel.B : pixel.R;
                label.Invoke(new Action(() => label.Visible = pixelColor > 100));
                if (pixelColor > 100)
                {
                    int beat = x / 20;
                    if (this.beat != beat)
                    {
                        this.beat = beat;
                        totalBeats++;
                        SendToArduino("beat", Convert.ToString(beat));
                        gunaLabel1.Invoke(new Action(() => gunaLabel1.Text = Convert.ToString(beat)));
                        if (totalBeats % 8 == 0)
                        {
                            beatDistance = Convert.ToInt32(beat8Time.ElapsedMilliseconds / 8);
                            if (beatDistance > 300)
                            {
                                double fullBpm = 60d / (beat8Time.ElapsedMilliseconds / 8) * 1000;
                                string bpmValue = Convert.ToString(Math.Round(fullBpm, 0));
                                beat2.Invoke(new Action(() => bpm.Text = "BPM : " + bpmValue));
                                beat8Time = Stopwatch.StartNew();
                                SendToArduino("beatDistance", Convert.ToString(beatDistance));
                            }
                            else ShowOnDisplay("Please Open Virtual DJ");
                        }
                    }
                }
            }
            if (auto.Checked) CheckAnotherDesk(bitmap);
            else if (disableChanging) disableChanging = false; 
        }

            private void CheckAnotherDesk(Bitmap bitmap)
        {
            int posY = playingDesk1 ? 20 : 10;
            for (int i = 20; i <= 80; i += 20)
            {
                Color pixel = bitmap.GetPixel(i, posY);
                if ((playingDesk1 ? pixel.R : pixel.B) > 100)
                {
                    int beat = i / 20;
                    if(anotherDeskBeat != beat)
                    {
                        double bpm = 60d / (beatComparer.ElapsedMilliseconds) * 1000;
                        //gunaLabel1.Invoke(new Action(() => gunaLabel1.Text = Convert.ToString(bpm)));
                        if ((bpm > 65) && (bpm < 175))
                        {
                            if ((!disableChanging)&&((anotherDeskBeats >= 8) 
                                || (Math.Abs(bpm - comparingBpm) < 20)))
                            {
                                    ChangeDecks();
                                    desk1.Invoke(new Action(() => desk1.Checked = playingDesk1));
                                    desk2.Invoke(new Action(() => desk2.Checked = !playingDesk1));
                            }
                            comparingBpm = Convert.ToInt32(bpm);
                            anotherDeskBeats++;
                        }
                        beatComparer = Stopwatch.StartNew();
                        anotherDeskBeat = beat;
                    }
                    if ((beatComparer.ElapsedMilliseconds > 920)) disableChanging = false;
                }
            }
        }

        private class User32
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct Rect
            {
                public int left;
                public int top;
                public int right;
                public int bottom;
            }

            [DllImport("user32.dll")]
            public static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //COMUNICATION

        private void Connect(object sender, EventArgs e)
        {
            try
            {
                if (port != null)
                {
                    if (port.IsOpen) SendToArduino("-disconnect:", "true");
                    if (port.IsOpen) port.Close();
                    else port.Open();
                    connect.Text = port.IsOpen ? "DISCONNECT" : "CONNECT";
                    connect.Width = port.IsOpen ? 155 : 125;
                    connect.BackColor = port.IsOpen ? Color.LightGray : Color.DodgerBlue;
                    if (port.IsOpen) sendAllColors(true);
                    if (beatDistance > 300)
                        SendToArduino("beatDistance", Convert.ToString(beatDistance));
                }
                else MessageBox.Show("Please select a port",
                    "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
        }

        private void SendToArduino(string key, string data)
        {
            if((port != null) && (port.IsOpen))
                port.Write("-" + key + ":" + data + ">");
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string incomingData = sp.ReadLine();
                string value = incomingData.Substring(incomingData.IndexOf(':') + 1);
                string key = incomingData.Substring(1, incomingData.IndexOf(':')-1);
                switch (key)
                {
                    case "audio":
                        progressBar.Value = Convert.ToInt32(value);
                        break;
                    case "display":
                        ShowOnDisplay(value);
                        ScrollTrackBar(value);
                        break;
                    case "lights":
                        int number = Convert.ToInt32(value.Substring(0, value.IndexOf(">")));
                        UpdateLightView(number, GetLightColor(value));
                        break;
                    case "requestColors":
                        sendAllColors(false);
                        break;
                    default:
                        Console.WriteLine(key);
                        break;
                }
            } catch
            {
                
            }
        }

        private void ScrollTrackBar(string valueText)
        {
            string value = valueText.Substring(0, valueText.Length - 1);
            value = value.Substring(value.IndexOf(": ") + 2);
            if (valueText.Contains("Brightness"))
            {
                brightness.Value = Convert.ToInt32(value);
            }
            if (valueText.Contains("Color speed"))
            {
                String[] values = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
                colorSpeed.Value = Array.IndexOf(values, value) * 25;
            }
        }

        private void UpdateLightView(int number, Color color)
        {
            Label[] lights = { light1, light2, light3, light4 };
            lights[number - 1].ForeColor = color;
        }

        private Color GetLightColor(string data)
        {
            int startIndex = data.IndexOf(">") + 1;
            int r = Convert.ToInt32(data.Substring(startIndex, data.IndexOf("|") - startIndex));
            data = data.Remove(0, data.IndexOf("|") + 1);
            int g = Convert.ToInt32(data.Substring(0, data.IndexOf("|")));
            data = data.Remove(0, data.IndexOf("|") + 1);
            int b = Convert.ToInt32(data.Substring(0, data.Length - 1));
            Console.WriteLine(r + "," + g + "," + b);
            return Color.FromArgb(r, g, b);
        }

        private async void sendAllColors(bool connecting)
        {
            if (connecting) displayView.Text = "Connecting...";
            Console.WriteLine("send");
            int[] colorCount = new int[4];
            foreach(Control control in panel1.Controls)
            {
                int line = Convert.ToInt32(control.Tag.ToString());
                Panel panel = (Panel) control;
                foreach (Control button in panel.Controls)
                {
                    string buttonTag = button.Tag.ToString();
                    if (!buttonTag.Equals("Remove"))
                    {
                        int column = Convert.ToInt32(buttonTag);
                        Color color = button.ForeColor;
                        SendToArduino("setColor", column + "," + line + ">" + color.R +
                            "/" + color.G + "/" + color.B);
                        colorCount[column]++;
                        await Task.Delay(10);
                    }
                }
            }
            SendToArduino("colorCount", colorCount[0] + "/" + 
                colorCount[1] + "/" + colorCount[2] + "/" + colorCount[3] + "/");
            if(connecting) ShowOnDisplay("Connected");
            Console.WriteLine(colorCount[0] + "/" +
                colorCount[1] + "/" + colorCount[2] + "/" + colorCount[3] + "/");
        }

        private void fadeOut_CheckedChanged(object sender, EventArgs e)
        {
            SendToArduino("fadeOut", Convert.ToString(fadeOut.Checked));
            Console.WriteLine(fadeOut.Checked);
        }

        private void fadeIn_CheckedChanged(object sender, EventArgs e)
        {
            SendToArduino("fadeIn", Convert.ToString(fadeIn.Checked));
        }

        private void removeGroupClick(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton button = (Guna.UI.WinForms.GunaButton) sender;
            int line = Convert.ToInt32(button.Parent.Tag.ToString());
            panel1.Controls.Remove(button.Parent);
            colorCount--;
            foreach(Control control in panel1.Controls)
            {
                int lineNumber = Convert.ToInt32(control.Tag.ToString());
                if (lineNumber > line)
                {
                    control.Location = new Point(0, control.Location.Y - control.Height - 5);
                    control.Tag = lineNumber - 1;
                }
            } 
            panel1.Controls.Remove(button);
            sendAllColors(false);
        }

        private void newGroup_Click(object sender, EventArgs e)
        {
            CustomForm newGroup = new CustomForm();
            newGroup.Icon = Icon;
            newGroup.CreateLightsChooser();
            newGroup.Size = new Size(300, 150);
            newGroup.Title = "New Color Group";
            newGroup.setOnResultMethod(onResultColorGroup);
            newGroup.Show();
        }

        private void onResultColorGroup(object sender, EventArgs e)
        {
            CustomForm form = (CustomForm)((Guna.UI.WinForms.GunaButton) sender).Parent;
            form.Close();
            Panel panel = createColorGroup(form.selectedLights);
            panel1.ScrollControlIntoView(panel);
            sendAllColors(false);
        }

        private void barSync_Click(object sender, EventArgs e)
        {
            SendToArduino("skipToBeat", Convert.ToString(beat));
        }

        private Color[][] GetCurrentColorsArray()
        {
            Color[][] colors = new Color[colorCount][];
            foreach (Control control in panel1.Controls)
            {
                int line = Convert.ToInt32(control.Tag.ToString());
                Panel panel = (Panel)control;
                colors[line] = new Color[4]; 
                foreach (Control button in panel.Controls)
                {
                    string buttonTag = button.Tag.ToString();
                    if (!buttonTag.Equals("Remove"))
                    {
                        int column = Convert.ToInt32(buttonTag);
                        colors[line][column] = button.ForeColor;
                    }
                }
            }
            return colors;
        }

        private void newPreset_Click(object sender, EventArgs e)
        {
            Preset preset = new Preset();
            preset.brightness = brightness.Value;
            preset.colorSpeed = colorSpeed.Value / 24;
            preset.fadeIn = fadeIn.Checked;
            preset.fadeOut = fadeOut.Checked;
            preset.colors = GetCurrentColorsArray();
            newPresetForm = new CustomForm();
            newPresetForm.Icon = Icon;
            newPresetForm.Size = new Size(300, 400);
            newPresetForm.CreatePresetDialog(preset);
            newPresetForm.setOnResultMethod(onResultNewPreset);
            newPresetForm.Title = "New Preset";
            newPresetForm.Show();
        }

        private void onResultNewPreset(object sender, EventArgs e)
        {
            Preset preset = newPresetForm.CreatePreset();
            newPresetForm.Close();
            if (preset != null) preset.Save();
        }

        private void presetManagerButton_Click(object sender, EventArgs e)
        {
            PresetManager presetManager = new PresetManager();
            presetManager.Show();
        }
    }
}


