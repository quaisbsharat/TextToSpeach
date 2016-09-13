﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.IO;

namespace TextToSpeach
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer voice;
        public Form1()
        {

            InitializeComponent();
            voice = new SpeechSynthesizer();
        }

     

        private void txtPause_Click(object sender, EventArgs e)
        {
            try
            {
                voice.Pause();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtResume_Click(object sender, EventArgs e)
        {
            try
            {
                voice.Resume();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                using(SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "WAV files|*.wav";
                    sfd.Title = "Save to wave file";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {

                        FileStream fs =new FileStream(sfd.FileName,
                            FileMode.Create,
                            FileAccess.Write);

                        voice.SetOutputToWaveStream(fs);
                        voice.Speak(txtContent.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void txtSpeak_Click(object sender, EventArgs e)
        {
            try { 
            switch (cboSelectVoice.SelectedIndex)
            {
                case 0:
                    voice.SelectVoiceByHints(VoiceGender.NotSet);
                    break;

                case 1:
                    voice.SelectVoiceByHints(VoiceGender.Male);
                    break;

                case 2:
                    voice.SelectVoiceByHints(VoiceGender.Female);
                    break;

                case 3:
                    voice.SelectVoiceByHints(VoiceGender.Neutral);
                    break;

                default:
                    break;
            }
                voice.SpeakAsync(txtContent.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

        }
    }
}
