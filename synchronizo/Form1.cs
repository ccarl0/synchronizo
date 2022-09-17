using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synchronizo
{
    public partial class synchronizo_home : Form
    {
        string videoPath;
        int peaksSum = 0;
        int prevVolume = 0;
        bool waveRecording = false;
        
        public synchronizo_home()
        {
            InitializeComponent();
            PlotInitialize();
            //input and output device dropdown menu
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var input_devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            var output_devices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            input_comboBox.Items.AddRange(input_devices.ToArray());
            output_comboBox.Items.AddRange(output_devices.ToArray());
            
            //moltiplicator rich text box
            molt_richTextBox.SelectAll();
            molt_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            molt_richTextBox.DeselectAll();

            //wmp
            video_viewer_wmp.uiMode = "none";
            video_viewer_wmp.settings.volume = 50;

            //volume_trackbar
            volume_trackBar.Value = 50;
        }

        //-----------------------------
        private double[] amplitudes;
        private void PlotInitialize(int pointCount = 500)
        {
            amplitudes = new double[pointCount];
            waveViewer_formsPlot.Plot.Clear();
            waveViewer_formsPlot.Plot.AddSignal(amplitudes, sampleRate: 1000.0 / 20);
            waveViewer_formsPlot.Plot.AddVerticalLine(0, color: Color.Red, width: 1);
            waveViewer_formsPlot.Plot.AddVerticalLine(0, color: Color.Black, width: 1);
            waveViewer_formsPlot.Plot.YLabel("Amplitude (%)");
            waveViewer_formsPlot.Plot.XLabel("Time (seconds)");
            waveViewer_formsPlot.Render();
        }

        private void PlotAddPoint(double value)
        {
            int amplitudesIndex = buffersRead % amplitudes.Length;
            amplitudes[amplitudesIndex] = value;
        }

        private WaveInEvent wvin;
        private int buffersRead = 0;
        private double peakAmplitudeSeen = 0;
        public double amplitudeMic = 0;
        private void OnDataAvailable(object sender, NAudio.Wave.WaveInEventArgs args)
        {
            int bytesPerSample = wvin.WaveFormat.BitsPerSample / 8;
            int samplesRecorded = args.BytesRecorded / bytesPerSample;
            Int16[] lastBuffer = new Int16[samplesRecorded];
            for (int i = 0; i < samplesRecorded; i++)
                lastBuffer[i] = BitConverter.ToInt16(args.Buffer, i * bytesPerSample);
            int lastBufferAmplitude = lastBuffer.Max() - lastBuffer.Min();
            double amplitude = (double)lastBufferAmplitude / Math.Pow(2, wvin.WaveFormat.BitsPerSample);
            if (amplitude > peakAmplitudeSeen)
                peakAmplitudeSeen = amplitude;
            amplitude = amplitude / peakAmplitudeSeen * 100;
            buffersRead += 1;

            //Console.WriteLine(string.Format("Buffer {0:000} amplitude: {1:00.00}%", buffersRead, amplitude));
            PlotAddPoint(amplitude);
            amplitudeMic = amplitude;
            //Console.WriteLine(amplitude);
        }

        private void AudioMonitorInitialize(int DeviceIndex, int sampleRate = 8000, int bitRate = 16, int channels = 1, int bufferMilliseconds = 20, bool start = true)
        {
            Console.WriteLine("AudioMonitorInitialize");
            if (wvin == null)
            {
                wvin = new WaveInEvent();
                wvin.DeviceNumber = DeviceIndex;
                wvin.WaveFormat = new WaveFormat(sampleRate, bitRate, channels);
                wvin.DataAvailable += OnDataAvailable;
                wvin.BufferMilliseconds = bufferMilliseconds;
                if (start)
                {
                    Console.WriteLine("Rec started");
                    wvin.StartRecording();
                }
            }
        }

        private void startStopWaveIn_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("startStopWaveIn_button_Click");

            if (waveRecording)
            {
                if (wvin != null)
                {
                    wvin.StopRecording();
                    waveRecording = true;
                    wvin = null;
                }
                plotRender_timer.Start();
                Console.WriteLine("Rec stopped");
                waveRecording = false;
                startStopWaveIn_button.Text = "Start";
            }
            else if (!waveRecording)
            {
                plotRender_timer.Start();
                AudioMonitorInitialize(input_comboBox.SelectedIndex);
                Console.WriteLine("Rec started");
                waveRecording = true;
                startStopWaveIn_button.Text = "Stop";

            }
        }
        private void plotRender_timer_Tick(object sender, EventArgs e)
        {
            if (autoAxis_cBox.Checked)
            {
                waveViewer_formsPlot.Plot.AxisAuto();
                //waveViewer_formsPlot.Plot.TightenLayout();
            }
            waveViewer_formsPlot.Render();
        }
        //-----------------------------

        private void synchronizo_Load(object sender, EventArgs e)
        {

        }

        private void video_browser_button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Browse button clicked");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"..\..\resources\video"; //setting default dialog box folder
                //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos); // opening the browser at the default user video folder
                openFileDialog.Filter = "Video files (*.mp4, *.avi, ...)|*.mp4;*.mov;*.avi;.m4v;*.wmv;*.mpg;*.mpeg;*.mp4v;*.3g2;*.3gp2;*.3gp;*.3gpp"; // filtering available files
                openFileDialog.FilterIndex = 1; // selecting the default filter in the browser (mp4)
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    videoPath = openFileDialog.FileName;
                    Console.WriteLine($"Selected file filepath: {videoPath}");
                }
            }
            
            video_viewer_wmp.URL = videoPath;

            Console.WriteLine(synchronizo.Properties.Resources.playpause);

            if (video_viewer_wmp.URL != string.Empty)
            {
                noVideoText_label.Visible = false;
                video_viewer_wmp.Visible = true;
                //starting timers
                Console.WriteLine("Starting timers");
                audio_timer.Enabled = true;
                modeSelectorUpdater_timer.Enabled = true;
                peaksSum_timer.Enabled = true;
                Console.WriteLine(video_viewer_wmp.playState);
                if (video_viewer_wmp.playState == WMPLib.WMPPlayState.wmppsPlaying || video_viewer_wmp.playState == WMPLib.WMPPlayState.wmppsTransitioning)
                {
                    playPause_Button.Image = synchronizo.Properties.Resources.pause;
                }
                else if (video_viewer_wmp.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    playPause_Button.Image = synchronizo.Properties.Resources.play;
                }
                else
                {
                    playPause_Button.Image = synchronizo.Properties.Resources.playpause;
                }
            }
        }
        
        private void audio_timer_Tick(object sender, EventArgs e)
        {
            if (input_comboBox.SelectedItem != null)
            {
                input_progressBar.Value = (int)amplitudeMic;
            }
            if (output_comboBox.SelectedItem != null)
            {
                var output_device = (MMDevice)output_comboBox.SelectedItem;
                output_progressBar.Value = (int)(output_device.AudioMeterInformation.MasterPeakValue * 100);
            }
            

        }

        private void peaksSum_timer_Tick(object sender, EventArgs e)
        {
            //peaksSum max = 100
            //peaksSum min = 0
            Console.WriteLine(amplitudeMic);
            if (modeSelector_comboBox.SelectedIndex == 0) //noisy is faster
            {
                if (amplitudeMic >= 75)
                {
                    video_viewer_wmp.settings.rate = 2;
                }
                else if (amplitudeMic < 75 && amplitudeMic >= 25)
                {
                    video_viewer_wmp.settings.rate = 1;
                }
                else if (amplitudeMic < 25)
                {
                    video_viewer_wmp.settings.rate = 0.5;
                }
            }
            else if (modeSelector_comboBox.SelectedIndex == 1) //noisy is slower
            {
                if (amplitudeMic >= 75)
                {
                    video_viewer_wmp.settings.rate = 0.5;
                }
                else if (amplitudeMic < 75 && amplitudeMic >= 25)
                {
                    video_viewer_wmp.settings.rate = 1;
                }
                else if (amplitudeMic < 25)
                {
                    video_viewer_wmp.settings.rate = 2;
                }
            }
            else
            {
                video_viewer_wmp.settings.rate = 1;
            }

            //Console.Write("Peaksum: ");
            //Console.WriteLine(peaksSum);
            //Console.Write(video_viewer_wmp.settings.rate);
            //Console.WriteLine("X");
            
            molt_richTextBox.Text = $"{video_viewer_wmp.settings.rate} X";
            molt_richTextBox.SelectAll();
            molt_richTextBox.SelectionAlignment = HorizontalAlignment.Center;
            molt_richTextBox.DeselectAll();
            //Console.WriteLine(video_viewer_wmp.playState);

            peaksSum = 0;
            modeUpdate_progressBar.Value = 0;
        }

        private void modeSelectorUpdater_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                modeUpdate_progressBar.Value += 10;
            }
            catch (Exception)
            {
                Console.WriteLine("modeUpdate_progressBar.Value += 1; failed");
                Console.WriteLine(modeUpdate_progressBar.Value);
                modeUpdate_progressBar.Value = 100;
            }
        }

        private void playPause_Button_Click(object sender, EventArgs e)
        {
            if (video_viewer_wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                playPause_Button.Image = synchronizo.Properties.Resources.play;
                video_viewer_wmp.Ctlcontrols.pause();
            }
            else if (video_viewer_wmp.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                playPause_Button.Image = synchronizo.Properties.Resources.pause;
                video_viewer_wmp.Ctlcontrols.play();
            }
            else
            {
                playPause_Button.Image = synchronizo.Properties.Resources.playpause;
                video_viewer_wmp.Ctlcontrols.play();
            }
        }

        private void volume_button_Click(object sender, EventArgs e)
        {
            Console.Write("volume_button_Click");
            if (video_viewer_wmp.settings.volume != 0)
            {
                Console.WriteLine(", saving previous volume value, volume = 0, updating volume trackbar");
                prevVolume = video_viewer_wmp.settings.volume;
                video_viewer_wmp.settings.volume = 0;
                volume_trackBar.Value = 0;
                volume_button.Image = synchronizo.Properties.Resources.volume_off;
            }
            else
            {
                Console.WriteLine(", volume = prevValue");
                video_viewer_wmp.settings.volume = prevVolume;
                volume_trackBar.Value = prevVolume;
                volume_button.Image = synchronizo.Properties.Resources.speaker;
            }
        }

        private void volume_button_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine("volume_button_MouseHover");
            volume_trackBar.Visible = true;
        }
        private void volume_zone_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("volume_zone_Leave");
            volumeTrackBar_timer.Start();
        }

        private void volume_trackBar_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine("volume_trackBar_MouseHover");
            volumeTrackBar_timer.Stop();
        }

        private void volumeTrackBar_timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("volumeTrackBar_timer_Tick, hiding volume trackbar and stopping timer");
            volumeTrackBar_timer.Stop();
            volume_trackBar.Visible = false;
        }

        private void volume_trackBar_Scroll(object sender, EventArgs e)
        {
            Console.WriteLine("User changing volume trackbar value, updating wmp volume");
            video_viewer_wmp.settings.volume = volume_trackBar.Value;
        }

        
    }
}
