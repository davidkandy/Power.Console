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
        /// <summary>
        /// The method to Start counting down
        /// </summary>
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000);


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

                string hours = DoubleNumber(Hours),
                    minutes = DoubleNumber(Minutes),
                    seconds = DoubleNumber(Seconds);

                Console.WriteLine($"{hours}:{minutes}:{seconds}");

            }
            Console.WriteLine("Time is up!!!");

            Audio();
            Audio();
            Audio();

        }
        /// <summary>
        /// The method to make each property a double digit (e.g 00:00:00)
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
            string DoubleNumber(int number)
            {
                if (number <= 9) return "0" + number;
                return number.ToString();
            }
        /// <summary>
        /// Method for making sound
        /// </summary>
            void Audio()
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.ringin);
                audio.PlaySync();
            }
        #endregion
    }

}

