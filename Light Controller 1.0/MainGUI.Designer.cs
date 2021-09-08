namespace Light_Controller_1._0
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.progressBar = new Guna.UI.WinForms.GunaVProgressBar();
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.TrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TrackBar3 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gunaColorTransition2 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.gunaColorTransition3 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.beat1 = new Guna.UI.WinForms.GunaLabel();
            this.beat2 = new Guna.UI.WinForms.GunaLabel();
            this.beat3 = new Guna.UI.WinForms.GunaLabel();
            this.beat4 = new Guna.UI.WinForms.GunaLabel();
            this.bpm = new Guna.UI.WinForms.GunaLabel();
            this.startButton = new Guna.UI.WinForms.GunaButton();
            this.displayView = new Guna.UI.WinForms.GunaLabel();
            this.desk1 = new Guna.UI.WinForms.GunaRadioButton();
            this.desk2 = new Guna.UI.WinForms.GunaRadioButton();
            this.auto = new Guna.UI.WinForms.GunaCheckBox();
            this.close = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.minimize = new Guna.UI.WinForms.GunaLabel();
            this.maximize = new Guna.UI.WinForms.GunaLabel();
            this.portSelection = new Guna.UI.WinForms.GunaComboBox();
            this.portText = new Guna.UI.WinForms.GunaLabel();
            this.connect = new Guna.UI.WinForms.GunaButton();
            this.brightness = new Guna.UI.WinForms.GunaVTrackBar();
            this.bgText = new Guna.UI.WinForms.GunaLabel();
            this.colorSpeed = new Guna.UI.WinForms.GunaVTrackBar();
            this.speedText = new Guna.UI.WinForms.GunaLabel();
            this.light1 = new Guna.UI.WinForms.GunaLabel();
            this.light2 = new Guna.UI.WinForms.GunaLabel();
            this.light3 = new Guna.UI.WinForms.GunaLabel();
            this.light4 = new Guna.UI.WinForms.GunaLabel();
            this.fadeIn = new Guna.UI.WinForms.GunaCheckBox();
            this.fadeOut = new Guna.UI.WinForms.GunaCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newGroup = new Guna.UI.WinForms.GunaButton();
            this.barSync = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.presetValues = new Guna.UI.WinForms.GunaLabel();
            this.presetName = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.presetManagerButton = new Guna.UI.WinForms.GunaButton();
            this.newPreset = new Guna.UI.WinForms.GunaButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BorderColor = System.Drawing.Color.Black;
            this.progressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBar.IdleColor = System.Drawing.Color.DarkGray;
            this.progressBar.Location = new System.Drawing.Point(12, 347);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressMaxColor = System.Drawing.Color.OrangeRed;
            this.progressBar.ProgressMinColor = System.Drawing.Color.Chartreuse;
            this.progressBar.Size = new System.Drawing.Size(23, 200);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 100;
            // 
            // gunaColorTransition1
            // 
            this.gunaColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.gunaColorTransition1.EndColor = System.Drawing.Color.Blue;
            this.gunaColorTransition1.StartColor = System.Drawing.Color.Red;
            // 
            // TrackBar2
            // 
            this.TrackBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TrackBar2.HoverState.Parent = this.TrackBar2;
            this.TrackBar2.Location = new System.Drawing.Point(535, 473);
            this.TrackBar2.Name = "TrackBar2";
            this.TrackBar2.Size = new System.Drawing.Size(189, 23);
            this.TrackBar2.TabIndex = 4;
            this.TrackBar2.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.TrackBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar2_Scroll);
            // 
            // TrackBar3
            // 
            this.TrackBar3.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar3.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.TrackBar3.HoverState.Parent = this.TrackBar3;
            this.TrackBar3.Location = new System.Drawing.Point(535, 450);
            this.TrackBar3.Name = "TrackBar3";
            this.TrackBar3.Size = new System.Drawing.Size(189, 23);
            this.TrackBar3.TabIndex = 5;
            this.TrackBar3.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.TrackBar3.Value = 30;
            this.TrackBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar3_Scroll);
            // 
            // TrackBar1
            // 
            this.TrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.TrackBar1.FillColor = System.Drawing.SystemColors.ScrollBar;
            this.TrackBar1.HoverState.Parent = this.TrackBar1;
            this.TrackBar1.Location = new System.Drawing.Point(535, 494);
            this.TrackBar1.Name = "TrackBar1";
            this.TrackBar1.Size = new System.Drawing.Size(189, 23);
            this.TrackBar1.TabIndex = 6;
            this.TrackBar1.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.TrackBar1.Value = 30;
            this.TrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TrackBar1_Scroll);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel1.Location = new System.Drawing.Point(645, 457);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "Progress:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.White;
            this.colorDialog1.HelpRequest += new System.EventHandler(this.guna2TrackBar3_ValueChanged);
            // 
            // gunaColorTransition2
            // 
            this.gunaColorTransition2.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.gunaColorTransition2.EndColor = System.Drawing.Color.Blue;
            this.gunaColorTransition2.StartColor = System.Drawing.Color.Red;
            // 
            // gunaColorTransition3
            // 
            this.gunaColorTransition3.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.gunaColorTransition3.EndColor = System.Drawing.Color.MediumBlue;
            this.gunaColorTransition3.StartColor = System.Drawing.Color.LightGray;
            // 
            // beat1
            // 
            this.beat1.AutoSize = true;
            this.beat1.BackColor = System.Drawing.Color.Transparent;
            this.beat1.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.beat1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.beat1.Location = new System.Drawing.Point(8, -18);
            this.beat1.Margin = new System.Windows.Forms.Padding(0);
            this.beat1.Name = "beat1";
            this.beat1.Size = new System.Drawing.Size(65, 89);
            this.beat1.TabIndex = 9;
            this.beat1.Text = "•";
            this.beat1.Visible = false;
            // 
            // beat2
            // 
            this.beat2.AutoSize = true;
            this.beat2.BackColor = System.Drawing.Color.Transparent;
            this.beat2.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.beat2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.beat2.Location = new System.Drawing.Point(46, -18);
            this.beat2.Margin = new System.Windows.Forms.Padding(0);
            this.beat2.Name = "beat2";
            this.beat2.Size = new System.Drawing.Size(65, 89);
            this.beat2.TabIndex = 10;
            this.beat2.Text = "•";
            this.beat2.Visible = false;
            // 
            // beat3
            // 
            this.beat3.AutoSize = true;
            this.beat3.BackColor = System.Drawing.Color.Transparent;
            this.beat3.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.beat3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.beat3.Location = new System.Drawing.Point(84, -18);
            this.beat3.Margin = new System.Windows.Forms.Padding(0);
            this.beat3.Name = "beat3";
            this.beat3.Size = new System.Drawing.Size(65, 89);
            this.beat3.TabIndex = 11;
            this.beat3.Text = "•";
            this.beat3.Visible = false;
            // 
            // beat4
            // 
            this.beat4.AutoSize = true;
            this.beat4.BackColor = System.Drawing.Color.Transparent;
            this.beat4.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.beat4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.beat4.Location = new System.Drawing.Point(123, -18);
            this.beat4.Margin = new System.Windows.Forms.Padding(0);
            this.beat4.Name = "beat4";
            this.beat4.Size = new System.Drawing.Size(65, 89);
            this.beat4.TabIndex = 12;
            this.beat4.Text = "•";
            this.beat4.Visible = false;
            // 
            // bpm
            // 
            this.bpm.AutoSize = true;
            this.bpm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bpm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bpm.Location = new System.Drawing.Point(20, 148);
            this.bpm.Name = "bpm";
            this.bpm.Size = new System.Drawing.Size(38, 15);
            this.bpm.TabIndex = 13;
            this.bpm.Text = "BPM :";
            this.bpm.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // startButton
            // 
            this.startButton.AnimationHoverSpeed = 0.07F;
            this.startButton.AnimationSpeed = 0.03F;
            this.startButton.BaseColor = System.Drawing.Color.DodgerBlue;
            this.startButton.BorderColor = System.Drawing.Color.Black;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startButton.FocusedColor = System.Drawing.Color.Empty;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Image = null;
            this.startButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startButton.Location = new System.Drawing.Point(11, 198);
            this.startButton.Name = "startButton";
            this.startButton.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.startButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startButton.OnHoverForeColor = System.Drawing.Color.White;
            this.startButton.OnHoverImage = null;
            this.startButton.OnPressedColor = System.Drawing.Color.Black;
            this.startButton.Size = new System.Drawing.Size(79, 35);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "START";
            this.startButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // displayView
            // 
            this.displayView.AutoSize = true;
            this.displayView.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.displayView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayView.Location = new System.Drawing.Point(454, 18);
            this.displayView.Name = "displayView";
            this.displayView.Size = new System.Drawing.Size(29, 46);
            this.displayView.TabIndex = 15;
            this.displayView.Text = " ";
            // 
            // desk1
            // 
            this.desk1.BaseColor = System.Drawing.SystemColors.Control;
            this.desk1.Checked = true;
            this.desk1.CheckedOffColor = System.Drawing.Color.Gray;
            this.desk1.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.desk1.FillColor = System.Drawing.Color.White;
            this.desk1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desk1.Location = new System.Drawing.Point(25, 74);
            this.desk1.Name = "desk1";
            this.desk1.Size = new System.Drawing.Size(65, 20);
            this.desk1.TabIndex = 16;
            this.desk1.Text = "Desk 1";
            this.desk1.CheckedChanged += new System.EventHandler(this.ButtonsDesk_Change);
            // 
            // desk2
            // 
            this.desk2.BaseColor = System.Drawing.SystemColors.Control;
            this.desk2.CheckedOffColor = System.Drawing.Color.Gray;
            this.desk2.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.desk2.FillColor = System.Drawing.Color.White;
            this.desk2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desk2.Location = new System.Drawing.Point(25, 100);
            this.desk2.Name = "desk2";
            this.desk2.Size = new System.Drawing.Size(65, 20);
            this.desk2.TabIndex = 17;
            this.desk2.Text = "Desk 2";
            // 
            // auto
            // 
            this.auto.BaseColor = System.Drawing.Color.White;
            this.auto.Checked = true;
            this.auto.CheckedOffColor = System.Drawing.Color.Gray;
            this.auto.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.auto.FillColor = System.Drawing.Color.White;
            this.auto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.auto.Location = new System.Drawing.Point(99, 80);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(53, 20);
            this.auto.TabIndex = 18;
            this.auto.Text = "Auto";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close.Location = new System.Drawing.Point(946, -3);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 36);
            this.close.TabIndex = 18;
            this.close.Text = "✕";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.CloseWindow);
            this.close.MouseEnter += new System.EventHandler(this.ShowRed);
            this.close.MouseLeave += new System.EventHandler(this.HideRed);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel2.Location = new System.Drawing.Point(5, 557);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(38, 15);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "LEVEL";
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize.Location = new System.Drawing.Point(868, -3);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(37, 36);
            this.minimize.TabIndex = 20;
            this.minimize.Text = "–";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize.Click += new System.EventHandler(this.Minimize);
            this.minimize.MouseEnter += new System.EventHandler(this.ShowMinimizeBlue);
            this.minimize.MouseLeave += new System.EventHandler(this.HideMinimizeBlue);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.Transparent;
            this.maximize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.maximize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maximize.Location = new System.Drawing.Point(908, -3);
            this.maximize.Margin = new System.Windows.Forms.Padding(0);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(41, 36);
            this.maximize.TabIndex = 21;
            this.maximize.Text = "⬜";
            this.maximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maximize.Click += new System.EventHandler(this.Maximize);
            this.maximize.MouseEnter += new System.EventHandler(this.ShowMaximizeBlue);
            this.maximize.MouseLeave += new System.EventHandler(this.HideMaximizeBlue);
            // 
            // portSelection
            // 
            this.portSelection.BackColor = System.Drawing.Color.Transparent;
            this.portSelection.BaseColor = System.Drawing.Color.White;
            this.portSelection.BorderColor = System.Drawing.Color.Silver;
            this.portSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.portSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelection.FocusedColor = System.Drawing.Color.Empty;
            this.portSelection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.portSelection.ForeColor = System.Drawing.Color.Black;
            this.portSelection.FormattingEnabled = true;
            this.portSelection.Location = new System.Drawing.Point(61, 468);
            this.portSelection.Name = "portSelection";
            this.portSelection.OnHoverItemBaseColor = System.Drawing.Color.SteelBlue;
            this.portSelection.OnHoverItemForeColor = System.Drawing.Color.White;
            this.portSelection.Size = new System.Drawing.Size(121, 26);
            this.portSelection.TabIndex = 24;
            this.portSelection.SelectedIndexChanged += new System.EventHandler(this.selectPort);
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.portText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.portText.Location = new System.Drawing.Point(60, 450);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(32, 15);
            this.portText.TabIndex = 25;
            this.portText.Text = "Port:";
            // 
            // connect
            // 
            this.connect.AnimationHoverSpeed = 0.07F;
            this.connect.AnimationSpeed = 0.03F;
            this.connect.BaseColor = System.Drawing.Color.DodgerBlue;
            this.connect.BorderColor = System.Drawing.Color.Black;
            this.connect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.connect.FocusedColor = System.Drawing.Color.Empty;
            this.connect.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.connect.ForeColor = System.Drawing.Color.White;
            this.connect.Image = global::Light_Controller_1._0.Properties.Resources.arduino1;
            this.connect.ImageSize = new System.Drawing.Size(22, 22);
            this.connect.Location = new System.Drawing.Point(61, 395);
            this.connect.Name = "connect";
            this.connect.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.connect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.connect.OnHoverForeColor = System.Drawing.Color.White;
            this.connect.OnHoverImage = null;
            this.connect.OnPressedColor = System.Drawing.Color.Black;
            this.connect.Size = new System.Drawing.Size(125, 40);
            this.connect.TabIndex = 26;
            this.connect.Text = "CONNECT";
            this.connect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.connect.Click += new System.EventHandler(this.Connect);
            // 
            // brightness
            // 
            this.brightness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.brightness.Location = new System.Drawing.Point(820, 374);
            this.brightness.Name = "brightness";
            this.brightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brightness.Size = new System.Drawing.Size(30, 173);
            this.brightness.TabIndex = 27;
            this.brightness.TrackColor = System.Drawing.Color.DodgerBlue;
            this.brightness.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.brightness.TrackIdleColor = System.Drawing.Color.Silver;
            this.brightness.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.brightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.brigthnessTrackBar_Scroll);
            // 
            // bgText
            // 
            this.bgText.AutoSize = true;
            this.bgText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bgText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bgText.Location = new System.Drawing.Point(803, 563);
            this.bgText.Name = "bgText";
            this.bgText.Size = new System.Drawing.Size(62, 15);
            this.bgText.TabIndex = 28;
            this.bgText.Text = "Brightness";
            // 
            // colorSpeed
            // 
            this.colorSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorSpeed.Location = new System.Drawing.Point(744, 374);
            this.colorSpeed.Name = "colorSpeed";
            this.colorSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorSpeed.Size = new System.Drawing.Size(30, 173);
            this.colorSpeed.TabIndex = 29;
            this.colorSpeed.TrackColor = System.Drawing.Color.DodgerBlue;
            this.colorSpeed.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.colorSpeed.TrackIdleColor = System.Drawing.Color.Silver;
            this.colorSpeed.TrackPressedColor = System.Drawing.Color.DodgerBlue;
            this.colorSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedTrackBar_Scroll);
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.speedText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.speedText.Location = new System.Drawing.Point(726, 563);
            this.speedText.Name = "speedText";
            this.speedText.Size = new System.Drawing.Size(71, 15);
            this.speedText.TabIndex = 30;
            this.speedText.Text = "Color Speed";
            // 
            // light1
            // 
            this.light1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light1.BackColor = System.Drawing.Color.Transparent;
            this.light1.Font = new System.Drawing.Font("Segoe UI", 90F);
            this.light1.ForeColor = System.Drawing.Color.Black;
            this.light1.Location = new System.Drawing.Point(435, 27);
            this.light1.Margin = new System.Windows.Forms.Padding(0);
            this.light1.Name = "light1";
            this.light1.Size = new System.Drawing.Size(300, 120);
            this.light1.TabIndex = 31;
            this.light1.Text = "•";
            // 
            // light2
            // 
            this.light2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light2.BackColor = System.Drawing.Color.Transparent;
            this.light2.Font = new System.Drawing.Font("Segoe UI", 90F);
            this.light2.ForeColor = System.Drawing.Color.Black;
            this.light2.Location = new System.Drawing.Point(502, 27);
            this.light2.Margin = new System.Windows.Forms.Padding(0);
            this.light2.Name = "light2";
            this.light2.Size = new System.Drawing.Size(300, 120);
            this.light2.TabIndex = 32;
            this.light2.Text = "•";
            // 
            // light3
            // 
            this.light3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light3.BackColor = System.Drawing.Color.Transparent;
            this.light3.Font = new System.Drawing.Font("Segoe UI", 90F);
            this.light3.ForeColor = System.Drawing.Color.Black;
            this.light3.Location = new System.Drawing.Point(569, 27);
            this.light3.Margin = new System.Windows.Forms.Padding(0);
            this.light3.Name = "light3";
            this.light3.Size = new System.Drawing.Size(300, 120);
            this.light3.TabIndex = 33;
            this.light3.Text = "•";
            // 
            // light4
            // 
            this.light4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.light4.BackColor = System.Drawing.Color.Transparent;
            this.light4.Font = new System.Drawing.Font("Segoe UI", 90F);
            this.light4.ForeColor = System.Drawing.Color.Black;
            this.light4.Location = new System.Drawing.Point(636, 27);
            this.light4.Margin = new System.Windows.Forms.Padding(0);
            this.light4.Name = "light4";
            this.light4.Size = new System.Drawing.Size(300, 120);
            this.light4.TabIndex = 34;
            this.light4.Text = "•";
            // 
            // fadeIn
            // 
            this.fadeIn.BaseColor = System.Drawing.Color.White;
            this.fadeIn.CheckedOffColor = System.Drawing.Color.Gray;
            this.fadeIn.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.fadeIn.FillColor = System.Drawing.Color.White;
            this.fadeIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fadeIn.Location = new System.Drawing.Point(517, 380);
            this.fadeIn.Name = "fadeIn";
            this.fadeIn.Size = new System.Drawing.Size(68, 20);
            this.fadeIn.TabIndex = 51;
            this.fadeIn.Text = "Fade In";
            this.fadeIn.CheckedChanged += new System.EventHandler(this.fadeIn_CheckedChanged);
            // 
            // fadeOut
            // 
            this.fadeOut.BaseColor = System.Drawing.Color.White;
            this.fadeOut.CheckedOffColor = System.Drawing.Color.Gray;
            this.fadeOut.CheckedOnColor = System.Drawing.Color.DodgerBlue;
            this.fadeOut.FillColor = System.Drawing.Color.White;
            this.fadeOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fadeOut.Location = new System.Drawing.Point(617, 380);
            this.fadeOut.Name = "fadeOut";
            this.fadeOut.Size = new System.Drawing.Size(77, 20);
            this.fadeOut.TabIndex = 52;
            this.fadeOut.Text = "Fade Out";
            this.fadeOut.CheckedChanged += new System.EventHandler(this.fadeOut_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(462, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 152);
            this.panel1.TabIndex = 53;
            // 
            // newGroup
            // 
            this.newGroup.AnimationHoverSpeed = 0.07F;
            this.newGroup.AnimationSpeed = 0.03F;
            this.newGroup.BaseColor = System.Drawing.Color.DodgerBlue;
            this.newGroup.BorderColor = System.Drawing.Color.Black;
            this.newGroup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newGroup.FocusedColor = System.Drawing.Color.Empty;
            this.newGroup.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newGroup.ForeColor = System.Drawing.Color.White;
            this.newGroup.Image = null;
            this.newGroup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newGroup.ImageSize = new System.Drawing.Size(20, 20);
            this.newGroup.Location = new System.Drawing.Point(529, 317);
            this.newGroup.Name = "newGroup";
            this.newGroup.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.newGroup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newGroup.OnHoverForeColor = System.Drawing.Color.White;
            this.newGroup.OnHoverImage = null;
            this.newGroup.OnPressedColor = System.Drawing.Color.Black;
            this.newGroup.Size = new System.Drawing.Size(149, 32);
            this.newGroup.TabIndex = 54;
            this.newGroup.Text = "New Color Group...";
            this.newGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newGroup.Click += new System.EventHandler(this.newGroup_Click);
            // 
            // barSync
            // 
            this.barSync.AnimationHoverSpeed = 0.07F;
            this.barSync.AnimationSpeed = 0.03F;
            this.barSync.BaseColor = System.Drawing.Color.DodgerBlue;
            this.barSync.BorderColor = System.Drawing.Color.Black;
            this.barSync.DialogResult = System.Windows.Forms.DialogResult.None;
            this.barSync.FocusedColor = System.Drawing.Color.Empty;
            this.barSync.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.barSync.ForeColor = System.Drawing.Color.White;
            this.barSync.Image = null;
            this.barSync.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barSync.ImageSize = new System.Drawing.Size(20, 20);
            this.barSync.Location = new System.Drawing.Point(99, 198);
            this.barSync.Name = "barSync";
            this.barSync.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.barSync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.barSync.OnHoverForeColor = System.Drawing.Color.White;
            this.barSync.OnHoverImage = null;
            this.barSync.OnPressedColor = System.Drawing.Color.Black;
            this.barSync.Size = new System.Drawing.Size(89, 35);
            this.barSync.TabIndex = 55;
            this.barSync.Text = "BAR SYNC";
            this.barSync.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barSync.Click += new System.EventHandler(this.barSync_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(208, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 502);
            this.panel2.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.presetValues);
            this.panel3.Controls.Add(this.presetName);
            this.panel3.Controls.Add(this.gunaLabel3);
            this.panel3.Controls.Add(this.gunaLabel4);
            this.panel3.Controls.Add(this.gunaLabel5);
            this.panel3.Controls.Add(this.gunaLabel6);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 67);
            this.panel3.TabIndex = 0;
            // 
            // presetValues
            // 
            this.presetValues.AutoSize = true;
            this.presetValues.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.presetValues.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.presetValues.Location = new System.Drawing.Point(16, 25);
            this.presetValues.Name = "presetValues";
            this.presetValues.Size = new System.Drawing.Size(0, 15);
            this.presetValues.TabIndex = 57;
            // 
            // presetName
            // 
            this.presetName.AutoSize = true;
            this.presetName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.presetName.Location = new System.Drawing.Point(8, 6);
            this.presetName.Name = "presetName";
            this.presetName.Size = new System.Drawing.Size(148, 19);
            this.presetName.TabIndex = 57;
            this.presetName.Text = "No presets in Queue";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel3.Location = new System.Drawing.Point(149, 1);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(65, 89);
            this.gunaLabel3.TabIndex = 60;
            this.gunaLabel3.Text = "•";
            this.gunaLabel3.Visible = false;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel4.Location = new System.Drawing.Point(107, 1);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(65, 89);
            this.gunaLabel4.TabIndex = 59;
            this.gunaLabel4.Text = "•";
            this.gunaLabel4.Visible = false;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel5.Location = new System.Drawing.Point(67, 1);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(65, 89);
            this.gunaLabel5.TabIndex = 58;
            this.gunaLabel5.Text = "•";
            this.gunaLabel5.Visible = false;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 50F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel6.Location = new System.Drawing.Point(24, 1);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(65, 89);
            this.gunaLabel6.TabIndex = 57;
            this.gunaLabel6.Text = "•";
            this.gunaLabel6.Visible = false;
            // 
            // presetManagerButton
            // 
            this.presetManagerButton.AnimationHoverSpeed = 0.07F;
            this.presetManagerButton.AnimationSpeed = 0.03F;
            this.presetManagerButton.BaseColor = System.Drawing.Color.DodgerBlue;
            this.presetManagerButton.BorderColor = System.Drawing.Color.Black;
            this.presetManagerButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.presetManagerButton.FocusedColor = System.Drawing.Color.Empty;
            this.presetManagerButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.presetManagerButton.ForeColor = System.Drawing.Color.White;
            this.presetManagerButton.Image = null;
            this.presetManagerButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.presetManagerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.presetManagerButton.Location = new System.Drawing.Point(208, 537);
            this.presetManagerButton.Name = "presetManagerButton";
            this.presetManagerButton.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.presetManagerButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.presetManagerButton.OnHoverForeColor = System.Drawing.Color.White;
            this.presetManagerButton.OnHoverImage = null;
            this.presetManagerButton.OnPressedColor = System.Drawing.Color.Black;
            this.presetManagerButton.Size = new System.Drawing.Size(132, 35);
            this.presetManagerButton.TabIndex = 57;
            this.presetManagerButton.Text = "Preset Manager";
            this.presetManagerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.presetManagerButton.Click += new System.EventHandler(this.presetManagerButton_Click);
            // 
            // newPreset
            // 
            this.newPreset.AnimationHoverSpeed = 0.07F;
            this.newPreset.AnimationSpeed = 0.03F;
            this.newPreset.BaseColor = System.Drawing.Color.DodgerBlue;
            this.newPreset.BorderColor = System.Drawing.Color.Black;
            this.newPreset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newPreset.FocusedColor = System.Drawing.Color.Empty;
            this.newPreset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newPreset.ForeColor = System.Drawing.Color.White;
            this.newPreset.Image = null;
            this.newPreset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPreset.ImageSize = new System.Drawing.Size(20, 20);
            this.newPreset.Location = new System.Drawing.Point(353, 537);
            this.newPreset.Name = "newPreset";
            this.newPreset.OnHoverBaseColor = System.Drawing.Color.LightSkyBlue;
            this.newPreset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newPreset.OnHoverForeColor = System.Drawing.Color.White;
            this.newPreset.OnHoverImage = null;
            this.newPreset.OnPressedColor = System.Drawing.Color.Black;
            this.newPreset.Size = new System.Drawing.Size(79, 35);
            this.newPreset.TabIndex = 58;
            this.newPreset.Text = "New";
            this.newPreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPreset.Click += new System.EventHandler(this.newPreset_Click);
            // 
            // MainGUI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 584);
            this.ControlBox = false;
            this.Controls.Add(this.newPreset);
            this.Controls.Add(this.presetManagerButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barSync);
            this.Controls.Add(this.newGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fadeOut);
            this.Controls.Add(this.fadeIn);
            this.Controls.Add(this.displayView);
            this.Controls.Add(this.light4);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.speedText);
            this.Controls.Add(this.colorSpeed);
            this.Controls.Add(this.bgText);
            this.Controls.Add(this.brightness);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.portText);
            this.Controls.Add(this.portSelection);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.close);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.desk2);
            this.Controls.Add(this.desk1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.bpm);
            this.Controls.Add(this.beat4);
            this.Controls.Add(this.beat3);
            this.Controls.Add(this.beat2);
            this.Controls.Add(this.beat1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.TrackBar1);
            this.Controls.Add(this.TrackBar3);
            this.Controls.Add(this.TrackBar2);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.light1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaVProgressBar progressBar;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar2;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar3;
        private Guna.UI2.WinForms.Guna2TrackBar TrackBar1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition2;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition3;
        private Guna.UI.WinForms.GunaLabel beat1;
        private Guna.UI.WinForms.GunaLabel beat2;
        private Guna.UI.WinForms.GunaLabel beat3;
        private Guna.UI.WinForms.GunaLabel beat4;
        private Guna.UI.WinForms.GunaLabel bpm;
        private Guna.UI.WinForms.GunaButton startButton;
        private Guna.UI.WinForms.GunaLabel displayView;
        private Guna.UI.WinForms.GunaRadioButton desk1;
        private Guna.UI.WinForms.GunaRadioButton desk2;
        private Guna.UI.WinForms.GunaCheckBox auto;
        private Guna.UI.WinForms.GunaLabel close;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel minimize;
        private Guna.UI.WinForms.GunaLabel maximize;
        private Guna.UI.WinForms.GunaComboBox portSelection;
        private Guna.UI.WinForms.GunaLabel portText;
        private Guna.UI.WinForms.GunaButton connect;
        private Guna.UI.WinForms.GunaVTrackBar brightness;
        private Guna.UI.WinForms.GunaLabel bgText;
        private Guna.UI.WinForms.GunaVTrackBar colorSpeed;
        private Guna.UI.WinForms.GunaLabel speedText;
        private Guna.UI.WinForms.GunaLabel light1;
        private Guna.UI.WinForms.GunaLabel light2;
        private Guna.UI.WinForms.GunaLabel light3;
        private Guna.UI.WinForms.GunaLabel light4;
        private Guna.UI.WinForms.GunaCheckBox fadeIn;
        private Guna.UI.WinForms.GunaCheckBox fadeOut;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton newGroup;
        private Guna.UI.WinForms.GunaButton barSync;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaLabel presetValues;
        private Guna.UI.WinForms.GunaLabel presetName;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaButton presetManagerButton;
        private Guna.UI.WinForms.GunaButton newPreset;
    }
}

