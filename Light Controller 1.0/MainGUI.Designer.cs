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
            this.xMotor = new Guna.UI2.WinForms.Guna2TrackBar();
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
            this.queueList = new System.Windows.Forms.Panel();
            this.noPresets = new Guna.UI.WinForms.GunaLabel();
            this.presetTools = new System.Windows.Forms.Panel();
            this.startPresetButton = new Guna.UI.WinForms.GunaButton();
            this.removePreset = new Guna.UI.WinForms.GunaButton();
            this.moveDown = new Guna.UI.WinForms.GunaButton();
            this.moveUp = new Guna.UI.WinForms.GunaButton();
            this.presetManagerButton = new Guna.UI.WinForms.GunaButton();
            this.newPreset = new Guna.UI.WinForms.GunaButton();
            this.queueText = new Guna.UI.WinForms.GunaLabel();
            this.startNext = new Guna.UI.WinForms.GunaButton();
            this.commandButton = new Guna.UI.WinForms.GunaButton();
            this.clear = new Guna.UI.WinForms.GunaButton();
            this.cpuUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cpuUsageLabel = new Guna.UI.WinForms.GunaLabel();
            this.cpuUsageText = new Guna.UI.WinForms.GunaLabel();
            this.virtualBeats = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.skipBeat = new Guna.UI.WinForms.GunaButton();
            this.connectButton = new Guna.UI.WinForms.GunaButton();
            this.lightMotors1 = new Guna.UI.WinForms.GunaLabel();
            this.lightMotors2 = new Guna.UI.WinForms.GunaLabel();
            this.lightMotors3 = new Guna.UI.WinForms.GunaLabel();
            this.lightMotors4 = new Guna.UI.WinForms.GunaLabel();
            this.yMotor = new Guna.UI.WinForms.GunaVTrackBar();
            this.sendDistance = new Guna.UI.WinForms.GunaButton();
            this.resetMotors = new Guna.UI.WinForms.GunaButton();
            this.queueList.SuspendLayout();
            this.presetTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsage)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.progressBar.BorderColor = System.Drawing.Color.Black;
            this.progressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBar.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.Location = new System.Drawing.Point(273, 344);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressMaxColor = System.Drawing.Color.Aqua;
            this.progressBar.ProgressMinColor = System.Drawing.Color.DarkCyan;
            this.progressBar.Size = new System.Drawing.Size(23, 200);
            this.progressBar.TabIndex = 1;
            this.progressBar.Value = 1;
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
            // xMotor
            // 
            this.xMotor.BackColor = System.Drawing.Color.Transparent;
            this.xMotor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xMotor.HoverState.Parent = this.xMotor;
            this.xMotor.Location = new System.Drawing.Point(502, 569);
            this.xMotor.Name = "xMotor";
            this.xMotor.Size = new System.Drawing.Size(263, 23);
            this.xMotor.TabIndex = 5;
            this.xMotor.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.xMotor.Value = 30;
            this.xMotor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.xMotor_Scroll);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel1.Location = new System.Drawing.Point(396, 194);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(13, 15);
            this.gunaLabel1.TabIndex = 7;
            this.gunaLabel1.Text = "1";
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
            this.beat1.Location = new System.Drawing.Point(268, 43);
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
            this.beat2.Location = new System.Drawing.Point(306, 43);
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
            this.beat3.Location = new System.Drawing.Point(344, 43);
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
            this.beat4.Location = new System.Drawing.Point(383, 43);
            this.beat4.Margin = new System.Windows.Forms.Padding(0);
            this.beat4.Name = "beat4";
            this.beat4.Size = new System.Drawing.Size(65, 89);
            this.beat4.TabIndex = 12;
            this.beat4.Text = "•";
            this.beat4.Visible = false;
            // 
            // bpm
            // 
            this.bpm.AutoEllipsis = true;
            this.bpm.AutoSize = true;
            this.bpm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bpm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bpm.Location = new System.Drawing.Point(282, 194);
            this.bpm.Name = "bpm";
            this.bpm.Size = new System.Drawing.Size(47, 15);
            this.bpm.TabIndex = 13;
            this.bpm.Text = "BPM : 0";
            this.bpm.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // startButton
            // 
            this.startButton.AnimationHoverSpeed = 0.07F;
            this.startButton.AnimationSpeed = 0.03F;
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.startButton.BorderColor = System.Drawing.Color.Black;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startButton.FocusedColor = System.Drawing.Color.Empty;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Image = null;
            this.startButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startButton.Location = new System.Drawing.Point(271, 259);
            this.startButton.Name = "startButton";
            this.startButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.startButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startButton.OnHoverForeColor = System.Drawing.Color.White;
            this.startButton.OnHoverImage = null;
            this.startButton.OnPressedColor = System.Drawing.Color.Black;
            this.startButton.Radius = 10;
            this.startButton.Size = new System.Drawing.Size(79, 35);
            this.startButton.TabIndex = 14;
            this.startButton.Text = "START";
            this.startButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // displayView
            // 
            this.displayView.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.displayView.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayView.Location = new System.Drawing.Point(321, 14);
            this.displayView.Name = "displayView";
            this.displayView.Size = new System.Drawing.Size(544, 62);
            this.displayView.TabIndex = 15;
            this.displayView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desk1
            // 
            this.desk1.BaseColor = System.Drawing.SystemColors.Control;
            this.desk1.Checked = true;
            this.desk1.CheckedOffColor = System.Drawing.Color.Gray;
            this.desk1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.desk1.FillColor = System.Drawing.Color.White;
            this.desk1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desk1.Location = new System.Drawing.Point(285, 135);
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
            this.desk2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.desk2.FillColor = System.Drawing.Color.White;
            this.desk2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desk2.Location = new System.Drawing.Point(285, 161);
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
            this.auto.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.auto.FillColor = System.Drawing.Color.White;
            this.auto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.auto.Location = new System.Drawing.Point(359, 141);
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
            this.close.Location = new System.Drawing.Point(1062, -3);
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
            this.gunaLabel2.Location = new System.Drawing.Point(266, 547);
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
            this.minimize.Location = new System.Drawing.Point(984, -3);
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
            this.maximize.Location = new System.Drawing.Point(1024, -3);
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
            this.portSelection.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.portSelection.BorderColor = System.Drawing.Color.Silver;
            this.portSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.portSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portSelection.FocusedColor = System.Drawing.Color.Empty;
            this.portSelection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.portSelection.ForeColor = System.Drawing.Color.White;
            this.portSelection.FormattingEnabled = true;
            this.portSelection.Location = new System.Drawing.Point(324, 470);
            this.portSelection.Name = "portSelection";
            this.portSelection.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.portSelection.OnHoverItemForeColor = System.Drawing.Color.White;
            this.portSelection.Size = new System.Drawing.Size(121, 26);
            this.portSelection.TabIndex = 24;
            this.portSelection.SelectedIndexChanged += new System.EventHandler(this.SelectPort);
            this.portSelection.Click += new System.EventHandler(this.portSelection_Click);
            // 
            // portText
            // 
            this.portText.AutoSize = true;
            this.portText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.portText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.portText.Location = new System.Drawing.Point(321, 450);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(32, 15);
            this.portText.TabIndex = 25;
            this.portText.Text = "Port:";
            // 
            // brightness
            // 
            this.brightness.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.brightness.Cursor = System.Windows.Forms.Cursors.Default;
            this.brightness.Location = new System.Drawing.Point(1005, 371);
            this.brightness.Name = "brightness";
            this.brightness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brightness.Size = new System.Drawing.Size(30, 173);
            this.brightness.TabIndex = 27;
            this.brightness.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.brightness.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.brightness.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.brightness.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.brightness.Scroll += new System.Windows.Forms.ScrollEventHandler(this.brigthnessTrackBar_Scroll);
            this.brightness.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGUI_KeyDown);
            this.brightness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_ScrollingStoped);
            // 
            // bgText
            // 
            this.bgText.AutoSize = true;
            this.bgText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bgText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bgText.Location = new System.Drawing.Point(988, 553);
            this.bgText.Name = "bgText";
            this.bgText.Size = new System.Drawing.Size(62, 15);
            this.bgText.TabIndex = 28;
            this.bgText.Text = "Brightness";
            // 
            // colorSpeed
            // 
            this.colorSpeed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.colorSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorSpeed.Location = new System.Drawing.Point(934, 371);
            this.colorSpeed.Name = "colorSpeed";
            this.colorSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colorSpeed.Size = new System.Drawing.Size(30, 173);
            this.colorSpeed.TabIndex = 29;
            this.colorSpeed.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.colorSpeed.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.colorSpeed.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorSpeed.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.colorSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.speedTrackBar_Scroll);
            this.colorSpeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGUI_KeyDown);
            this.colorSpeed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBars_ScrollingStoped);
            // 
            // speedText
            // 
            this.speedText.AutoSize = true;
            this.speedText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.speedText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.speedText.Location = new System.Drawing.Point(911, 553);
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
            this.light1.Location = new System.Drawing.Point(462, 14);
            this.light1.Margin = new System.Windows.Forms.Padding(0);
            this.light1.Name = "light1";
            this.light1.Size = new System.Drawing.Size(90, 120);
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
            this.light2.Location = new System.Drawing.Point(528, 15);
            this.light2.Margin = new System.Windows.Forms.Padding(0);
            this.light2.Name = "light2";
            this.light2.Size = new System.Drawing.Size(86, 120);
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
            this.light3.Location = new System.Drawing.Point(595, 14);
            this.light3.Margin = new System.Windows.Forms.Padding(0);
            this.light3.Name = "light3";
            this.light3.Size = new System.Drawing.Size(85, 120);
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
            this.light4.Location = new System.Drawing.Point(662, 14);
            this.light4.Margin = new System.Windows.Forms.Padding(0);
            this.light4.Name = "light4";
            this.light4.Size = new System.Drawing.Size(84, 120);
            this.light4.TabIndex = 34;
            this.light4.Text = "•";
            // 
            // fadeIn
            // 
            this.fadeIn.BaseColor = System.Drawing.Color.White;
            this.fadeIn.CheckedOffColor = System.Drawing.Color.Gray;
            this.fadeIn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.fadeIn.FillColor = System.Drawing.Color.White;
            this.fadeIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fadeIn.Location = new System.Drawing.Point(823, 384);
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
            this.fadeOut.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.fadeOut.FillColor = System.Drawing.Color.White;
            this.fadeOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fadeOut.Location = new System.Drawing.Point(823, 420);
            this.fadeOut.Name = "fadeOut";
            this.fadeOut.Size = new System.Drawing.Size(77, 20);
            this.fadeOut.TabIndex = 52;
            this.fadeOut.Text = "Fade Out";
            this.fadeOut.CheckedChanged += new System.EventHandler(this.fadeOut_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(483, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 177);
            this.panel1.TabIndex = 53;
            // 
            // newGroup
            // 
            this.newGroup.AnimationHoverSpeed = 0.07F;
            this.newGroup.AnimationSpeed = 0.03F;
            this.newGroup.BackColor = System.Drawing.Color.Transparent;
            this.newGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.newGroup.BorderColor = System.Drawing.Color.Black;
            this.newGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGroup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newGroup.FocusedColor = System.Drawing.Color.Empty;
            this.newGroup.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newGroup.ForeColor = System.Drawing.Color.White;
            this.newGroup.Image = null;
            this.newGroup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newGroup.ImageSize = new System.Drawing.Size(20, 20);
            this.newGroup.Location = new System.Drawing.Point(616, 331);
            this.newGroup.Name = "newGroup";
            this.newGroup.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.newGroup.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newGroup.OnHoverForeColor = System.Drawing.Color.White;
            this.newGroup.OnHoverImage = null;
            this.newGroup.OnPressedColor = System.Drawing.Color.Black;
            this.newGroup.Radius = 10;
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
            this.barSync.BackColor = System.Drawing.Color.Transparent;
            this.barSync.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.barSync.BorderColor = System.Drawing.Color.Black;
            this.barSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barSync.DialogResult = System.Windows.Forms.DialogResult.None;
            this.barSync.FocusedColor = System.Drawing.Color.Empty;
            this.barSync.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.barSync.ForeColor = System.Drawing.Color.White;
            this.barSync.Image = null;
            this.barSync.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barSync.ImageSize = new System.Drawing.Size(20, 20);
            this.barSync.Location = new System.Drawing.Point(359, 259);
            this.barSync.Name = "barSync";
            this.barSync.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.barSync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.barSync.OnHoverForeColor = System.Drawing.Color.White;
            this.barSync.OnHoverImage = null;
            this.barSync.OnPressedColor = System.Drawing.Color.Black;
            this.barSync.Radius = 10;
            this.barSync.Size = new System.Drawing.Size(89, 35);
            this.barSync.TabIndex = 55;
            this.barSync.Text = "BAR SYNC";
            this.barSync.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barSync.Click += new System.EventHandler(this.barSync_Click);
            // 
            // queueList
            // 
            this.queueList.AutoScroll = true;
            this.queueList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.queueList.Controls.Add(this.noPresets);
            this.queueList.Location = new System.Drawing.Point(5, 45);
            this.queueList.Name = "queueList";
            this.queueList.Size = new System.Drawing.Size(258, 438);
            this.queueList.TabIndex = 56;
            this.queueList.Click += new System.EventHandler(this.queueList_Click);
            // 
            // noPresets
            // 
            this.noPresets.AutoSize = true;
            this.noPresets.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.noPresets.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.noPresets.Location = new System.Drawing.Point(57, 202);
            this.noPresets.Name = "noPresets";
            this.noPresets.Size = new System.Drawing.Size(135, 18);
            this.noPresets.TabIndex = 57;
            this.noPresets.Tag = "-1";
            this.noPresets.Text = "No presets in Queue";
            // 
            // presetTools
            // 
            this.presetTools.AutoScroll = true;
            this.presetTools.Controls.Add(this.startPresetButton);
            this.presetTools.Controls.Add(this.removePreset);
            this.presetTools.Controls.Add(this.moveDown);
            this.presetTools.Controls.Add(this.moveUp);
            this.presetTools.Location = new System.Drawing.Point(-4, 488);
            this.presetTools.Name = "presetTools";
            this.presetTools.Size = new System.Drawing.Size(268, 48);
            this.presetTools.TabIndex = 54;
            this.presetTools.Visible = false;
            // 
            // startPresetButton
            // 
            this.startPresetButton.AnimationHoverSpeed = 0.07F;
            this.startPresetButton.AnimationSpeed = 0.03F;
            this.startPresetButton.BackColor = System.Drawing.Color.Transparent;
            this.startPresetButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.startPresetButton.BorderColor = System.Drawing.Color.Black;
            this.startPresetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startPresetButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startPresetButton.FocusedColor = System.Drawing.Color.Empty;
            this.startPresetButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.startPresetButton.ForeColor = System.Drawing.Color.White;
            this.startPresetButton.Image = null;
            this.startPresetButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startPresetButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startPresetButton.Location = new System.Drawing.Point(176, 5);
            this.startPresetButton.Name = "startPresetButton";
            this.startPresetButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.startPresetButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startPresetButton.OnHoverForeColor = System.Drawing.Color.White;
            this.startPresetButton.OnHoverImage = null;
            this.startPresetButton.OnPressedColor = System.Drawing.Color.Black;
            this.startPresetButton.Radius = 10;
            this.startPresetButton.Size = new System.Drawing.Size(89, 35);
            this.startPresetButton.TabIndex = 64;
            this.startPresetButton.Text = "Start";
            this.startPresetButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startPresetButton.Click += new System.EventHandler(this.StartPresetButton_Click);
            // 
            // removePreset
            // 
            this.removePreset.AnimationHoverSpeed = 0.07F;
            this.removePreset.AnimationSpeed = 0.03F;
            this.removePreset.BackColor = System.Drawing.Color.Transparent;
            this.removePreset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.removePreset.BorderColor = System.Drawing.Color.Black;
            this.removePreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removePreset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.removePreset.FocusedColor = System.Drawing.Color.Empty;
            this.removePreset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.removePreset.ForeColor = System.Drawing.Color.White;
            this.removePreset.Image = null;
            this.removePreset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removePreset.ImageSize = new System.Drawing.Size(20, 20);
            this.removePreset.Location = new System.Drawing.Point(10, 5);
            this.removePreset.Name = "removePreset";
            this.removePreset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.removePreset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.removePreset.OnHoverForeColor = System.Drawing.Color.White;
            this.removePreset.OnHoverImage = null;
            this.removePreset.OnPressedColor = System.Drawing.Color.Black;
            this.removePreset.Radius = 10;
            this.removePreset.Size = new System.Drawing.Size(85, 35);
            this.removePreset.TabIndex = 65;
            this.removePreset.Text = "Remove";
            this.removePreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.removePreset.Click += new System.EventHandler(this.removePreset_Click);
            // 
            // moveDown
            // 
            this.moveDown.AnimationHoverSpeed = 0.07F;
            this.moveDown.AnimationSpeed = 0.03F;
            this.moveDown.BackColor = System.Drawing.Color.Transparent;
            this.moveDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.moveDown.BorderColor = System.Drawing.Color.Black;
            this.moveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveDown.DialogResult = System.Windows.Forms.DialogResult.None;
            this.moveDown.FocusedColor = System.Drawing.Color.Empty;
            this.moveDown.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.moveDown.ForeColor = System.Drawing.Color.White;
            this.moveDown.Image = null;
            this.moveDown.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moveDown.ImageSize = new System.Drawing.Size(20, 20);
            this.moveDown.Location = new System.Drawing.Point(138, 5);
            this.moveDown.Name = "moveDown";
            this.moveDown.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.moveDown.OnHoverBorderColor = System.Drawing.Color.Black;
            this.moveDown.OnHoverForeColor = System.Drawing.Color.White;
            this.moveDown.OnHoverImage = null;
            this.moveDown.OnPressedColor = System.Drawing.Color.Black;
            this.moveDown.Radius = 10;
            this.moveDown.Size = new System.Drawing.Size(32, 35);
            this.moveDown.TabIndex = 63;
            this.moveDown.Text = "▼";
            this.moveDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveUp
            // 
            this.moveUp.AnimationHoverSpeed = 0.07F;
            this.moveUp.AnimationSpeed = 0.03F;
            this.moveUp.BackColor = System.Drawing.Color.Transparent;
            this.moveUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.moveUp.BorderColor = System.Drawing.Color.Black;
            this.moveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.moveUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.moveUp.FocusedColor = System.Drawing.Color.Empty;
            this.moveUp.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.moveUp.ForeColor = System.Drawing.Color.White;
            this.moveUp.Image = null;
            this.moveUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moveUp.ImageSize = new System.Drawing.Size(20, 20);
            this.moveUp.Location = new System.Drawing.Point(101, 5);
            this.moveUp.Name = "moveUp";
            this.moveUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.moveUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.moveUp.OnHoverForeColor = System.Drawing.Color.White;
            this.moveUp.OnHoverImage = null;
            this.moveUp.OnPressedColor = System.Drawing.Color.Black;
            this.moveUp.Radius = 10;
            this.moveUp.Size = new System.Drawing.Size(32, 35);
            this.moveUp.TabIndex = 62;
            this.moveUp.Text = "▲";
            this.moveUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // presetManagerButton
            // 
            this.presetManagerButton.AnimationHoverSpeed = 0.07F;
            this.presetManagerButton.AnimationSpeed = 0.03F;
            this.presetManagerButton.BackColor = System.Drawing.Color.Transparent;
            this.presetManagerButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.presetManagerButton.BorderColor = System.Drawing.Color.Black;
            this.presetManagerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.presetManagerButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.presetManagerButton.FocusedColor = System.Drawing.Color.Empty;
            this.presetManagerButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.presetManagerButton.ForeColor = System.Drawing.Color.White;
            this.presetManagerButton.Image = null;
            this.presetManagerButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.presetManagerButton.ImageSize = new System.Drawing.Size(20, 20);
            this.presetManagerButton.Location = new System.Drawing.Point(5, 489);
            this.presetManagerButton.Name = "presetManagerButton";
            this.presetManagerButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.presetManagerButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.presetManagerButton.OnHoverForeColor = System.Drawing.Color.White;
            this.presetManagerButton.OnHoverImage = null;
            this.presetManagerButton.OnPressedColor = System.Drawing.Color.Black;
            this.presetManagerButton.Radius = 10;
            this.presetManagerButton.Size = new System.Drawing.Size(158, 35);
            this.presetManagerButton.TabIndex = 57;
            this.presetManagerButton.Text = "Preset Manager";
            this.presetManagerButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.presetManagerButton.Click += new System.EventHandler(this.presetManagerButton_Click);
            // 
            // newPreset
            // 
            this.newPreset.AnimationHoverSpeed = 0.07F;
            this.newPreset.AnimationSpeed = 0.03F;
            this.newPreset.BackColor = System.Drawing.Color.Transparent;
            this.newPreset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.newPreset.BorderColor = System.Drawing.Color.Black;
            this.newPreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPreset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newPreset.FocusedColor = System.Drawing.Color.Empty;
            this.newPreset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newPreset.ForeColor = System.Drawing.Color.White;
            this.newPreset.Image = null;
            this.newPreset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPreset.ImageSize = new System.Drawing.Size(20, 20);
            this.newPreset.Location = new System.Drawing.Point(169, 489);
            this.newPreset.Name = "newPreset";
            this.newPreset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.newPreset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newPreset.OnHoverForeColor = System.Drawing.Color.White;
            this.newPreset.OnHoverImage = null;
            this.newPreset.OnPressedColor = System.Drawing.Color.Black;
            this.newPreset.Radius = 10;
            this.newPreset.Size = new System.Drawing.Size(91, 35);
            this.newPreset.TabIndex = 58;
            this.newPreset.Text = "New";
            this.newPreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPreset.Click += new System.EventHandler(this.newPreset_Click);
            // 
            // queueText
            // 
            this.queueText.AutoSize = true;
            this.queueText.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.queueText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.queueText.Location = new System.Drawing.Point(10, 14);
            this.queueText.Name = "queueText";
            this.queueText.Size = new System.Drawing.Size(63, 23);
            this.queueText.TabIndex = 61;
            this.queueText.Text = "Queue";
            // 
            // startNext
            // 
            this.startNext.AnimationHoverSpeed = 0.07F;
            this.startNext.AnimationSpeed = 0.03F;
            this.startNext.BackColor = System.Drawing.Color.Transparent;
            this.startNext.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.startNext.BorderColor = System.Drawing.Color.Black;
            this.startNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startNext.FocusedColor = System.Drawing.Color.Empty;
            this.startNext.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startNext.ForeColor = System.Drawing.Color.White;
            this.startNext.Image = null;
            this.startNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startNext.ImageSize = new System.Drawing.Size(20, 20);
            this.startNext.Location = new System.Drawing.Point(70, 535);
            this.startNext.Name = "startNext";
            this.startNext.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.startNext.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startNext.OnHoverForeColor = System.Drawing.Color.White;
            this.startNext.OnHoverImage = null;
            this.startNext.OnPressedColor = System.Drawing.Color.Black;
            this.startNext.Radius = 10;
            this.startNext.Size = new System.Drawing.Size(119, 43);
            this.startNext.TabIndex = 62;
            this.startNext.Text = "START NEXT";
            this.startNext.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startNext.Click += new System.EventHandler(this.startNext_Click);
            // 
            // commandButton
            // 
            this.commandButton.AnimationHoverSpeed = 0.07F;
            this.commandButton.AnimationSpeed = 0.03F;
            this.commandButton.BackColor = System.Drawing.Color.Transparent;
            this.commandButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.commandButton.BorderColor = System.Drawing.Color.Black;
            this.commandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.commandButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.commandButton.FocusedColor = System.Drawing.Color.Empty;
            this.commandButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.commandButton.ForeColor = System.Drawing.Color.White;
            this.commandButton.Image = null;
            this.commandButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commandButton.ImageSize = new System.Drawing.Size(20, 20);
            this.commandButton.Location = new System.Drawing.Point(332, 512);
            this.commandButton.Name = "commandButton";
            this.commandButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.commandButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.commandButton.OnHoverForeColor = System.Drawing.Color.White;
            this.commandButton.OnHoverImage = null;
            this.commandButton.OnPressedColor = System.Drawing.Color.Black;
            this.commandButton.Radius = 10;
            this.commandButton.Size = new System.Drawing.Size(107, 35);
            this.commandButton.TabIndex = 63;
            this.commandButton.Text = "Command...";
            this.commandButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.commandButton.Click += new System.EventHandler(this.commandButton_Click);
            // 
            // clear
            // 
            this.clear.AnimationHoverSpeed = 0.07F;
            this.clear.AnimationSpeed = 0.03F;
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.clear.BorderColor = System.Drawing.Color.Black;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear.Enabled = false;
            this.clear.FocusedColor = System.Drawing.Color.Empty;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Image = null;
            this.clear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.ImageSize = new System.Drawing.Size(20, 20);
            this.clear.Location = new System.Drawing.Point(217, 14);
            this.clear.Name = "clear";
            this.clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear.OnHoverForeColor = System.Drawing.Color.White;
            this.clear.OnHoverImage = null;
            this.clear.OnPressedColor = System.Drawing.Color.Black;
            this.clear.Radius = 10;
            this.clear.Size = new System.Drawing.Size(47, 25);
            this.clear.TabIndex = 66;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // cpuUsage
            // 
            this.cpuUsage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuUsage.Location = new System.Drawing.Point(875, 106);
            this.cpuUsage.Name = "cpuUsage";
            this.cpuUsage.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.cpuUsage.Size = new System.Drawing.Size(130, 89);
            this.cpuUsage.TabIndex = 67;
            // 
            // cpuUsageLabel
            // 
            this.cpuUsageLabel.AutoEllipsis = true;
            this.cpuUsageLabel.AutoSize = true;
            this.cpuUsageLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cpuUsageLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cpuUsageLabel.Location = new System.Drawing.Point(888, 209);
            this.cpuUsageLabel.Name = "cpuUsageLabel";
            this.cpuUsageLabel.Size = new System.Drawing.Size(117, 45);
            this.cpuUsageLabel.TabIndex = 68;
            this.cpuUsageLabel.Text = "Total:  0%\r\nLight Controller: 0%\r\nMemory Usage: 0MB";
            // 
            // cpuUsageText
            // 
            this.cpuUsageText.AutoEllipsis = true;
            this.cpuUsageText.AutoSize = true;
            this.cpuUsageText.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cpuUsageText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cpuUsageText.Location = new System.Drawing.Point(898, 82);
            this.cpuUsageText.Name = "cpuUsageText";
            this.cpuUsageText.Size = new System.Drawing.Size(87, 21);
            this.cpuUsageText.TabIndex = 69;
            this.cpuUsageText.Text = "CPU Usage";
            // 
            // virtualBeats
            // 
            this.virtualBeats.AnimationHoverSpeed = 0.07F;
            this.virtualBeats.AnimationSpeed = 0.03F;
            this.virtualBeats.BackColor = System.Drawing.Color.Transparent;
            this.virtualBeats.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.virtualBeats.BorderColor = System.Drawing.Color.Black;
            this.virtualBeats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.virtualBeats.DialogResult = System.Windows.Forms.DialogResult.None;
            this.virtualBeats.FocusedColor = System.Drawing.Color.Empty;
            this.virtualBeats.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.virtualBeats.ForeColor = System.Drawing.Color.White;
            this.virtualBeats.Image = null;
            this.virtualBeats.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.virtualBeats.ImageSize = new System.Drawing.Size(20, 20);
            this.virtualBeats.Location = new System.Drawing.Point(311, 306);
            this.virtualBeats.Name = "virtualBeats";
            this.virtualBeats.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.virtualBeats.OnHoverBorderColor = System.Drawing.Color.Black;
            this.virtualBeats.OnHoverForeColor = System.Drawing.Color.White;
            this.virtualBeats.OnHoverImage = null;
            this.virtualBeats.OnPressedColor = System.Drawing.Color.Black;
            this.virtualBeats.Radius = 10;
            this.virtualBeats.Size = new System.Drawing.Size(98, 32);
            this.virtualBeats.TabIndex = 70;
            this.virtualBeats.Text = "Virtual Beats...";
            this.virtualBeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.virtualBeats.Click += new System.EventHandler(this.virtualBeats_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoEllipsis = true;
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gunaLabel3.Location = new System.Drawing.Point(314, 225);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel3.TabIndex = 71;
            this.gunaLabel3.Text = "Show Detector";
            this.gunaLabel3.Click += new System.EventHandler(this.showBeatCounterDetector);
            // 
            // colorPanel
            // 
            this.colorPanel.AutoScroll = true;
            this.colorPanel.Location = new System.Drawing.Point(483, 384);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(308, 99);
            this.colorPanel.TabIndex = 54;
            // 
            // skipBeat
            // 
            this.skipBeat.AnimationHoverSpeed = 0.07F;
            this.skipBeat.AnimationSpeed = 0.03F;
            this.skipBeat.BackColor = System.Drawing.Color.Transparent;
            this.skipBeat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.skipBeat.BorderColor = System.Drawing.Color.Black;
            this.skipBeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipBeat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.skipBeat.FocusedColor = System.Drawing.Color.Empty;
            this.skipBeat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.skipBeat.ForeColor = System.Drawing.Color.White;
            this.skipBeat.Image = null;
            this.skipBeat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skipBeat.ImageSize = new System.Drawing.Size(20, 20);
            this.skipBeat.Location = new System.Drawing.Point(516, 331);
            this.skipBeat.Name = "skipBeat";
            this.skipBeat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.skipBeat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.skipBeat.OnHoverForeColor = System.Drawing.Color.White;
            this.skipBeat.OnHoverImage = null;
            this.skipBeat.OnPressedColor = System.Drawing.Color.Black;
            this.skipBeat.Radius = 10;
            this.skipBeat.Size = new System.Drawing.Size(91, 32);
            this.skipBeat.TabIndex = 73;
            this.skipBeat.Text = "Skip Beat";
            this.skipBeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skipBeat.Click += new System.EventHandler(this.skipBeat_Click);
            // 
            // connectButton
            // 
            this.connectButton.AnimationHoverSpeed = 0.07F;
            this.connectButton.AnimationSpeed = 0.03F;
            this.connectButton.BackColor = System.Drawing.Color.Transparent;
            this.connectButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.connectButton.BorderColor = System.Drawing.Color.Black;
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.connectButton.FocusedColor = System.Drawing.Color.Empty;
            this.connectButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Image = global::Light_Controller_1._0.Properties.Resources.arduino;
            this.connectButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.connectButton.ImageSize = new System.Drawing.Size(22, 22);
            this.connectButton.Location = new System.Drawing.Point(311, 397);
            this.connectButton.Name = "connectButton";
            this.connectButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.connectButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.connectButton.OnHoverForeColor = System.Drawing.Color.White;
            this.connectButton.OnHoverImage = null;
            this.connectButton.OnPressedColor = System.Drawing.Color.Black;
            this.connectButton.Radius = 10;
            this.connectButton.Size = new System.Drawing.Size(148, 43);
            this.connectButton.TabIndex = 72;
            this.connectButton.Text = "CONNECT";
            this.connectButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.connectButton.TextOffsetX = -5;
            this.connectButton.Click += new System.EventHandler(this.Connect);
            // 
            // lightMotors1
            // 
            this.lightMotors1.AutoEllipsis = true;
            this.lightMotors1.AutoSize = true;
            this.lightMotors1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lightMotors1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightMotors1.Location = new System.Drawing.Point(499, 504);
            this.lightMotors1.Name = "lightMotors1";
            this.lightMotors1.Size = new System.Drawing.Size(43, 45);
            this.lightMotors1.TabIndex = 74;
            this.lightMotors1.Tag = "1";
            this.lightMotors1.Text = "Light 1\r\nX: 0\r\nY: 0";
            // 
            // lightMotors2
            // 
            this.lightMotors2.AutoEllipsis = true;
            this.lightMotors2.AutoSize = true;
            this.lightMotors2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lightMotors2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightMotors2.Location = new System.Drawing.Point(571, 504);
            this.lightMotors2.Name = "lightMotors2";
            this.lightMotors2.Size = new System.Drawing.Size(43, 45);
            this.lightMotors2.TabIndex = 75;
            this.lightMotors2.Tag = "2";
            this.lightMotors2.Text = "Light 2\r\nX: 0\r\nY: 0";
            // 
            // lightMotors3
            // 
            this.lightMotors3.AutoEllipsis = true;
            this.lightMotors3.AutoSize = true;
            this.lightMotors3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lightMotors3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightMotors3.Location = new System.Drawing.Point(652, 504);
            this.lightMotors3.Name = "lightMotors3";
            this.lightMotors3.Size = new System.Drawing.Size(43, 45);
            this.lightMotors3.TabIndex = 76;
            this.lightMotors3.Tag = "3";
            this.lightMotors3.Text = "Light 3\r\nX: 0\r\nY: 0";
            // 
            // lightMotors4
            // 
            this.lightMotors4.AutoEllipsis = true;
            this.lightMotors4.AutoSize = true;
            this.lightMotors4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lightMotors4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightMotors4.Location = new System.Drawing.Point(722, 504);
            this.lightMotors4.Name = "lightMotors4";
            this.lightMotors4.Size = new System.Drawing.Size(43, 45);
            this.lightMotors4.TabIndex = 77;
            this.lightMotors4.Tag = "4";
            this.lightMotors4.Text = "Light 4\r\nX: 0\r\nY: 0";
            // 
            // yMotor
            // 
            this.yMotor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yMotor.Cursor = System.Windows.Forms.Cursors.Default;
            this.yMotor.Location = new System.Drawing.Point(787, 493);
            this.yMotor.Name = "yMotor";
            this.yMotor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yMotor.Size = new System.Drawing.Size(30, 99);
            this.yMotor.TabIndex = 78;
            this.yMotor.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.yMotor.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.yMotor.TrackIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yMotor.TrackPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.yMotor.Scroll += new System.Windows.Forms.ScrollEventHandler(this.yMotor_Scroll);
            // 
            // sendDistance
            // 
            this.sendDistance.AnimationHoverSpeed = 0.07F;
            this.sendDistance.AnimationSpeed = 0.03F;
            this.sendDistance.BackColor = System.Drawing.Color.Transparent;
            this.sendDistance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.sendDistance.BorderColor = System.Drawing.Color.Black;
            this.sendDistance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendDistance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sendDistance.FocusedColor = System.Drawing.Color.Empty;
            this.sendDistance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sendDistance.ForeColor = System.Drawing.Color.White;
            this.sendDistance.Image = null;
            this.sendDistance.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sendDistance.ImageSize = new System.Drawing.Size(20, 20);
            this.sendDistance.Location = new System.Drawing.Point(311, 348);
            this.sendDistance.Name = "sendDistance";
            this.sendDistance.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.sendDistance.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sendDistance.OnHoverForeColor = System.Drawing.Color.White;
            this.sendDistance.OnHoverImage = null;
            this.sendDistance.OnPressedColor = System.Drawing.Color.Black;
            this.sendDistance.Radius = 10;
            this.sendDistance.Size = new System.Drawing.Size(98, 32);
            this.sendDistance.TabIndex = 80;
            this.sendDistance.Text = "Send Distance";
            this.sendDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetMotors
            // 
            this.resetMotors.AnimationHoverSpeed = 0.07F;
            this.resetMotors.AnimationSpeed = 0.03F;
            this.resetMotors.BackColor = System.Drawing.Color.Transparent;
            this.resetMotors.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.resetMotors.BorderColor = System.Drawing.Color.Black;
            this.resetMotors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetMotors.DialogResult = System.Windows.Forms.DialogResult.None;
            this.resetMotors.FocusedColor = System.Drawing.Color.Empty;
            this.resetMotors.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.resetMotors.ForeColor = System.Drawing.Color.White;
            this.resetMotors.Image = null;
            this.resetMotors.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetMotors.ImageSize = new System.Drawing.Size(20, 20);
            this.resetMotors.Location = new System.Drawing.Point(823, 496);
            this.resetMotors.Name = "resetMotors";
            this.resetMotors.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.resetMotors.OnHoverBorderColor = System.Drawing.Color.Black;
            this.resetMotors.OnHoverForeColor = System.Drawing.Color.White;
            this.resetMotors.OnHoverImage = null;
            this.resetMotors.OnPressedColor = System.Drawing.Color.Black;
            this.resetMotors.Radius = 10;
            this.resetMotors.Size = new System.Drawing.Size(98, 32);
            this.resetMotors.TabIndex = 81;
            this.resetMotors.Text = "Reset Motors";
            this.resetMotors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resetMotors.Click += new System.EventHandler(this.resetMotors_Click);
            // 
            // MainGUI
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1100, 604);
            this.ControlBox = false;
            this.Controls.Add(this.resetMotors);
            this.Controls.Add(this.sendDistance);
            this.Controls.Add(this.yMotor);
            this.Controls.Add(this.lightMotors4);
            this.Controls.Add(this.lightMotors3);
            this.Controls.Add(this.lightMotors2);
            this.Controls.Add(this.lightMotors1);
            this.Controls.Add(this.displayView);
            this.Controls.Add(this.skipBeat);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.virtualBeats);
            this.Controls.Add(this.cpuUsageText);
            this.Controls.Add(this.cpuUsageLabel);
            this.Controls.Add(this.cpuUsage);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.commandButton);
            this.Controls.Add(this.startNext);
            this.Controls.Add(this.presetTools);
            this.Controls.Add(this.queueText);
            this.Controls.Add(this.newPreset);
            this.Controls.Add(this.presetManagerButton);
            this.Controls.Add(this.queueList);
            this.Controls.Add(this.barSync);
            this.Controls.Add(this.newGroup);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fadeOut);
            this.Controls.Add(this.fadeIn);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.speedText);
            this.Controls.Add(this.colorSpeed);
            this.Controls.Add(this.bgText);
            this.Controls.Add(this.brightness);
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
            this.Controls.Add(this.xMotor);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.light4);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Light Controller 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainGUI_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.queueList.ResumeLayout(false);
            this.queueList.PerformLayout();
            this.presetTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cpuUsage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaVProgressBar progressBar;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private Guna.UI2.WinForms.Guna2TrackBar xMotor;
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
        private System.Windows.Forms.Panel queueList;
        private Guna.UI.WinForms.GunaLabel noPresets;
        private Guna.UI.WinForms.GunaButton presetManagerButton;
        private Guna.UI.WinForms.GunaButton newPreset;
        private Guna.UI.WinForms.GunaLabel queueText;
        private System.Windows.Forms.Panel presetTools;
        private Guna.UI.WinForms.GunaButton startPresetButton;
        private Guna.UI.WinForms.GunaButton removePreset;
        private Guna.UI.WinForms.GunaButton moveDown;
        private Guna.UI.WinForms.GunaButton moveUp;
        private Guna.UI.WinForms.GunaButton startNext;
        private Guna.UI.WinForms.GunaButton commandButton;
        private Guna.UI.WinForms.GunaButton clear;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuUsage;
        private Guna.UI.WinForms.GunaLabel cpuUsageLabel;
        private Guna.UI.WinForms.GunaLabel cpuUsageText;
        private Guna.UI.WinForms.GunaButton virtualBeats;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Panel colorPanel;
        private Guna.UI.WinForms.GunaButton connectButton;
        private Guna.UI.WinForms.GunaButton skipBeat;
        private Guna.UI.WinForms.GunaLabel lightMotors1;
        private Guna.UI.WinForms.GunaLabel lightMotors2;
        private Guna.UI.WinForms.GunaLabel lightMotors3;
        private Guna.UI.WinForms.GunaLabel lightMotors4;
        private Guna.UI.WinForms.GunaVTrackBar yMotor;
        private Guna.UI.WinForms.GunaButton sendDistance;
        private Guna.UI.WinForms.GunaButton resetMotors;
    }
}

