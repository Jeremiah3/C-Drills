using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace SpeechTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
                SpeechSynthesizer jay = new SpeechSynthesizer();
                jay.Speak("Welcome to my City!");
                   //I'll be back.
        }
    }
}
