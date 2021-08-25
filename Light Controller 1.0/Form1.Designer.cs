namespace Light_Controller_1._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new Guna.UI.WinForms.GunaVProgressBar();
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.gunaVTrackBar1 = new Guna.UI.WinForms.GunaVTrackBar();
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
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BorderColor = System.Drawing.Color.Black;
            this.progressBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressBar.IdleColor = System.Drawing.Color.DarkGray;
            this.progressBar.Location = new System.Drawing.Point(426, 124);
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
            // gunaVTrackBar1
            // 
            this.gunaVTrackBar1.Location = new System.Drawing.Point(183, 95);
            this.gunaVTrackBar1.Name = "gunaVTrackBar1";
            this.gunaVTrackBar1.Size = new System.Drawing.Size(41, 100);
            this.gunaVTrackBar1.TabIndex = 3;
            this.gunaVTrackBar1.TrackColor = System.Drawing.Color.DodgerBlue;
            this.gunaVTrackBar1.TrackHoverColor = System.Drawing.Color.DodgerBlue;
            this.gunaVTrackBar1.TrackIdleColor = System.Drawing.Color.Silver;
            this.gunaVTrackBar1.TrackPressedColor = System.Drawing.Color.Black;
            // 
            // TrackBar2
            // 
            this.TrackBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.TrackBar2.HoverState.Parent = this.TrackBar2;
            this.TrackBar2.Location = new System.Drawing.Point(538, 240);
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
            this.TrackBar3.Location = new System.Drawing.Point(538, 301);
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
            this.TrackBar1.Location = new System.Drawing.Point(538, 172);
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
            this.gunaLabel1.Location = new System.Drawing.Point(535, 116);
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
            this.bpm.Location = new System.Drawing.Point(302, 142);
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
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Image = null;
            this.startButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startButton.ImageSize = new System.Drawing.Size(20, 20);
            this.startButton.Location = new System.Drawing.Point(23, 198);
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
            this.displayView.Location = new System.Drawing.Point(311, 54);
            this.displayView.Name = "displayView";
            this.displayView.Size = new System.Drawing.Size(0, 46);
            this.displayView.TabIndex = 15;
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
            this.close.Location = new System.Drawing.Point(762, -3);
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
            this.gunaLabel2.Location = new System.Drawing.Point(412, 105);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Progress:";
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize.Location = new System.Drawing.Point(684, -3);
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
            this.maximize.Location = new System.Drawing.Point(724, -3);
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
            this.portSelection.Location = new System.Drawing.Point(31, 374);
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
            this.portText.Location = new System.Drawing.Point(28, 356);
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
            this.connect.Location = new System.Drawing.Point(31, 301);
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
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
            this.Controls.Add(this.displayView);
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
            this.Controls.Add(this.gunaVTrackBar1);
            this.Controls.Add(this.progressBar);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaVProgressBar progressBar;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private Guna.UI.WinForms.GunaVTrackBar gunaVTrackBar1;
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
    }
}

