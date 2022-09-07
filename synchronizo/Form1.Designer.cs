using System.Drawing;
using System.Windows.Forms;

namespace synchronizo
{
    partial class synchronizo_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(synchronizo_home));
            this.wave_viewer_panel = new System.Windows.Forms.Panel();
            this.mic_waveViewer = new NAudio.Gui.WaveViewer();
            this.input_comboBox = new System.Windows.Forms.ComboBox();
            this.output_progressBar = new System.Windows.Forms.ProgressBar();
            this.video_browser_button = new System.Windows.Forms.Button();
            this.data_viewer_panel = new System.Windows.Forms.Panel();
            this.modeUpdate_progressBar = new System.Windows.Forms.ProgressBar();
            this.modeSelector_comboBox = new System.Windows.Forms.ComboBox();
            this.molt_richTextBox = new System.Windows.Forms.RichTextBox();
            this.headphone_icon = new System.Windows.Forms.PictureBox();
            this.mic_icon = new System.Windows.Forms.PictureBox();
            this.output_comboBox = new System.Windows.Forms.ComboBox();
            this.input_progressBar = new System.Windows.Forms.ProgressBar();
            this.video_panel = new System.Windows.Forms.Panel();
            this.noVideo_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.video_viewer_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.audio_timer = new System.Windows.Forms.Timer(this.components);
            this.peaksSum_timer = new System.Windows.Forms.Timer(this.components);
            this.modeSelectorUpdater_timer = new System.Windows.Forms.Timer(this.components);
            this.volume_button = new System.Windows.Forms.Button();
            this.playPause_Button = new System.Windows.Forms.Button();
            this.volumeZone_panel = new System.Windows.Forms.Panel();
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.volumeTrackBar_timer = new System.Windows.Forms.Timer(this.components);
            this.wave_viewer_panel.SuspendLayout();
            this.data_viewer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headphone_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic_icon)).BeginInit();
            this.video_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_viewer_wmp)).BeginInit();
            this.volumeZone_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // wave_viewer_panel
            // 
            this.wave_viewer_panel.BackColor = System.Drawing.Color.LightYellow;
            this.wave_viewer_panel.Controls.Add(this.mic_waveViewer);
            resources.ApplyResources(this.wave_viewer_panel, "wave_viewer_panel");
            this.wave_viewer_panel.Name = "wave_viewer_panel";
            // 
            // mic_waveViewer
            // 
            this.mic_waveViewer.BackColor = System.Drawing.Color.PeachPuff;
            resources.ApplyResources(this.mic_waveViewer, "mic_waveViewer");
            this.mic_waveViewer.Name = "mic_waveViewer";
            this.mic_waveViewer.SamplesPerPixel = 128;
            this.mic_waveViewer.StartPosition = ((long)(0));
            this.mic_waveViewer.WaveStream = null;
            // 
            // input_comboBox
            // 
            this.input_comboBox.BackColor = System.Drawing.Color.SteelBlue;
            this.input_comboBox.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.input_comboBox, "input_comboBox");
            this.input_comboBox.ForeColor = System.Drawing.Color.White;
            this.input_comboBox.FormattingEnabled = true;
            this.input_comboBox.Name = "input_comboBox";
            // 
            // output_progressBar
            // 
            resources.ApplyResources(this.output_progressBar, "output_progressBar");
            this.output_progressBar.Name = "output_progressBar";
            // 
            // video_browser_button
            // 
            resources.ApplyResources(this.video_browser_button, "video_browser_button");
            this.video_browser_button.Name = "video_browser_button";
            this.video_browser_button.UseVisualStyleBackColor = true;
            this.video_browser_button.Click += new System.EventHandler(this.video_browser_button_Click);
            // 
            // data_viewer_panel
            // 
            this.data_viewer_panel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.data_viewer_panel.Controls.Add(this.modeUpdate_progressBar);
            this.data_viewer_panel.Controls.Add(this.modeSelector_comboBox);
            this.data_viewer_panel.Controls.Add(this.molt_richTextBox);
            this.data_viewer_panel.Controls.Add(this.headphone_icon);
            this.data_viewer_panel.Controls.Add(this.mic_icon);
            this.data_viewer_panel.Controls.Add(this.output_comboBox);
            this.data_viewer_panel.Controls.Add(this.input_progressBar);
            this.data_viewer_panel.Controls.Add(this.input_comboBox);
            this.data_viewer_panel.Controls.Add(this.video_browser_button);
            this.data_viewer_panel.Controls.Add(this.output_progressBar);
            resources.ApplyResources(this.data_viewer_panel, "data_viewer_panel");
            this.data_viewer_panel.Name = "data_viewer_panel";
            // 
            // modeUpdate_progressBar
            // 
            resources.ApplyResources(this.modeUpdate_progressBar, "modeUpdate_progressBar");
            this.modeUpdate_progressBar.Name = "modeUpdate_progressBar";
            // 
            // modeSelector_comboBox
            // 
            resources.ApplyResources(this.modeSelector_comboBox, "modeSelector_comboBox");
            this.modeSelector_comboBox.FormattingEnabled = true;
            this.modeSelector_comboBox.Items.AddRange(new object[] {
            resources.GetString("modeSelector_comboBox.Items"),
            resources.GetString("modeSelector_comboBox.Items1"),
            resources.GetString("modeSelector_comboBox.Items2")});
            this.modeSelector_comboBox.Name = "modeSelector_comboBox";
            // 
            // molt_richTextBox
            // 
            this.molt_richTextBox.BackColor = System.Drawing.Color.Cornsilk;
            this.molt_richTextBox.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.molt_richTextBox, "molt_richTextBox");
            this.molt_richTextBox.HideSelection = false;
            this.molt_richTextBox.Name = "molt_richTextBox";
            this.molt_richTextBox.ReadOnly = true;
            // 
            // headphone_icon
            // 
            resources.ApplyResources(this.headphone_icon, "headphone_icon");
            this.headphone_icon.Image = global::synchronizo.Properties.Resources.hp;
            this.headphone_icon.Name = "headphone_icon";
            this.headphone_icon.TabStop = false;
            // 
            // mic_icon
            // 
            resources.ApplyResources(this.mic_icon, "mic_icon");
            this.mic_icon.Image = global::synchronizo.Properties.Resources.mic;
            this.mic_icon.Name = "mic_icon";
            this.mic_icon.TabStop = false;
            // 
            // output_comboBox
            // 
            this.output_comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.output_comboBox.BackColor = System.Drawing.Color.SteelBlue;
            resources.ApplyResources(this.output_comboBox, "output_comboBox");
            this.output_comboBox.ForeColor = System.Drawing.Color.White;
            this.output_comboBox.FormattingEnabled = true;
            this.output_comboBox.Name = "output_comboBox";
            // 
            // input_progressBar
            // 
            this.input_progressBar.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.input_progressBar, "input_progressBar");
            this.input_progressBar.Name = "input_progressBar";
            // 
            // video_panel
            // 
            this.video_panel.BackColor = System.Drawing.Color.PeachPuff;
            this.video_panel.Controls.Add(this.noVideo_RichTextBox);
            this.video_panel.Controls.Add(this.video_viewer_wmp);
            resources.ApplyResources(this.video_panel, "video_panel");
            this.video_panel.Name = "video_panel";
            // 
            // noVideo_RichTextBox
            // 
            this.noVideo_RichTextBox.BackColor = System.Drawing.Color.PeachPuff;
            this.noVideo_RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noVideo_RichTextBox.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.noVideo_RichTextBox, "noVideo_RichTextBox");
            this.noVideo_RichTextBox.ForeColor = System.Drawing.Color.Thistle;
            this.noVideo_RichTextBox.Name = "noVideo_RichTextBox";
            this.noVideo_RichTextBox.ReadOnly = true;
            // 
            // video_viewer_wmp
            // 
            resources.ApplyResources(this.video_viewer_wmp, "video_viewer_wmp");
            this.video_viewer_wmp.Name = "video_viewer_wmp";
            this.video_viewer_wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("video_viewer_wmp.OcxState")));
            // 
            // audio_timer
            // 
            this.audio_timer.Interval = 10;
            this.audio_timer.Tick += new System.EventHandler(this.audio_timer_Tick);
            // 
            // peaksSum_timer
            // 
            this.peaksSum_timer.Interval = 5000;
            this.peaksSum_timer.Tick += new System.EventHandler(this.peaksSum_timer_Tick);
            // 
            // modeSelectorUpdater_timer
            // 
            this.modeSelectorUpdater_timer.Interval = 500;
            this.modeSelectorUpdater_timer.Tick += new System.EventHandler(this.modeSelectorUpdater_timer_Tick);
            // 
            // volume_button
            // 
            this.volume_button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.volume_button, "volume_button");
            this.volume_button.FlatAppearance.BorderSize = 0;
            this.volume_button.ForeColor = System.Drawing.Color.Transparent;
            this.volume_button.Image = global::synchronizo.Properties.Resources.volume_off;
            this.volume_button.Name = "volume_button";
            this.volume_button.UseVisualStyleBackColor = false;
            this.volume_button.Click += new System.EventHandler(this.volume_button_Click);
            this.volume_button.MouseLeave += new System.EventHandler(this.volume_zone_Leave);
            this.volume_button.MouseHover += new System.EventHandler(this.volume_button_MouseHover);
            // 
            // playPause_Button
            // 
            this.playPause_Button.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.playPause_Button, "playPause_Button");
            this.playPause_Button.FlatAppearance.BorderSize = 0;
            this.playPause_Button.ForeColor = System.Drawing.Color.Transparent;
            this.playPause_Button.Name = "playPause_Button";
            this.playPause_Button.UseVisualStyleBackColor = false;
            this.playPause_Button.Click += new System.EventHandler(this.playPause_Button_Click);
            // 
            // volumeZone_panel
            // 
            this.volumeZone_panel.BackColor = System.Drawing.Color.Transparent;
            this.volumeZone_panel.Controls.Add(this.volume_trackBar);
            this.volumeZone_panel.Controls.Add(this.volume_button);
            this.volumeZone_panel.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.volumeZone_panel, "volumeZone_panel");
            this.volumeZone_panel.Name = "volumeZone_panel";
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.BackColor = System.Drawing.Color.Linen;
            resources.ApplyResources(this.volume_trackBar, "volume_trackBar");
            this.volume_trackBar.Maximum = 100;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Scroll += new System.EventHandler(this.volume_trackBar_Scroll);
            this.volume_trackBar.MouseLeave += new System.EventHandler(this.volume_zone_Leave);
            this.volume_trackBar.MouseHover += new System.EventHandler(this.volume_trackBar_MouseHover);
            // 
            // volumeTrackBar_timer
            // 
            this.volumeTrackBar_timer.Interval = 800;
            this.volumeTrackBar_timer.Tick += new System.EventHandler(this.volumeTrackBar_timer_Tick);
            // 
            // synchronizo_home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.volumeZone_panel);
            this.Controls.Add(this.playPause_Button);
            this.Controls.Add(this.data_viewer_panel);
            this.Controls.Add(this.wave_viewer_panel);
            this.Controls.Add(this.video_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "synchronizo_home";
            this.Load += new System.EventHandler(this.synchronizo_Load);
            this.wave_viewer_panel.ResumeLayout(false);
            this.data_viewer_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headphone_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic_icon)).EndInit();
            this.video_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.video_viewer_wmp)).EndInit();
            this.volumeZone_panel.ResumeLayout(false);
            this.volumeZone_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel wave_viewer_panel;
        private System.Windows.Forms.Panel data_viewer_panel;
        public System.Windows.Forms.Button video_browser_button;
        public System.Windows.Forms.Panel video_panel;
        public RichTextBox noVideo_RichTextBox;
        private ComboBox input_comboBox;
        private Timer audio_timer;
        private ProgressBar output_progressBar;
        private NAudio.Gui.WaveViewer mic_waveViewer;
        private ProgressBar input_progressBar;
        private ComboBox output_comboBox;
        private PictureBox headphone_icon;
        private PictureBox mic_icon;
        private Timer peaksSum_timer;
        private RichTextBox molt_richTextBox;
        private ComboBox modeSelector_comboBox;
        private ProgressBar modeUpdate_progressBar;
        private Timer modeSelectorUpdater_timer;
        private Button playPause_Button;
        public AxWMPLib.AxWindowsMediaPlayer video_viewer_wmp;
        private Button volume_button;
        private Panel volumeZone_panel;
        private TrackBar volume_trackBar;
        private Timer volumeTrackBar_timer;
    }
}

