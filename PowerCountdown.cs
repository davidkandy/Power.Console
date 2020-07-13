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
<<<<<<< HEAD
                Thread.Sleep(10); // Wait for 1000 milliseconds. For test purposes you can decrease the value from 1000 to something much faster. Say 200
=======
                Thread.Sleep(100); // Wait for 1000 milliseconds. For test purposes you can decrease the value from 1000 to something much faster. Say 200
>>>>>>> 99a03468a91f9506ab592b34faf1ba79b84682dd
                CountdownTime--;

                if (Hours == 0 && Minutes == 0 && Seconds == 0)
                    break;

                if (Hours <= 12 && Minutes == 0 && Seconds == 0)
                {
                    Hours -= 1;
                    Minutes = 60;
                }
                
                if (Hours <= 1 && Minutes == 0 && Seconds == 0)
                {
                    Minutes = 60;
                    Hours = 0;
                    {
                        if (Hours <= 12 && Seconds <= 60)
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

                Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");

<<<<<<< HEAD
                //Getting the Time format right

                //if (Hours >= 10 && Minutes <= 9 && Seconds <= 9)
                //{
                //    Console.WriteLine($"{Hours}:{0:0}{Minutes}:{0:0}{Seconds}");
                //}
                //
                //if (Hours <= 9 && Minutes >= 10 && Seconds <= 9)
                //{
                //    Console.WriteLine($"{0:0}{Hours}:{Minutes}:{0:0}{Seconds}");
                //}
                //
                //if (Hours <= 9 && Minutes <= 9 && Seconds >= 10)
                //{
                //    Console.WriteLine($"{0:0}{Hours}:{0:0}{Minutes}:{Seconds}");
                //}
                //
                //if (Hours <= 9 && Minutes >= 10 && Seconds >= 10)
                //{
                //    Console.WriteLine($"{0:0}{Hours}:{Minutes}:{Seconds}");
                //}
                //
                //if (Hours <= 9 && Minutes <= 9 && Seconds <= 9)
                //{
                //    Console.WriteLine($"{0:0}{Hours}:{0:0}{Minutes}:{0:0}{Seconds}");
                //}

                //if (Hours >= 10 && Minutes >= 10 && Seconds >= 10)
                //{
                //    Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
                //}

=======
                /*
                if (Hours <= 9 && Minutes <= 9 && Seconds <= 9)
                {
                    Console.WriteLine($"{0:0}{Hours}:{0:0}{Minutes}:{0:0}{Seconds}");
                }

                if (Hours <= 9 && Minutes <= 9 && Seconds >= 10)
                {
                    Console.WriteLine($"{0:0}{Hours}:{0:0}{Minutes}:{Seconds}");
                }

                if (Hours <= 9 && Minutes >= 10 && Seconds <= 9)
                {
                    Console.WriteLine($"{0:0}{Hours}:{Minutes}:{0:0}{Seconds}");
                }

                if (Hours <= 9 && Minutes >= 10 && Seconds >= 10)
                {
                    Console.WriteLine($"{0:0}{Hours}:{Minutes}:{Seconds}");
                }

                if (Hours >= 10 && Minutes <= 9 && Seconds <= 9)
                {
                    Console.WriteLine($"{Hours}:{0:0}{Minutes}:{0:0}{Seconds}");
                }
                
                if (Hours >= 10 && Minutes >= 10 && Seconds >= 10)
                {
                    Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
                }
                */
>>>>>>> 99a03468a91f9506ab592b34faf1ba79b84682dd

                Console.WriteLine($"{Hours}:{Minutes}:{Seconds}");
            }
            Console.WriteLine("Time is up!!!");
            // Process.Start("shutdown", "/s /f /t 20");
        }
        #endregion

        #endregion

    }
}
