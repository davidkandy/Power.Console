using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Power.Countdown
{

    public class PowerCountdown
    {
        #region Properties

        #region Statics

        const int SECONDS_PER_MINUTE = 60;
        const int MINUTES_PER_HOUR = 60;
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
            Minutes = Hours * MINUTES_PER_HOUR;
            Hours = Seconds / 3600;

        }

        #endregion

        #region Methods
        public void Start()
        {
            while (CountdownTime > 0)
            {
                Thread.Sleep(1000); // Wait for 1000 milliseconds
                CountdownTime--;

                if (Seconds > 0)
                {
                    if (Minutes > 0) Minutes--;
                    else if (Hours > 0)
                    {
                        Minutes = 59;
                        Hours--;
                    }
                }
                else Seconds--;

                Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
            }

            Console.WriteLine("Time is up!!!");
            // Process.Start("shutdown", "/s /f /t 20");
        }
        #endregion
    }


}
