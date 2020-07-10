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
                Thread.Sleep(1000); // Wait for 1000 milliseconds. For test purposes you can decrease the value from 1000 to something much faster. Say 200
                CountdownTime--;

                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                    break;

                // Changed 'while' to 'if'
                // 'while' is continous running code. If the minutes was greater than one, 
                // your app will likely keep deducting the hours forever.

                /*
                 * Old code
                while (Minutes < 0)
                {
                    Hours -= 1;
                }
                */

                /*New Code*/
                if (Minutes < 0)
                {
                    Hours -= 1;
                }

                if (Seconds == 0)
                {
                    Minutes -= 1;
                    Seconds = 59; // <= The secret sauce... \-(0_0)-/
                }
                else
                {
                    Seconds--;
                }


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
