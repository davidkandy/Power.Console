using System;
using System.Diagnostics;
using System.Threading;
using System.Media;
using NAudio.Wave;

namespace Power.Countdown
{

    public class PowerCountdown
    {
        #region Public Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public int CountdownTime { get; private set; }

        #endregion

        #region Constructors

        public PowerCountdown(int timeleft)
        {
            CountdownTime = timeleft;

            //Convert the countdown time from seconds to hours:minute:seconds

            Hours = CountdownTime / 3600;
            Minutes = (CountdownTime - (Hours * 3600)) / 60;
            Seconds = CountdownTime - (Hours * 3600) - (Minutes * 60);
        }

        public PowerCountdown(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        #endregion

        #region Methods
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(10);

                /*
                 * Don't limit your apps unless it is really necessary.
                 * Imagine if gmail clients were unable to send mails to other mail services like hotmail or zoho.
                 * That's an unnecessary limitation, don't you think?
                if (CountdownTime > 86400)
                {
                    Console.WriteLine("Time choosen is out of bound");
                    break;
                }
                */

                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                    break;

                if (Hours > 0 && Minutes == 0 && Seconds == 0)
                {
                    Hours -= 1;
                    Minutes = 60;
                }

                if (Hours <= 1 && Minutes == 0 && Seconds == 0)
                {
                    Minutes = 60;
                    Hours = 0;
                }

                if (Minutes <= 60)
                {
                    if (Seconds == 0 && Minutes >= 1)
                    {
                        Minutes -= 1;
                        Seconds = 60;
                    }
                }

                if (Seconds == 0) Seconds = 60;
                Seconds--;

                //You can't create a function within a function.

                //$"Integer padded to two places: {x:D2}
                // Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}"); <= Clever, we'll be using this in the main app.

                // Cute APIs like string.Format() may not always be available.
                // Imagine if you were writing CMD code. What would you do??
                // Programmers should know how to improvise when necessary.

                string hours = DoubleNumber(Hours),
                    minutes = DoubleNumber(Minutes),
                    seconds = DoubleNumber(Seconds);

                Console.WriteLine($"{hours}:{minutes}:{seconds}");

            }
            Console.WriteLine("Time is up!!!");

            // SoundPlayer player = new SoundPlayer(Properties.Resources.ringin);
            // player.PlaySync();
            // player.PlaySync();

            Audio();
            Audio();
            Audio();

            // Process.Start("shutdown", "/s /f /t 20");
        }
            string DoubleNumber(int number)
            {
                if (number <= 9) return "0" + number;
                return number.ToString();
            }
            void Audio()
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.ringin);
                // new SoundPlayer(@"C:/Users/David/source/repos/Power.Console/Music/ringin.wav");
                audio.PlaySync();
            }
        #endregion
    }

}

