using System;
using System.Threading;

namespace Power.Countdown
{

    public class PowerCountdown
    {
        #region Properties

        #region Statics

        public int SECONDS_PER_MINUTE = 60;
        //public int MINUTES_PER_HOUR = 60;
        //const int HOURS_PER_DAY = ?? <= Is this necessary

        #endregion

        #region Public Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public int CountdownTime { get; set; }

        #endregion

        #region Constructors
        public PowerCountdown(int seconds)
        {
            CountdownTime = seconds;

            //Convert the countdown time from seconds to hours:minute:seconds
            Hours = CountdownTime / 3600;
            Minutes = (CountdownTime - (Hours * 3600)) / 60; 
            Seconds = CountdownTime - ((Hours * 3600) + (Minutes * 60)) ;
        }

        #endregion

        #region Methods
        public void Start()
        {
            while (CountdownTime > 0)
            {
                Thread.Sleep(1); 
                CountdownTime--;

                if (CountdownTime > 86400)
                {
                    Console.WriteLine("Time choosen is out of bound");
                    break;
                }

                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                    break;

                if (Hours <= 24 && Minutes == 0 && Seconds == 0)
                {
                    Hours -= 1;
                    Minutes = 60;
                }
                
                if (Hours <= 1 && Minutes == 0 && Seconds == 0)
                {
                    Minutes = 60;
                    Hours = 0;
                    {
                        if (Hours <= 24 && Seconds <= 60)
                        {
                            Minutes = 60;
                        }
                    }
                }

                if (Minutes <= 60)
                {
                    if (Seconds == 0 && Minutes >= 1)
                    {
                        Minutes -= 1;
                        Seconds = 60;
                    }
                }

                if (Seconds == 0)Seconds = 60;
                Seconds--;

                
                string DoubleNumber(int number)          //This doesn't seem to work 
                {                                        //This doesn't seem to work 
                    if (Hours <= 9) return "0" + number; //This doesn't seem to work 
                    return number;                       //This doesn't seem to work 
                }                                        //This doesn't seem to work 

                //Console.WriteLine("DoubleNumber(Seconds)");


                //$"Integer padded to two places: {x:D2}
                Console.WriteLine($"{Hours:D2}:{Minutes:D2}:{Seconds:D2}");

            }
            Console.WriteLine("Time is up!!!");
            // Process.Start("shutdown", "/s /f /t 20");
        }
        #endregion

        #endregion

    }
}
