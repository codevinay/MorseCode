using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace MorseCode
{
    class Program
    {
        //A dash is equal to three dots.
        //The space between parts of the same letter is equal to one dot.
        //The space between two letters is equal to three dots.
        //The space between two words is equal to seven dots.

        public static int Dot = 100;
        public static int Dash = Dot * 3;
        public static int Sleep = Dot * 3;
        public static int WordsSpace = Dot * 7;
        public static int Frequency = 700;
        SoundPlayer Sound = new SoundPlayer("sound.wav");   
        static void Main(string[] args)
        {
            Console.WriteLine("@Application Name : Morse Code Translator");
            Console.WriteLine("@Version : 1.0.2");
            Console.WriteLine("@Author : Vinay Shah");
            Console.WriteLine("@Created : 14/05/2012");
            Console.WriteLine("@Description : Translates and plays input pharse to Morse Code");
            Console.WriteLine("==============================================================");
            Console.WriteLine(" ");                    
            while (true)
            {
                Program P = new Program();
                P.ConvertCode();
            }
        }

        public void ConvertCode()
        {
            Console.WriteLine("Enter phrase you want to convert and play to morse code");
            string Phrase = Convert.ToString(Console.ReadLine());
            Phrase = Phrase.ToUpper();

            foreach (char s in Phrase)
            {
                switch (s)
                {
                    case 'A':
                        Sound.Play();
                        //Console.Beep(Frequency, Dot);
                        //Console.Beep(Frequency, Dash);
                        break;
                    case 'B':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'C':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'D':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'E':
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'F':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'G':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'H':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'I':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'J':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'K':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'L':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'M':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'N':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'O':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'P':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'Q':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'R':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'S':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case 'T':
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'U':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'V':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'W':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'X':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'Y':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case 'Z':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;


                    case '0':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case '1':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case '2':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case '3':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        break;
                    case '4':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dash);
                        break;
                    case '5':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case '6':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case '7':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case '8':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                    case '9':
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dash);
                        Console.Beep(Frequency, Dot);
                        break;

                    case ' ':
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        Console.Beep(Frequency, Dot);
                        break;
                }

                System.Threading.Thread.Sleep(Sleep);
            }
        }
    }
}
