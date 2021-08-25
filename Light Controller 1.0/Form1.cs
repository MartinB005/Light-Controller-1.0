using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Light_Controller_1._0
{

    public partial class Form1 : Form
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
        private bool playingDesk1;
        private bool disableChanging;
        private bool dragging;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private SerialPort port;

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports) portSelection.Items.Insert(0, port);
            FormBorderStyle = FormBorderStyle.None;
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
                if(!connectedBefore) port.Close();
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            anotherDeskBeats = 0;
            playingDesk1 = true;
            beat8Time = Stopwatch.StartNew();
            beatComparer = Stopwatch.StartNew();
            startButton.Text = "STOP";
            var ts = new ThreadStart(BackgroundMethod);
            var backgroundThread = new Thread(ts);
            backgroundThread.Start();
        }

        void BackgroundMethod()
        {
            while (true)
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
                //var proc = Process.GetProcessesByName(procName)[0];
                //var rect = new User32.Rect();
                //User32.GetWindowRect(proc.MainWindowHandle, ref rect);
                //int width = rect.right - rect.left;
                //int height = rect.bottom - rect.top;
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
                            double fullBpm = 60d / (beat8Time.ElapsedMilliseconds / 8) * 1000;
                            string bpmValue = Convert.ToString(Math.Round(fullBpm, 0));
                            beat2.Invoke(new Action(() => bpm.Text = "BPM : " + bpmValue));
                            beat8Time = Stopwatch.StartNew();
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
                    if (port.IsOpen) port.Close();
                    else port.Open();
                    connect.Text = port.IsOpen ? "DISCONNECT" : "CONNECT";
                    connect.Width = port.IsOpen ? 155 : 125;
                    connect.BackColor = port.IsOpen ? Color.LightGray : Color.DodgerBlue;
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
                port.Write("-" + key + ":" + data);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                SerialPort sp = (SerialPort)sender;
                string incomingData = sp.ReadLine();
                Console.WriteLine(incomingData);
                int value = Convert.ToInt32(incomingData.Substring(incomingData.IndexOf(':') + 1));
                progressBar.Value = value;
            } catch
            {
                
            }
        }
    }
}
