using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextToSpeak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        SpeechSynthesizer speechSynthesizerObj;
        private void Form1_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            richTextBox1.Text = "merhaba ben ali can";
            btnOku.Enabled = true;
            btnDevam.Enabled = true;
            btnDurdur.Enabled = true;
        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            speechSynthesizerObj.Dispose();
            if (richTextBox1.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                              
                speechSynthesizerObj.SpeakAsync(richTextBox1.Text);
                btnDuraklat.Enabled = true;
                btnDurdur.Enabled = true;
            }
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                  
                if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                {
                    
                    speechSynthesizerObj.Pause();
                    btnDevam.Enabled = true;
                    btnOku.Enabled = false;
                }
            }
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            {
                if (speechSynthesizerObj.State == SynthesizerState.Paused)
                {
   
                    speechSynthesizerObj.Resume();
                    btnDevam.Enabled = false;
                    btnOku.Enabled = true;
                }

            }
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
               
                speechSynthesizerObj.Dispose();
                btnOku.Enabled = true;
                btnDevam.Enabled = false;
                btnDuraklat.Enabled = false;
                btnDurdur.Enabled = false;
            }
        }
    }
}