namespace Light_Controller_1._0
{
    partial class ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.okButton = new Guna.UI.WinForms.GunaButton();
            this.cancelButton = new Guna.UI.WinForms.GunaButton();
            this.presetColors = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picker = new System.Windows.Forms.Panel();
            this.pen = new System.Windows.Forms.Label();
            this.currentColor = new Guna.UI.WinForms.GunaButton();
            this.newColor = new Guna.UI.WinForms.GunaButton();
            this.colorName = new System.Windows.Forms.Label();
            this.brightnessPicker = new System.Windows.Forms.Panel();
            this.brightnessPen = new System.Windows.Forms.Label();
            this.picker.SuspendLayout();
            this.brightnessPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.AnimationHoverSpeed = 0.07F;
            this.okButton.AnimationSpeed = 0.03F;
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.okButton.BorderColor = System.Drawing.Color.Black;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okButton.FocusedColor = System.Drawing.Color.Empty;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Image = null;
            this.okButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.okButton.ImageSize = new System.Drawing.Size(20, 20);
            this.okButton.Location = new System.Drawing.Point(355, 428);
            this.okButton.Name = "okButton";
            this.okButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.okButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.okButton.OnHoverForeColor = System.Drawing.Color.White;
            this.okButton.OnHoverImage = null;
            this.okButton.OnPressedColor = System.Drawing.Color.Black;
            this.okButton.Radius = 10;
            this.okButton.Size = new System.Drawing.Size(79, 38);
            this.okButton.TabIndex = 64;
            this.okButton.Text = "OK";
            this.okButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.AnimationHoverSpeed = 0.07F;
            this.cancelButton.AnimationSpeed = 0.03F;
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cancelButton.BorderColor = System.Drawing.Color.Black;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cancelButton.FocusedColor = System.Drawing.Color.Empty;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Image = null;
            this.cancelButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelButton.ImageSize = new System.Drawing.Size(20, 20);
            this.cancelButton.Location = new System.Drawing.Point(270, 428);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.cancelButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.cancelButton.OnHoverForeColor = System.Drawing.Color.White;
            this.cancelButton.OnHoverImage = null;
            this.cancelButton.OnPressedColor = System.Drawing.Color.Black;
            this.cancelButton.Radius = 10;
            this.cancelButton.Size = new System.Drawing.Size(79, 38);
            this.cancelButton.TabIndex = 65;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // presetColors
            // 
            this.presetColors.Location = new System.Drawing.Point(29, 280);
            this.presetColors.Name = "presetColors";
            this.presetColors.Size = new System.Drawing.Size(390, 31);
            this.presetColors.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Current color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(135, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "New color";
            // 
            // picker
            // 
            this.picker.Controls.Add(this.pen);
            this.picker.Location = new System.Drawing.Point(29, 24);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(390, 250);
            this.picker.TabIndex = 72;
            this.picker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picker_MouseDown);
            this.picker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picker_MouseMove);
            this.picker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picker_MouseUp);
            // 
            // pen
            // 
            this.pen.AutoSize = true;
            this.pen.BackColor = System.Drawing.Color.Transparent;
            this.pen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pen.ForeColor = System.Drawing.Color.White;
            this.pen.Location = new System.Drawing.Point(21, 21);
            this.pen.Name = "pen";
            this.pen.Size = new System.Drawing.Size(33, 31);
            this.pen.TabIndex = 0;
            this.pen.Text = "○";
            this.pen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pen_MouseDown);
            this.pen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pen_MouseMove);
            this.pen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picker_MouseUp);
            // 
            // currentColor
            // 
            this.currentColor.AnimationHoverSpeed = 0.07F;
            this.currentColor.AnimationSpeed = 0.03F;
            this.currentColor.BackColor = System.Drawing.Color.Transparent;
            this.currentColor.BaseColor = System.Drawing.Color.Black;
            this.currentColor.BorderColor = System.Drawing.Color.Black;
            this.currentColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.currentColor.FocusedColor = System.Drawing.Color.Empty;
            this.currentColor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.currentColor.ForeColor = System.Drawing.Color.White;
            this.currentColor.Image = global::Light_Controller_1._0.Properties.Resources.light_setable_color;
            this.currentColor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentColor.ImageSize = new System.Drawing.Size(70, 70);
            this.currentColor.Location = new System.Drawing.Point(44, 373);
            this.currentColor.Name = "currentColor";
            this.currentColor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.currentColor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.currentColor.OnHoverForeColor = System.Drawing.Color.White;
            this.currentColor.OnHoverImage = null;
            this.currentColor.OnPressedColor = System.Drawing.Color.Black;
            this.currentColor.Size = new System.Drawing.Size(70, 70);
            this.currentColor.TabIndex = 75;
            this.currentColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newColor
            // 
            this.newColor.AnimationHoverSpeed = 0.07F;
            this.newColor.AnimationSpeed = 0.03F;
            this.newColor.BackColor = System.Drawing.Color.Transparent;
            this.newColor.BaseColor = System.Drawing.Color.DodgerBlue;
            this.newColor.BorderColor = System.Drawing.Color.Black;
            this.newColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.newColor.FocusedColor = System.Drawing.Color.Empty;
            this.newColor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.newColor.ForeColor = System.Drawing.Color.White;
            this.newColor.Image = global::Light_Controller_1._0.Properties.Resources.light_setable_color;
            this.newColor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newColor.ImageSize = new System.Drawing.Size(70, 70);
            this.newColor.Location = new System.Drawing.Point(120, 373);
            this.newColor.Name = "newColor";
            this.newColor.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.newColor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.newColor.OnHoverForeColor = System.Drawing.Color.White;
            this.newColor.OnHoverImage = null;
            this.newColor.OnPressedColor = System.Drawing.Color.Black;
            this.newColor.Size = new System.Drawing.Size(70, 70);
            this.newColor.TabIndex = 76;
            this.newColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colorName
            // 
            this.colorName.AutoSize = true;
            this.colorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.colorName.ForeColor = System.Drawing.Color.White;
            this.colorName.Location = new System.Drawing.Point(215, 368);
            this.colorName.Name = "colorName";
            this.colorName.Size = new System.Drawing.Size(41, 17);
            this.colorName.TabIndex = 77;
            this.colorName.Text = "Color";
            // 
            // brightnessPicker
            // 
            this.brightnessPicker.Controls.Add(this.brightnessPen);
            this.brightnessPicker.Location = new System.Drawing.Point(29, 319);
            this.brightnessPicker.Name = "brightnessPicker";
            this.brightnessPicker.Size = new System.Drawing.Size(390, 31);
            this.brightnessPicker.TabIndex = 67;
            this.brightnessPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.brightnessPicker_MouseDown);
            this.brightnessPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.brightnessPicker_MouseMove);
            this.brightnessPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.brightnessPicker_MouseUp);
            // 
            // brightnessPen
            // 
            this.brightnessPen.BackColor = System.Drawing.Color.Transparent;
            this.brightnessPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.brightnessPen.ForeColor = System.Drawing.Color.Black;
            this.brightnessPen.Location = new System.Drawing.Point(3, -3);
            this.brightnessPen.Name = "brightnessPen";
            this.brightnessPen.Size = new System.Drawing.Size(21, 31);
            this.brightnessPen.TabIndex = 1;
            this.brightnessPen.Text = "|";
            this.brightnessPen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(446, 478);
            this.Controls.Add(this.brightnessPicker);
            this.Controls.Add(this.colorName);
            this.Controls.Add(this.newColor);
            this.Controls.Add(this.currentColor);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.presetColors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorPicker";
            this.ShowInTaskbar = false;
            this.Text = "ColorPicker";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pickerClosed);
            this.picker.ResumeLayout(false);
            this.picker.PerformLayout();
            this.brightnessPicker.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton okButton;
        private Guna.UI.WinForms.GunaButton cancelButton;
        private System.Windows.Forms.Panel presetColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel picker;
        private System.Windows.Forms.Label pen;
        private Guna.UI.WinForms.GunaButton currentColor;
        private Guna.UI.WinForms.GunaButton newColor;
        private System.Windows.Forms.Label colorName;
        private System.Windows.Forms.Panel brightnessPicker;
        private System.Windows.Forms.Label brightnessPen;
    }
}