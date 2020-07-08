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
        // const int HOURS_PER_DAY = ?? <= Is this necessary

        #endregion

        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public int CountdownTime { get; set; }

        #endregion

        #region Constructors
        public PowerCountdown(int seconds)
        {
            CountdownTime = seconds;

            // Convert the countdown time from seconds to hours:minute:seconds

            Seconds = CountdownTime % SECONDS_PER_MINUTE;
            Minutes = (CountdownTime - (Hours * 3600)) / 60; //Convert both hours and minutes to an integer that doesn't have decimal points 
            Hours = CountdownTime / 3600; //Convert both hours and minutes to an integer that doesn't have decimal points 

        }

        #endregion

        #region Methods
        public void Start()
        {
            while (CountdownTime > 0)
            {
                Thread.Sleep(1000); // Wait for 1000 milliseconds
                CountdownTime--;

                //if (Seconds == 0) Minutes -= 1;
                //Seconds--;

                if (Minutes == 0) Hours -= 1;
                {
                    while (Seconds <= 0) Minutes -= 1;
                    {
                        if (Seconds == 0) Minutes -= 1;
                        Seconds--;
                        Empty -= 1;
                    }
                }



                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                    break;

                //{ 
                //    while (Minutes < 0) Hours -= 1;

                //    else Seconds--;
                //}



                Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
            }

            Console.WriteLine("Time is up!!!");
            // Process.Start("shutdown", "/s /f /t 20");
        }
        #endregion


    }
}
