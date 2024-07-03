using System;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using System.Speech;
using System.Speech.Synthesis;

namespace Neural_Activity_Monitoring_System
{
    public partial class Stimuli : Form
    {
        public Stimuli()
        {
            InitializeComponent();
        }


        SpeechSynthesizer voice = new SpeechSynthesizer();

        BlockAlignReductionStream stream;
        DirectSoundOut output;

        private void Stimuli_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Enter your text!!!";
        }

        private void ReTeFrFi_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text File (*.txt)|*.txt;";

            if (open.ShowDialog() != DialogResult.OK) return;

            StreamReader sr = new StreamReader(open.FileName);
            richTextBox1.Text = sr.ReadToEnd();
        }

        private void PlayText_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Male":
                    voice.SelectVoiceByHints(VoiceGender.Male);
                    break;
                case "Female":
                    voice.SelectVoiceByHints(VoiceGender.Female);
                    break;
            }


            voice.Volume = trackBar1.Value;
            voice.Rate = trackBar2.Value;


            voice.SpeakAsync(richTextBox1.Text);
        }

        private void Stimuli_FormClosing(object sender, FormClosingEventArgs e)
        {

            MainForm.formFlag = true;

            if (output != null)
            {
                if (output.PlaybackState == PlaybackState.Playing)
                    output.Stop();
                output.Dispose();
                output = null;

            }

            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
            voice.Pause();
        }

        private void resumeBtn_Click(object sender, EventArgs e)
        {
            voice.Resume();
        }

        private void saveWav_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "All files (*.*)|*.*|wav files (*.wav)|*.wav";
            sfd.Title = "Save to a wave file";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write);
                voice.SetOutputToWaveStream(fs);
                voice.Speak(richTextBox1.Text);
                fs.Close();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            voice.SpeakAsyncCancelAll();
        }

        private void loAuFi_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Audio File (*.mp3;*.wav)|*.mp3;*.wav;";
            if (open.ShowDialog() != DialogResult.OK) return;

            if (open.FileName.EndsWith(".mp3"))
            {
                WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(open.FileName));
                stream = new BlockAlignReductionStream(pcm);
            }
            else if (open.FileName.EndsWith(".wav"))
            {
                WaveStream pcm = new WaveChannel32(new WaveFileReader(open.FileName));
                stream = new BlockAlignReductionStream(pcm);
            }

            output = new DirectSoundOut();
            output.Init(stream);
        }

        private void plAu_Click(object sender, EventArgs e)
        {
            output.Play();
        }

        private void PaAu_Click(object sender, EventArgs e)
        {
            output.Pause();
        }



    }
}
