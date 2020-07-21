using System;
using System.Diagnostics;
using System.Threading;
namespace Power.Countdown
{

    public class PowerCountdown
    {
        #region Properties

        #region Statics

        //const int SECONDS_PER_MINUTE = 60;
        //const int MINUTES_PER_HOUR = 60;
        //const int HOURS_PER_SECOND = 3600;

        #endregion

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
            Hours = CountdownTime / 3600;                                    //Hours = CountdownTime / HOURS_PER_SECOND;
            Minutes = (CountdownTime - (Hours * 3600)) / 60;                 //Minutes = (CountdownTime - (Hours * HOURS_PER_SECOND)) / MINUTES_PER_HOUR;
            Seconds = CountdownTime - (Hours * 3600) - (Minutes * 60);       //Seconds = CountdownTime - ((Hours * HOURS_PER_SECOND) + (Minutes * MINUTES_PER_HOUR));
        }

        public PowerCountdown(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            CountdownTime = ((hours * 3600) + (minutes * 60) + seconds);
            // Mini Challenge. Remove CountdownTime from this class and still make everything work fine.
        }


        #endregion

        #region Methods
        public void Start()
        {
            while (CountdownTime > 0)
            {
                Thread.Sleep(10);
                CountdownTime--;

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

                /*
                 * Old Code => Removed the day limit
                if (Hours <= 24 && Minutes == 0 && Seconds == 0)
                {
                    Hours -= 1;
                    Minutes = 60;
                }
                */

                if (Hours > 0 && Minutes == 0 && Seconds == 0)
                {
                    Hours -= 1;
                    Minutes = 60;
                }

                if (Hours <= 1 && Minutes == 0 && Seconds == 0)
                {
                    Minutes = 60;
                    Hours = 0;
                    /*
                     * This doesn't look necessary...
                    {
                        if (Hours <= 24 && Seconds <= 60)
                        {
                            Minutes = 60;
                        }
                    }
                    */
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


                /*
                 * You can't create a function within a function.
                string DoubleNumber(int number)          
                {                                        
                    if (Hours <= 9) return "0" + number; 
                    return number;                       
                }                                        
                */

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
            Ringtone();
            // Process.Start("shutdown", "/s /f /t 20");
        }

        private static void Ringtone()
        {
            try
            {
                string path = @"Music\ringin.wav"; // Lol, no offense, but you have terrible taste in alarm sounds. Good taste in music, though... ο(-_-)o
                ProcessStartInfo startInfo = new ProcessStartInfo(path);
                startInfo.UseShellExecute = true; // <= Fix based on (https://stackoverflow.com/a/54763978/8058709). Error was due to the new .net core runtime

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
            }
        }

        private string DoubleNumber(int number)
        {
            if (number <= 9) return "0" + number;
            return number.ToString();
        }
    }
    #endregion

    #endregion

}

