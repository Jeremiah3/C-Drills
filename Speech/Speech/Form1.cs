using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace Speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer _Ruby = new SpeechSynthesizer();
        SpeechRecognizer _Recognize = new SpeechRecognizer();
        private void Form1_Load(object sender, EventArgs e)
        {
            _Recognize.SpeechRecognized += _Recognize_SpeechRecognized;
        }

        private void _Recognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            richTextBox1.AppendText(e.Result.Text.ToString() + " ");
        }

    }
}
