namespace Light_Controller_1._0
{
    partial class PresetManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetManager));
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.maximize = new Guna.UI.WinForms.GunaLabel();
            this.minimize = new Guna.UI.WinForms.GunaLabel();
            this.close = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.startNow = new Guna.UI.WinForms.GunaButton();
            this.addToQueue = new Guna.UI.WinForms.GunaButton();
            this.deletePreset = new Guna.UI.WinForms.GunaButton();
            this.editButton = new Guna.UI.WinForms.GunaButton();
            this.newPresetButton = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 54);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(860, 448);
            this.flowLayoutPanel.TabIndex = 0;
            this.flowLayoutPanel.Click += new System.EventHandler(this.flowLayoutPanel_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.Transparent;
            this.maximize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.maximize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maximize.Location = new System.Drawing.Point(808, 0);
            this.maximize.Margin = new System.Windows.Forms.Padding(0);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(41, 36);
            this.maximize.TabIndex = 63;
            this.maximize.Text = "⬜";
            this.maximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maximize.Click += new System.EventHandler(this.Maximize);
            this.maximize.MouseEnter += new System.EventHandler(this.ShowMaximizeBlue);
            this.maximize.MouseLeave += new System.EventHandler(this.HideMaximizeBlue);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.Transparent;
            this.minimize.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.minimize.Location = new System.Drawing.Point(768, 0);
            this.minimize.Margin = new System.Windows.Forms.Padding(0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(37, 36);
            this.minimize.TabIndex = 62;
            this.minimize.Text = "–";
            this.minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimize.Click += new System.EventHandler(this.Minimize);
            this.minimize.MouseEnter += new System.EventHandler(this.ShowMinimizeBlue);
            this.minimize.MouseLeave += new System.EventHandler(this.HideMinimizeBlue);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.close.Location = new System.Drawing.Point(846, 0);
            this.close.Margin = new System.Windows.Forms.Padding(0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(39, 36);
            this.close.TabIndex = 61;
            this.close.Text = "✕";
            this.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.close.Click += new System.EventHandler(this.CloseWindow);
            this.close.MouseEnter += new System.EventHandler(this.ShowRed);
            this.close.MouseLeave += new System.EventHandler(this.HideRed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 31);
            this.label1.TabIndex = 64;
            this.label1.Text = "Preset Manager";
            // 
            // startNow
            // 
            this.startNow.AnimationHoverSpeed = 0.07F;
            this.startNow.AnimationSpeed = 0.03F;
            this.startNow.BackColor = System.Drawing.Color.Transparent;
            this.startNow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.startNow.BorderColor = System.Drawing.Color.Black;
            this.startNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startNow.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startNow.FocusedColor = System.Drawing.Color.Empty;
            this.startNow.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.startNow.ForeColor = System.Drawing.Color.White;
            this.startNow.Image = null;
            this.startNow.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startNow.ImageSize = new System.Drawing.Size(20, 20);
            this.startNow.Location = new System.Drawing.Point(649, 514);
            this.startNow.Name = "startNow";
            this.startNow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.startNow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.startNow.OnHoverForeColor = System.Drawing.Color.White;
            this.startNow.OnHoverImage = null;
            this.startNow.OnPressedColor = System.Drawing.Color.Black;
            this.startNow.Radius = 10;
            this.startNow.Size = new System.Drawing.Size(94, 35);
            this.startNow.TabIndex = 65;
            this.startNow.Text = "Start Now";
            this.startNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.startNow.Click += new System.EventHandler(this.startNow_Click);
            // 
            // addToQueue
            // 
            this.addToQueue.AnimationHoverSpeed = 0.07F;
            this.addToQueue.AnimationSpeed = 0.03F;
            this.addToQueue.BackColor = System.Drawing.Color.Transparent;
            this.addToQueue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.addToQueue.BorderColor = System.Drawing.Color.Black;
            this.addToQueue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addToQueue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addToQueue.FocusedColor = System.Drawing.Color.Empty;
            this.addToQueue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.addToQueue.ForeColor = System.Drawing.Color.White;
            this.addToQueue.Image = null;
            this.addToQueue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addToQueue.ImageSize = new System.Drawing.Size(20, 20);
            this.addToQueue.Location = new System.Drawing.Point(749, 514);
            this.addToQueue.Name = "addToQueue";
            this.addToQueue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.addToQueue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addToQueue.OnHoverForeColor = System.Drawing.Color.White;
            this.addToQueue.OnHoverImage = null;
            this.addToQueue.OnPressedColor = System.Drawing.Color.Black;
            this.addToQueue.Radius = 10;
            this.addToQueue.Size = new System.Drawing.Size(123, 35);
            this.addToQueue.TabIndex = 66;
            this.addToQueue.Text = "Add To Queue";
            this.addToQueue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addToQueue.Click += new System.EventHandler(this.addToQueue_Click);
            // 
            // deletePreset
            // 
            this.deletePreset.AnimationHoverSpeed = 0.07F;
            this.deletePreset.AnimationSpeed = 0.03F;
            this.deletePreset.BackColor = System.Drawing.Color.Transparent;
            this.deletePreset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.deletePreset.BorderColor = System.Drawing.Color.Black;
            this.deletePreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePreset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletePreset.FocusedColor = System.Drawing.Color.Empty;
            this.deletePreset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.deletePreset.ForeColor = System.Drawing.Color.White;
            this.deletePreset.Image = null;
            this.deletePreset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletePreset.ImageSize = new System.Drawing.Size(20, 20);
            this.deletePreset.Location = new System.Drawing.Point(564, 514);
            this.deletePreset.Name = "deletePreset";
            this.deletePreset.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.deletePreset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.deletePreset.OnHoverForeColor = System.Drawing.Color.White;
            this.deletePreset.OnHoverImage = null;
            this.deletePreset.OnPressedColor = System.Drawing.Color.Black;
            this.deletePreset.Radius = 10;
            this.deletePreset.Size = new System.Drawing.Size(79, 35);
            this.deletePreset.TabIndex = 67;
            this.deletePreset.Text = "Delete";
            this.deletePreset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletePreset.Click += new System.EventHandler(this.deletePreset_Click);
            // 
            // editButton
            // 
            this.editButton.AnimationHoverSpeed = 0.07F;
            this.editButton.AnimationSpeed = 0.03F;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.editButton.BorderColor = System.Drawing.Color.Black;
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.editButton.FocusedColor = System.Drawing.Color.Empty;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Image = null;
            this.editButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editButton.ImageSize = new System.Drawing.Size(20, 20);
            this.editButton.Location = new System.Drawing.Point(479, 514);
            this.editButton.Name = "editButton";
            this.editButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.editButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.editButton.OnHoverForeColor = System.Drawing.Color.White;
            this.editButton.OnHoverImage = null;
            this.editButton.OnPressedColor = System.Drawing.Color.Black;
            this.editButton.Radius = 10;
            this.editButton.Size = new System.Drawing.Size(79, 35);
            this.editButton.TabIndex = 68;
            this.editButton.Text = "Edit";
            this.editButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newPresetButton
            // 
            this.newPresetButton.AnimationHoverSpeed = 0.07F;
            this.newPresetButton.AnimationSpeed = 0.03F;
            this.newPresetButton.BackColor = System.Drawing.Color.Transparent;
            this.newPresetButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.newPresetButton.BorderColor = System.Drawing.Color.Black;
            this.newPresetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPresetButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newPresetButton.FocusedColor = System.Drawing.Color.Empty;
            this.newPresetButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newPresetButton.ForeColor = System.Drawing.Color.White;
            this.newPresetButton.Image = null;
            this.newPresetButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPresetButton.ImageSize = new System.Drawing.Size(20, 20);
            this.newPresetButton.Location = new System.Drawing.Point(12, 514);
            this.newPresetButton.Name = "newPresetButton";
            this.newPresetButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.newPresetButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newPresetButton.OnHoverForeColor = System.Drawing.Color.White;
            this.newPresetButton.OnHoverImage = null;
            this.newPresetButton.OnPressedColor = System.Drawing.Color.Black;
            this.newPresetButton.Radius = 10;
            this.newPresetButton.Size = new System.Drawing.Size(108, 35);
            this.newPresetButton.TabIndex = 69;
            this.newPresetButton.Text = "New Preset..";
            this.newPresetButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPresetButton.Click += new System.EventHandler(this.newPresetButton_Click);
            // 
            // PresetManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.newPresetButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deletePreset);
            this.Controls.Add(this.addToQueue);
            this.Controls.Add(this.startNow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maximize);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PresetManager";
            this.Text = "Preset Manager";
            this.Activated += new System.EventHandler(this.PresetManager_Activated);
            this.Deactivate += new System.EventHandler(this.PresetManager_Deactivate);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI.WinForms.GunaLabel maximize;
        private Guna.UI.WinForms.GunaLabel minimize;
        private Guna.UI.WinForms.GunaLabel close;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton startNow;
        private Guna.UI.WinForms.GunaButton addToQueue;
        private Guna.UI.WinForms.GunaButton deletePreset;
        private Guna.UI.WinForms.GunaButton editButton;
        private Guna.UI.WinForms.GunaButton newPresetButton;
    }
}