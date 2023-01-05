using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ReaderApplication
{
    public class TextReader
    {
        SpeechSynthesizer synth;
        public TextReader()
        {
            synth = new SpeechSynthesizer();
        }
        public void ReadText()
        {
            TextGetter textGetter = new TextGetter();
            synth.SpeakAsync(textGetter.GetText());
        }

        public void CancelReading() 
        {
            synth.SpeakAsyncCancelAll();
        }

        public void SetReadingSpeed(int speed) 
        {
            synth.Rate = SelectSpeed(speed);
        }
        private int SelectSpeed(int speed) 
        {
            int result = 0;

            switch (speed)
            {
                case 10:
                    result = 10;
                    break;
                case 9:
                    result = 8;
                    break;
                case 8:
                    result = 6;
                    break;
                case 7:
                    result = 4;
                    break;
                case 6:
                    result = 2;
                    break;
                case 5:
                    result = 0;
                    break;
                case 4:
                    result = -2;
                    break;
                case 3:
                    result = -4;
                    break;
                case 2:
                    result = -6;
                    break;
                case 1:
                    result = -8;
                    break;
            }
            return result;
        }

        public void VoiceSetter()
        {

        }
    }
}
