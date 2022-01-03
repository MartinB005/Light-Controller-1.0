using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Light_Controller_1._0
{
    public partial class PresetManager : Form
    {
        private bool dragging;
        private int[][] colorNumber;
        private int selectedPreset = -1;
        private bool[] selectedPresets;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private List<Preset> presets;
        private MainGUI mainGUI;
        public bool soonStart;
        public static bool activated;

        public PresetManager(MainGUI mainGUI)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            LoadPresets();
            Paint += OnPaint;
            flowLayoutPanel.MouseDown += Form1_MouseDown;
            flowLayoutPanel.MouseMove += Form1_MouseMove;
            flowLayoutPanel.MouseUp += Form1_MouseUp;
            this.mainGUI = mainGUI;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Close();
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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
            for (int i = 0; i < selectedPresets.Length; i++) selectedPresets[i] = false;
            foreach (Control control in flowLayoutPanel.Controls)
                control.BackColor = Color.Transparent;
            selectedPreset = -1;
            SetOperationsEnabled(false);
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

        protected void OnPaint(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = ClientRectangle;
            rectangle.Size = new Size(rectangle.Width - 1, rectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, rectangle);
        }

        public void LoadPresets()
        {
            SetOperationsEnabled(false);
            flowLayoutPanel.Controls.Clear();
            selectedPreset = -1;
            presets = Preset.GetLocalPresets();
            int i = 0;
            colorNumber = new int[presets.Count][];
            selectedPresets = new bool[presets.Count];
            foreach (Preset preset in presets)
            {
                Panel panel = CreatePresetPanel(preset, false);
                panel.AutoSize = true;
                panel.MouseEnter += panel_MouseEnter;
                panel.MouseLeave += panel_MouseLeave;
                panel.MouseDown += panel_MouseDown;
                panel.MouseUp += panel_MouseUp;
                panel.MouseDoubleClick += panel_DoubleClick;
                panel.Tag = i;
                flowLayoutPanel.Controls.Add(panel);
                colorNumber[i] = new int[4];
                i++;
                foreach (Control control in panel.Controls) setClickFocusToControl(control);
            }
        }


        private void panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel) sender : (Panel) ((Control) sender).Parent;
            panel.BackColor = Color.FromArgb(50, 255, 255, 255);
            foreach (Control control in panel.Controls) control.BackColor = Color.Transparent;
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel) sender : (Panel)((Control)sender).Parent;
            int tag = Convert.ToInt32(panel.Tag.ToString());
            if ((selectedPreset == tag) || (selectedPresets[tag]))
                panel.BackColor = Color.FromArgb(50, 255, 255, 255);
            else panel.BackColor = Color.Transparent;
        }

        private void panel_MouseUp(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent;
            bool ctrlIsPressed = Form.ModifierKeys == Keys.Control;
            SelectPreset(panel, ctrlIsPressed);
        }

        private void SelectPreset(Control panel, bool multiSelection)
        {
            if (panel != null)
            {
                if ((multiSelection) && (selectedPreset >= 0)) selectedPresets[selectedPreset] = true;
                selectedPreset = Convert.ToInt32(panel.Tag.ToString());
                bool unSelect = selectedPresets[selectedPreset] && multiSelection;
                foreach (Control control in panel.Controls)
                    control.Invoke(new Action(() => control.BackColor = Color.Transparent));
                if (multiSelection) selectedPresets[selectedPreset] = !unSelect;
                else
                {
                    foreach (Control control in flowLayoutPanel.Controls)
                        control.Invoke(new Action(() => control.BackColor = Color.Transparent));
                    for (int i = 0; i < selectedPresets.Length; i++) selectedPresets[i] = false;
                }
                if (activated)
                {
                    Invoke(new Action(() => SetOperationsEnabled(true)));
                    Color color = unSelect ? Color.Transparent : Color.FromArgb(50, 255, 255, 255);
                    panel.Invoke(new Action(() => panel.BackColor = color));
                    if (unSelect) for (int i = 0; i < selectedPresets.Length; i++)
                            if (selectedPresets[i]) selectedPreset = i;
                }
            }
        }

        private void panel_MouseDown(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent; 
            panel.BackColor = Color.FromArgb(50, 150, 150, 150);
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            Panel panel = sender is Panel ? (Panel)sender : (Panel)((Control)sender).Parent;
            addSelectedPresetsToQueue();
            Close();
        }

            public static Panel CreatePresetPanel(Preset preset, bool queueMode)
        {
            Panel panel = new Panel();
            Guna.UI.WinForms.GunaLabel label = new Guna.UI.WinForms.GunaLabel();
            label.Text = preset.name;
            label.Font = new Font("Calibri", 12, FontStyle.Bold);
            label.Location = new Point(10, 5);
            label.ForeColor = Color.White;
            label.AutoSize = true;
            Guna.UI.WinForms.GunaLabel description = new Guna.UI.WinForms.GunaLabel();
            if (!queueMode) description.Text = getPresetValues(preset);
            description.AutoSize = true;
            description.Location = new Point(10, 30);
            description.ForeColor = Color.White;
            description.Tag = "description";
            panel.Controls.Add(description);
            panel.Controls.Add(label);
            for(int i = 0; i < 4; i++)
            {
                Guna.UI.WinForms.GunaLabel light = new Guna.UI.WinForms.GunaLabel();
                light.Text = "•";
                light.Tag = i;
                light.Font = new Font(light.Font.Name, 50);
                light.ForeColor = preset.colors[0][i].createColor();
                light.Location = new Point(i * 60 + 10, queueMode ? 15 : 35);
                light.AutoSize = true;
                panel.Controls.Add(light);
            }
            return panel;
        }

        private void setClickFocusToControl(Control control)
        {
            control.MouseEnter += panel_MouseEnter;
            control.MouseLeave += panel_MouseLeave;
            control.MouseDown += panel_MouseDown;
            control.MouseUp += panel_MouseUp;
            control.MouseDoubleClick += panel_DoubleClick;
        }


        private static string getPresetValues(Preset preset)
        {
            string[] speeds = { "2 bt", "1 bt", "1/2 bt", "1/4 bt", "1/8 bt" };
            return "Color Speed: " + speeds[preset.colorSpeed] +
                    ", Brightness: " + preset.brightness + ",\nFade In: "
                    + (preset.fadeIn ? "ON" : "OFF") + ", Fade Out: "
                    + (preset.fadeOut ? "ON" : "OFF") + ", Bar Sync: "
                    + (preset.barSync ? "ON" : "OFF");
        }

        public void nextBeat()
        {
            foreach(Control control in flowLayoutPanel.Controls)
            {
                int number = Convert.ToInt32(control.Tag.ToString());
                foreach (Control light in control.Controls)
                {
                    if (light.Tag != null)
                    {
                        int lightNumber;
                        bool isLight = int.TryParse(light.Tag.ToString(), out lightNumber);
                        if (isLight)
                        {
                            light.Invoke(new Action(() => light.ForeColor = presets[number]
                            .colors[colorNumber[number][lightNumber]][lightNumber].createColor()));
                            colorNumber[number][lightNumber]++;
                            if (this.colorNumber[number][lightNumber] >= presets[number].colors.Length)
                                colorNumber[number][lightNumber] = 0;
                        }
                    }
                }
            }
        }

        private void SetOperationsEnabled(bool enabled)
        {
            editButton.Enabled = enabled && !isMoreSelected();
            deletePreset.Enabled = enabled;
            startNow.Enabled = enabled && !isMoreSelected();
            addToQueue.Enabled = enabled;
        }

        private void flowLayoutPanel_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel.Controls)
                control.BackColor = Color.Transparent;
            selectedPreset = -1;
            SetOperationsEnabled(false);
        }

        private void deletePreset_Click(object sender, EventArgs e)
        {
            if(isMoreSelected()) 
                for (int i = 0; i < selectedPresets.Length; i++) 
                    if (selectedPresets[i]) presets[i].Delete();
            else presets[selectedPreset].Delete();
            selectedPreset = -1;
            LoadPresets();
        }

        private void newPresetButton_Click(object sender, EventArgs e)
        {
            mainGUI.CreateNewPreset();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            mainGUI.ShowPresetOptions(presets[selectedPreset], true);
        }

        private void startNow_Click(object sender, EventArgs e)
        {
            soonStart = true;
            mainGUI.startPreset(presets[selectedPreset]);
        }

        private void addToQueue_Click(object sender, EventArgs e)
        {
            addSelectedPresetsToQueue();
        }

        public void addSelectedPresetsToQueue()
        {
            if (isMoreSelected())
            {
                for (int i = 0; i < selectedPresets.Length; i++)
                    if (selectedPresets[i]) addPreset(i);
            }
            else addPreset(selectedPreset);
            Invoke(new Action(() => mainGUI.UpdateQueue()));
        }

        private void addPreset(int index)
        {
            Preset preset = presets[index];
            if (mainGUI.queue.Contains(preset))
                preset = preset.Clone();
            mainGUI.queue.Add(preset);
        }

        private void PresetManager_Activated(object sender, EventArgs e)
        {
            activated = true;
        }

        private void PresetManager_Deactivate(object sender, EventArgs e)
        {
            activated = false;
        }

        public void scrollSelection(int value)
        {
            int selection = value / (980 / presets.Count + 10);
            if (selection != selectedPreset)
                foreach (Panel item in flowLayoutPanel.Controls)
                    if (Convert.ToInt32(item.Tag.ToString()) == selection) SelectPreset(item, false);
        }

        private bool isMoreSelected()
        {
            int count = 0;
            for (int i = 0; i < selectedPresets.Length; i++) if (selectedPresets[i]) count++;
            return count > 1;
        }
    }
}
