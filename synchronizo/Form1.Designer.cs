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
            this.headphone_icon = new System.Windows.Forms.PictureBox();
            this.mic_icon = new System.Windows.Forms.PictureBox();
            this.output_comboBox = new System.Windows.Forms.ComboBox();
            this.input_progressBar = new System.Windows.Forms.ProgressBar();
            this.video_panel = new System.Windows.Forms.Panel();
            this.noVideo_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.video_viewer_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.audio_timer = new System.Windows.Forms.Timer(this.components);
            this.wave_viewer_panel.SuspendLayout();
            this.data_viewer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headphone_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mic_icon)).BeginInit();
            this.video_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.video_viewer_wmp)).BeginInit();
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
            // headphone_icon
            // 
            resources.ApplyResources(this.headphone_icon, "headphone_icon");
            this.headphone_icon.Name = "headphone_icon";
            this.headphone_icon.TabStop = false;
            // 
            // mic_icon
            // 
            resources.ApplyResources(this.mic_icon, "mic_icon");
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
            this.audio_timer.Enabled = true;
            this.audio_timer.Interval = 10;
            this.audio_timer.Tick += new System.EventHandler(this.audio_timer_Tick);
            // 
            // synchronizo_home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel wave_viewer_panel;
        private System.Windows.Forms.Panel data_viewer_panel;
        public System.Windows.Forms.Button video_browser_button;
        public System.Windows.Forms.Panel video_panel;
        private AxWMPLib.AxWindowsMediaPlayer video_viewer_wmp;
        public RichTextBox noVideo_RichTextBox;
        private ComboBox input_comboBox;
        private Timer audio_timer;
        private ProgressBar output_progressBar;
        private NAudio.Gui.WaveViewer mic_waveViewer;
        private ProgressBar input_progressBar;
        private ComboBox output_comboBox;
        private PictureBox headphone_icon;
        private PictureBox mic_icon;
    }
}

