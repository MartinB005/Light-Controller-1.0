using System;
using System.Collections.Generic;
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
        private int beat;
        private int anotherDeskBeat;
        private int totalBeats;
        private int anotherDeskBeats;
        private int comparingBpm;
        private int speedMemory;
        private int speedAtPresetStart;
        private int beatDistance;
        private int colorCount;
        private int selectedPreset;
        private int[][] colorNumber;
        private int virtualDistance;
        private bool playingDesk1;
        private bool disableChanging;
        private bool dragging;
        private bool detectorRunning;
        private bool speedRead;
        private bool locked;
        private bool sendingPresetData;
        private bool virtualBeatsActive;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Stopwatch beat8Time;
        private Stopwatch beatComparer;
        private PerformanceCounter cpuWatcher;
        private PerformanceCounter cpuController;
        private PerformanceCounter memoryUsage;
        private PresetManager presetManager;
        private CustomForm newPresetForm;
        public List<Preset> queue;
        private Preset playingPreset;
        public static SerialPort port;
        private String keyboardNumber = "";

        public MainGUI()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) portSelection.Items.Insert(0, port);
            cpuWatcher = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuController = new PerformanceCounter("Process", "% Processor Time", "Light Controller 1.0");
            memoryUsage = new PerformanceCounter("Memory", "Available MBytes");
            FormBorderStyle = FormBorderStyle.None;
            RootColorButtons();
            WatchCpuUsage(100, true);
            Paint += OnPaint;
            queue = new List<Preset>();
        }

        private void portSelection_Click(object sender, EventArgs e)
        {
            portSelection.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) portSelection.Items.Insert(0, port);
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
            for (int i = 0; i < 4; i++) CreateColorGroup(lights);
        }

        private Panel CreateColorGroup(bool[] lights)
        {
            Panel linePanel = new Panel();
            int scroll = panel1.VerticalScroll.Value;
            linePanel.Location = new Point(0, 45 * colorCount - scroll);
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
            button.Click += RemoveGroupClick;
            return button;
        }

        private void SelectPort(object sender, EventArgs e)
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
            Application.Exit();
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
            colorR = Convert.ToInt32(e.NewValue * 2.55);
            progressBar.ProgressMaxColor = Color.FromArgb(colorR, colorG, colorB);
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            UnselectPresets();
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

        private void TrackBars_ScrollingStoped(object sender, MouseEventArgs e)
        {
            foreach (Control control in queueList.Controls) CheckPresetStatus(control, false);
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

        internal void UpdateQueue()
        {
            queueList.Controls.Clear();
            int positionY = 0;
            colorNumber = new int[queue.Count][];
            for (int i = 0; i < queue.Count; i++)
            {
                colorNumber[i] = new int[4];
                Preset preset = queue[i];
                Panel panel = PresetManager.CreatePresetPanel(preset, true);
                int scroll = queueList.VerticalScroll.Value;
                panel.Location = new Point(0, positionY - scroll);
                int scrollBar = queue.Count > 4 ? 18 : 0;
                panel.MaximumSize = new Size(queueList.Width - scrollBar, 150);
                panel.AutoSize = true;
                panel.Tag = i;
                queueList.Controls.Add(panel);
                positionY += panel.Height;
                setClickFocusToControl(panel);
                CheckPresetStatus(panel, true);
                Label play = CreatePlaySymbol();
                panel.Controls.Add(play);
                play.BringToFront();
                foreach (Control control in panel.Controls) setClickFocusToControl(control);
                presetTools.Visible = selectedPreset >= 0 && selectedPreset < queue.Count;
            }
            clear.Enabled = queue.Count > 0;
            if (queue.Count == 0) queueList.Controls.Add(noPresets);
        }

        private Label CreatePlaySymbol()
        {
            Label label = new Label();
            label.Text = "▶";
            label.Tag = "playing";
            label.ForeColor = Color.FromArgb(100, 255, 100);
            label.Font = new Font(label.Font.FontFamily, 15);
            label.Location = new Point(2, 50);
            label.Visible = false;
            label.AutoSize = true;
            return label;
        }

        private void setClickFocusToControl(Control control)
        {
            control.BackColor = Color.Transparent;
            control.MouseEnter += panel_MouseEnter;
            control.MouseLeave += panel_MouseLeave;
            control.MouseDown += panel_MouseDown;
            control.MouseUp += panel_MouseUp;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent;
            if (playingPreset == queue[Convert.ToInt32(panel.Tag.ToString())])
                panel.BackColor = Color.FromArgb(50, 100, 255, 150);
            else panel.BackColor = Color.FromArgb(50, 255, 255, 255);
            foreach (Control control in panel.Controls) control.BackColor = Color.Transparent;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent;
            int tag = Convert.ToInt32(panel.Tag.ToString());
            CheckPresetStatus(panel, false);
        }

        private void panel_MouseUp(object sender, EventArgs e)
        {
            UnselectPresets();
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent;
            foreach (Control control in panel.Controls) control.BackColor = Color.Transparent;
            selectedPreset = Convert.ToInt32(panel.Tag.ToString());
            presetTools.Visible = true;
            CheckPresetStatus(panel, false);
        }

        private void panel_MouseDown(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent;
            panel.BackColor = Color.FromArgb(50, 150, 150, 150);
        }

        private void UnselectPresets()
        {
            presetTools.Visible = false;
            selectedPreset = -1;
            foreach (Control control in queueList.Controls)
                CheckPresetStatus(control, false);
        }

        private void BackgroundMethod()
        {
            while (detectorRunning)
            {
                CaptureApplication("virtualdj");
                Thread.Sleep(1);
            }
        }

        private void ButtonsDesk_Change(object sender, EventArgs e)
        {
            if (!disableChanging) ChangeDecks();
        }

        private void ChangeDecks()
        {
            anotherDeskBeats = 0;
            disableChanging = true;
            playingDesk1 = !playingDesk1;
            Label[] labels = new Label[] { beat1, beat2, beat3, beat4 };
            foreach (Label label in labels)
                label.ForeColor = playingDesk1 ? Color.MediumTurquoise : Color.Red;
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
            if (displayView.Text.Equals(text))
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
                    graphics.CopyFromScreen(590, 0, 0, 0, new Size(bmp.Width, bmp.Height),
                        CopyPixelOperation.SourceCopy);
                    detectBeat(bmp);
                }
            }
            catch
            {

            }

        }

        private void detectBeat(Bitmap bitmap)
        {
            int posY = playingDesk1 ? 10 : 20;
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
                        onBeat();
                        this.beat = beat;
                        virtualBeatsActive = false;
                    }
                }
            }
            if (auto.Checked) CheckAnotherDesk(bitmap);
            else if (disableChanging) disableChanging = false;
        }

        private void onBeat()
        {
            totalBeats++;
            SendToArduino("beat", Convert.ToString(beat));
            gunaLabel1.Invoke(new Action(() => gunaLabel1.Text = Convert.ToString(beat)));
            QueueNextBeat();
            if (presetManager != null) presetManager.nextBeat();
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

        public void tapBeat(int distance)
        {
            totalBeats = 0;
            if((distance > 300) && (distance < 1000))
            if(beat8Time == null) beat8Time = Stopwatch.StartNew();
            if(beatComparer == null) beatComparer = Stopwatch.StartNew();
            virtualDistance = beatDistance = distance;
            onBeat();
            beat = 0;
            if (!virtualBeatsActive) virtualBeat();
            virtualBeatsActive = true;
        }

        private async void virtualBeat()
        {
            Console.WriteLine(virtualDistance);
            beat++;
            if (beat > 4) beat = 1;
            onBeat();
            await Task.Delay(virtualDistance);
            if(virtualBeatsActive) virtualBeat();
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
                    if (anotherDeskBeat != beat)
                    {
                        double bpm = 60d / (beatComparer.ElapsedMilliseconds) * 1000;
                        if ((bpm > 65) && (bpm < 175))
                        {
                            if ((!disableChanging) && ((anotherDeskBeats >= 8)
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
                    if (port.IsOpen) SendAllColors(true);
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
            if ((!sendingPresetData) || (key.Contains("setColor")) || (key.Equals("commands")) || (key.Equals("colorCount")))
            {
                if ((port != null) && (port.IsOpen))
                    port.Write("-" + key + ":" + data + ">");
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string incomingData = sp.ReadLine();
                string value = incomingData.Substring(incomingData.IndexOf(':') + 1);
                string key = incomingData.Substring(1, incomingData.IndexOf(':') - 1);
                switch (key)
                {
                    case "audio":
                        progressBar.Value = Convert.ToInt32(value);
                        break;
                    case "display":
                        if (ScrollTrackBar(value))
                            ShowOnDisplay(value);
                        break;
                    case "lights":
                        int number = Convert.ToInt32(value.Substring(0, value.IndexOf(">")));
                        UpdateLightView(number, GetLightColor(value));
                        break;
                    case "selection":
                        setSelection(Convert.ToInt32(value));
                        break;
                    case "button":
                        buttonPress(value);
                        break;
                    case "keyboard":
                        onKeyPress(value.Substring(0, 1));
                        break;
                    default:
                        Console.WriteLine(key);
                        break;
                }
                if ((CustomForm.serialMonitor != null) && (!key.Equals("audio")))
                    CustomForm.serialMonitor.Invoke(new Action(()
                         => CustomForm.serialMonitor.Text += "\n" + incomingData));
            }
            catch
            {
                Console.WriteLine("error: " + e.ToString());
            }
        }

        private bool ScrollTrackBar(string valueText)
        {
            string value = valueText.Substring(0, valueText.Length - 1);
            value = value.Substring(value.IndexOf(": ") + 2);
            if (valueText.Contains("Brightness"))
            {
                brightness.Value = Convert.ToInt32(value);
                return true;
            }
            if (valueText.Contains("Color speed"))
            {
                String[] values = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
                int colorSpeedValue = Array.IndexOf(values, value);
                if (colorSpeed.Value != colorSpeedValue)
                {
                    if ((!speedRead) && (playingPreset != null))
                    {
                        speedAtPresetStart = colorSpeedValue;
                        speedRead = locked = true;
                        SendToArduino("locked", "True");
                    }
                    else if ((!locked) || (speedAtPresetStart != colorSpeedValue))
                    {
                        colorSpeed.Value = colorSpeedValue * 24;
                        SendToArduino("colorSpeed", Convert.ToString(colorSpeedValue));
                        SendToArduino("locked", "False");
                        locked = false;
                        return true;
                    }
                }
            }
            else return true;
            return false;
        }

        private void setSelection(int potentiometerValue)
        {
            if (PresetManager.activated) presetManager.scrollSelection(potentiometerValue);
            else
            {
                int selection = potentiometerValue / ((980 / queue.Count) + 20);
                if (selection != selectedPreset)
                {
                    selectedPreset = selection;
                    foreach (Control control in queueList.Controls) CheckPresetStatus(control, false);
                    presetTools.Invoke(new Action(() => presetTools.Visible = true));
                }
            }
        }

        private void buttonPress(string button)
        {
            if (button.StartsWith("startNext"))
            {
                if (PresetManager.activated) presetManager.addSelectedPresetsToQueue();
                else startNext.Invoke(new Action(() => startNext.PerformClick()));
            }
        }

        private void onKeyPress(string key)
        {
            if (key.Equals("*"))
            {
                if (PresetManager.activated) presetManager.Invoke(new Action(() => presetManager.Close()));
                else presetManagerButton.Invoke(new Action(() => presetManagerButton.PerformClick()));
            }
            else if (key.Equals("#"))
            {
                if ((selectedPreset >= 0) && (queue.Count > 0))
                    Invoke(new Action(() => startPreset(queue[selectedPreset])));
            }
            else
            {
                if (keyboardNumber.Length < 4)
                {
                    keyboardNumber += key;
                    StartPresetNumber(Convert.ToInt32(keyboardNumber));
                }
            }
        }

        private async void StartPresetNumber(int number)
        {
            ShowOnDisplay("Preset " + keyboardNumber);
            await Task.Delay(2100);
            Console.WriteLine(keyboardNumber + "," + number);
            if (Convert.ToInt32(keyboardNumber) == number)
            {
                if ((number > 0) && (number - 1 < queue.Count))
                    Invoke(new Action(() => startPreset(queue[number - 1])));
                else ShowOnDisplay("Preset does not exist");
                keyboardNumber = "";
            }
        }

        private void UpdateLightView(int number, Color color)
        {
            Label[] lights = { light1, light2, light3, light4 };
            lights[number - 1].ForeColor = color;
            foreach (Control control in queueList.Controls)
                foreach (Control light in control.Controls)
                {
                    int lightNumber = -1;
                    bool isLight = light.Tag != null && int.TryParse(light.Tag.ToString(), out lightNumber);
                    if ((isLight) && (queue.IndexOf(playingPreset) == Convert.ToInt32(control.Tag.ToString())))
                        light.Invoke(new Action(() => light.ForeColor = lights[lightNumber].ForeColor));

                }
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

        private async void SendAllColors(bool connecting)
        {
            if (connecting) displayView.Invoke(new Action(() => displayView.Text = "Connecting..."));
            Console.WriteLine("send");
            int[] colorCount = new int[4];
            foreach (Control control in panel1.Controls)
            {
                int line = Convert.ToInt32(control.Tag.ToString());
                Panel panel = (Panel)control;
                foreach (Control button in panel.Controls)
                {
                    string buttonTag = button.Tag.ToString();
                    if (!buttonTag.Equals("Remove"))
                    {
                        int column = Convert.ToInt32(buttonTag);
                        Color color = button.ForeColor;
                        Console.WriteLine(color.R + "/" + color.G + "/" + color.B);
                        SendToArduino("setColor", column + "," + line + ">" + color.R +
                            "/" + color.G + "/" + color.B);
                        colorCount[column]++;
                        await Task.Delay(10);
                    }
                }
            }
            SendToArduino("colorCount", colorCount[0] + "/" +
                colorCount[1] + "/" + colorCount[2] + "/" + colorCount[3] + "/");
            if (connecting) ShowOnDisplay("Connected");
            await Task.Delay(10);
            SendToArduino("fadeIn", Convert.ToString(fadeIn.Checked));
            await Task.Delay(10);
            SendToArduino("fadeOut", Convert.ToString(fadeOut.Checked));
            Console.WriteLine(colorCount[0] + "/" +
                colorCount[1] + "/" + colorCount[2] + "/" + colorCount[3] + "/");
            sendingPresetData = false;
        }

        private void fadeOut_CheckedChanged(object sender, EventArgs e)
        {
            SendToArduino("fadeOut", Convert.ToString(fadeOut.Checked));
            foreach (Control control in queueList.Controls) CheckPresetStatus(control, false);
        }

        private void fadeIn_CheckedChanged(object sender, EventArgs e)
        {
            SendToArduino("fadeIn", Convert.ToString(fadeIn.Checked));
            foreach (Control control in queueList.Controls) CheckPresetStatus(control, false);
        }

        private void RemoveGroupClick(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton button = (Guna.UI.WinForms.GunaButton)sender;
            removeColorGroup(button);
            SendAllColors(false);
        }

        private void removeColorGroup(Guna.UI.WinForms.GunaButton button)
        {
            int line = Convert.ToInt32(button.Parent.Tag.ToString());
            panel1.Invoke(new Action(() => panel1.Controls.Remove(button.Parent)));
            colorCount--;
            foreach (Control control in panel1.Controls)
            {
                int lineNumber = Convert.ToInt32(control.Tag.ToString());
                if (lineNumber > line)
                {
                    control.Invoke(new Action(()
                        => control.Location = new Point(0, control.Location.Y - control.Height - 5)));
                    control.Invoke(new Action(()
                       => control.Tag = lineNumber - 1));
                }
            }
            panel1.Invoke(new Action(() => panel1.Controls.Remove(button)));
        }

        private void newGroup_Click(object sender, EventArgs e)
        {
            CustomForm newGroup = new CustomForm();
            newGroup.Icon = Icon;
            newGroup.CreateLightsChooser();
            newGroup.Size = new Size(300, 150);
            newGroup.Title = newGroup.Text = "New Color Group";
            newGroup.setOnResultMethod(onResultColorGroup);
            newGroup.Show();
        }

        private void onResultColorGroup(object sender, EventArgs e)
        {
            CustomForm form = (CustomForm)((Guna.UI.WinForms.GunaButton)sender).Parent;
            form.Close();
            Panel panel = CreateColorGroup(form.selectedLights);
            panel1.ScrollControlIntoView(panel);
            SendAllColors(false);
        }

        private void barSync_Click(object sender, EventArgs e)
        {
            SendToArduino("skipToBeat", Convert.ToString(beat));
        }

        private ColorHolder[][] GetCurrentColorsArray()
        {
            ColorHolder[][] colors = new ColorHolder[colorCount][];
            foreach (Control control in panel1.Controls)
            {
                int line = Convert.ToInt32(control.Tag.ToString());
                Panel panel = (Panel)control;
                colors[line] = new ColorHolder[4];
                foreach (Control button in panel.Controls)
                {
                    string buttonTag = button.Tag.ToString();
                    if (!buttonTag.Equals("Remove"))
                    {
                        int column = Convert.ToInt32(buttonTag);
                        colors[line][column] = ColorHolder.fromColor(button.ForeColor);
                    }
                }
            }
            return colors;
        }

        private void newPreset_Click(object sender, EventArgs e)
        {
            CreateNewPreset();
        }

        public void CreateNewPreset()
        {
            Preset preset = new Preset();
            preset.name = "Preset 1";
            preset.brightness = brightness.Value;
            preset.colorSpeed = colorSpeed.Value / 24;
            preset.fadeIn = fadeIn.Checked;
            preset.fadeOut = fadeOut.Checked;
            preset.colors = GetCurrentColorsArray();
            ShowPresetOptions(preset, false);
        }

        public void ShowPresetOptions(Preset preset, bool edit)
        {
            if (newPresetForm != null) newPresetForm.Close();
            newPresetForm = new CustomForm();
            newPresetForm.Icon = Icon;
            newPresetForm.Size = new Size(300, 400);
            newPresetForm.CreatePresetDialog(preset);
            if (edit) newPresetForm.setOnResultMethod(onResultEditPreset);
            else newPresetForm.setOnResultMethod(onResultNewPreset);
            newPresetForm.Title = newPresetForm.Text = edit ? "Edit Preset" : "New Preset";
            newPresetForm.Show();
        }

        private void onResultNewPreset(object sender, EventArgs e)
        {
            Preset preset = newPresetForm.CreatePreset();
            newPresetForm.Close();
            if (preset != null) preset.Save();
            if (presetManager != null) presetManager.LoadPresets();
        }

        private void onResultEditPreset(object sender, EventArgs e)
        {
            if (presetManager != null)
            {
                Preset oldPreset = newPresetForm.GetShowedPreset();
                oldPreset.Delete();
                Preset preset = newPresetForm.CreatePreset();
                newPresetForm.Close();
                if (preset != null) preset.Save();
                if (presetManager != null) presetManager.LoadPresets();
            }
        }

        private void presetManagerButton_Click(object sender, EventArgs e)
        {
            if (presetManager != null) presetManager.Close();
            presetManager = new PresetManager(this);
            presetManager.Show();
        }

        public void startPreset(Preset preset)
        {
            sendingPresetData = true;
            string commands = String.Format("colorSpeed?{0}|brightness?{1}|fadeIn?{2}" +
                "|fadeOut?{3}|barSync?{4}|", preset.colorSpeed, preset.brightness, preset.fadeIn,
                preset.fadeOut, preset.barSync);
            SendToArduino("commands", commands);
            displayView.Invoke(new Action(() => displayView.Text = String.Format("{0} is Loading...", preset.name)));
            bool[] lights = new bool[4];
            for (int b = 0; b < 4; b++) lights[b] = true;
            for (int i = colorCount; i < preset.colors.Length; i++)
                Invoke(new Action(() => CreateColorGroup(lights)));
            UpdateColors(preset);
            colorSpeed.Value = preset.colorSpeed * 24;
            brightness.Value = preset.brightness;
            speedRead = false;
            if (queue.Contains(preset))
            {
                playingPreset = preset;
                foreach (Control control in queueList.Controls) CheckPresetStatus(control, true);
            }
        }

        private async void UpdateColors(Preset preset)
        {
            await Task.Delay(20);
            List<Control> linesToRemove = new List<Control>();
            foreach (Control control in panel1.Controls)
            {
                int line = Convert.ToInt32(control.Tag.ToString());
                Panel panel = (Panel)control;
                foreach (Control button in panel.Controls)
                {
                    string buttonTag = button.Tag.ToString();
                    if (!buttonTag.Equals("Remove"))
                    {
                        int column = Convert.ToInt32(buttonTag);
                        if (line < preset.colors.Length)
                        {
                            Color color = preset.colors[line][column].createColor();
                            button.Invoke(new Action(() => button.ForeColor = color));
                        }
                    }
                    else if (line >= preset.colors.Length)
                        linesToRemove.Add(button);
                }

            }
            foreach (Control remove in linesToRemove)
                removeColorGroup((Guna.UI.WinForms.GunaButton)remove);
            await Task.Delay(20);
            SendAllColors(false);
            fadeIn.Invoke(new Action(() => fadeIn.Checked = preset.fadeIn));
            fadeOut.Invoke(new Action(() => fadeOut.Checked = preset.fadeOut));
            ShowOnDisplay("Preset " + preset.name + " started");
        }

        private void StartPresetButton_Click(object sender, EventArgs e)
        {
            startPreset(queue[selectedPreset]);
        }

        private void CheckPresetStatus(Control panel, bool playingChange)
        {
            try
            {
                int tag = Convert.ToInt32(panel.Tag.ToString());
                if (queue.Count > 0)
                {
                    bool playing = playingPreset == queue[tag];
                    bool selected = selectedPreset == tag;
                    if ((playing) && (selected))
                        panel.BackColor = Color.FromArgb(50, 100, 255, 150);
                    else if (selected)
                        panel.BackColor = Color.FromArgb(50, 255, 255, 255);
                    else if (playing) panel.BackColor = Color.FromArgb(50, 0, 255, 50);
                    else panel.BackColor = Color.Transparent;
                    if (playingChange)
                    {
                        foreach (Control control in panel.Controls)
                        {
                            int number;
                            if ((control.Tag != null) && (control.Tag.ToString().Equals("playing")))
                                ShowPlayingSymbol(control, queue[tag], false);
                            else if ((control.Tag != null) && (int.TryParse(control.Tag.ToString(), out number))
                                && (tag < queue.IndexOf(playingPreset)))
                                control.ForeColor = Color.DarkGray;
                        }
                    }
                    if ((selected) || (playing))
                        queueList.Invoke(new Action(() => queueList.ScrollControlIntoView(panel))); ;
                    if (!playing) comparePreset(panel, queue[tag]);
                }
            }
            catch { }
        }

        private void comparePreset(Control panel, Preset preset)
        {

            foreach (Control control in panel.Controls)
                if ((control.Tag != null) && (control.Tag.ToString().Equals("description")))
                    control.Text = getDifferentValues(preset);
        }

        private string getDifferentValues(Preset preset)
        {
            string description = "";
            if (playingPreset == preset) return "Running";
            else if (queue.IndexOf(playingPreset) > queue.IndexOf(preset)) return "Ended";
            string[] keys = { "colorSpeed", "brightness", "fadeIn", "fadeOut" };
            string[] currentValues = getCurrentValuesArray();
            string[] presetValues = getValuesArray(preset);
            for (int i = 0; i < keys.Length; i++)
                if (!currentValues[i].Equals(presetValues[i]))
                {
                    if (description.Length > 30)
                    {
                        description += "...";
                        break;
                    }
                    int currentValue, presetValue = -1;
                    bool result = Int32.TryParse(currentValues[i], out currentValue)
                        && Int32.TryParse(presetValues[i], out presetValue);
                    Console.WriteLine(currentValue);
                    Console.WriteLine(presetValue);
                    if ((!result) || (currentValue == presetValue))
                        description += keys[i] + ": " + presetValues[i] + ", ";
                    else
                    {
                        string comparer = currentValue > presetValue ? "-" : "+";
                        description += keys[i] + ": " + comparer
                            + Math.Abs(currentValue - presetValue) + ", ";
                    }
                }
            if ((description.Length > 3) && (!description.EndsWith("...")))
                description = description.Substring(0, description.Length - 2);
            if (description.Equals("")) description = "Already set";
            return description;
        }


        private string[] getValuesArray(Preset preset)
        {
            string[] speeds = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            string[] values = {speeds[preset.colorSpeed], Convert.ToString(preset.brightness),
                preset.fadeIn ? "ON" : "OFF", preset.fadeOut ? "ON" : "OFF" };
            return values;
        }

        private string[] getCurrentValuesArray()
        {
            string[] speeds = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            string[] values = {speeds[colorSpeed.Value / 24], Convert.ToString(brightness.Value),
                fadeIn.Checked ? "ON" : "OFF", fadeOut.Checked  ? "ON" : "OFF" };
            return values;
        }


        private async void ShowPlayingSymbol(Control control, Preset preset, bool show)
        {
            control.Visible = show;
            await Task.Delay(500);
            if (playingPreset == preset) ShowPlayingSymbol(control, preset, !show);
        }

        private void queueList_Click(object sender, EventArgs e)
        {
            UnselectPresets();
        }

        private void startNext_Click(object sender, EventArgs e)
        {
            int index = queue.IndexOf(playingPreset);
            if (index < queue.Count - 1)
                startPreset(queue[index + 1]);
            else ShowOnDisplay("This is last Preset");
        }

        private void removePreset_Click(object sender, EventArgs e)
        {
            if ((selectedPreset >= 0) && (selectedPreset < queue.Count))
            {
                queue.Remove(queue[selectedPreset]);
                UpdateQueue();
            }
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            if (selectedPreset > 0)
            {
                Preset preset = queue[selectedPreset];
                queue.Remove(preset);
                selectedPreset -= 1;
                queue.Insert(selectedPreset, preset);
                UpdateQueue();
            }
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            if (selectedPreset < queue.Count - 1)
            {
                Preset preset = queue[selectedPreset];
                queue.Remove(preset);
                selectedPreset += 1;
                queue.Insert(selectedPreset, preset);
                UpdateQueue();
            }
        }

        private void commandButton_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.Size = new Size(500, 300);
            form.CreateSerialController();
            form.Icon = Icon;
            form.Title = form.Text = "Serial Controller";
            form.Show();
        }

        public async void QueueNextBeat()
        {
            await Task.Run(new Action(() =>
            {
                foreach (Control preset in queueList.Controls)
                {
                    int number = Convert.ToInt32(preset.Tag.ToString());
                    foreach (Control light in preset.Controls)
                    {
                        if (light.Tag != null)
                        {
                            int lightNumber;
                            bool isLight = int.TryParse(light.Tag.ToString(), out lightNumber);
                            if ((isLight) && (number > queue.IndexOf(playingPreset)))
                            {
                                try
                                {
                                    if (lightNumber < colorNumber[number].Length)
                                    {
                                        light.Invoke(new Action(() => light.ForeColor = queue[number]
                                        .colors[colorNumber[number][lightNumber]][lightNumber].createColor()));
                                        colorNumber[number][lightNumber]++;
                                        if (this.colorNumber[number][lightNumber] >= queue[number].colors.Length)
                                            colorNumber[number][lightNumber] = 0;
                                    }
                                }
                                catch { }
                            }
                        }
                    }
                }
            }));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            queue.Clear();
            UpdateQueue();
        }

        private async void WatchCpuUsage(int value, bool showValues)
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation annotation
             = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            int usage = Convert.ToInt32(cpuWatcher.NextValue());
            if (showValues)
            {
                long memory = Convert.ToInt64(new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory.ToString());
                cpuUsageLabel.Text = String.Format("Total: {0}%\nLight Controller: {1}%\nMemory Usage: {2}MB",
                   usage, Convert.ToInt32(cpuController.NextValue()), memory / 1000000 - memoryUsage.NextValue());
            }
            annotation.X = 100;
            annotation.Y = 100 - usage;
            annotation.Width = -5;
            annotation.Height = value - 100 + usage;
            annotation.LineWidth = 2;
            annotation.LineColor = Color.Gainsboro;
            foreach (System.Windows.Forms.DataVisualization.Charting.LineAnnotation line
                in cpuUsage.Annotations) line.X -= 5;
            cpuUsage.Annotations.Add(annotation);
            if (cpuUsage.Annotations[0].X < -5) cpuUsage.Annotations.RemoveAt(0);
            await Task.Delay(250);
            WatchCpuUsage(100 - usage, !showValues);
        }

        private void virtualBeats_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.Size = new Size(300, 300);
            form.CreateBeatTapper(this);
            form.Show();
        }
    }
}


