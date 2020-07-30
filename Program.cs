using Power.Countdown;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Power
{
    public class Program
    {
        /// <summary>
        /// The Main methhod to Input parameters for the timer (Hours:Minutes:Seconds)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            Console.WriteLine("Hello!!! Welcome to Power.Countdown");

            if (!ProcessArguments(args))
                return;


            Console.WriteLine("Set the timer below: ");
            Console.WriteLine("");

            Console.Write("Enter the Hours> ");
            string hoursAsAString = Console.ReadLine();
            int hours = Convert.ToInt32(hoursAsAString);

            Console.Write("Enter the Minutes> ");
            string minutesAsAString = Console.ReadLine();
            int minutes = Convert.ToInt32(minutesAsAString);

            Console.Write("Enter the Seconds> ");
            string secondsAsAString = Console.ReadLine();
            int seconds = Convert.ToInt32(secondsAsAString);

            Console.WriteLine($"Hello there. I'll be counting down to {hours}:{minutes}:{seconds} ");

            var countdown = new PowerCountdown(hours, minutes, seconds);

            countdown.Start();

        }

        /// <summary>
        /// Method to Process Arguments from the Console's terminal 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static bool ProcessArguments(string[] args)
        {
            if (args.Length <= 0)
                return true;

            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];
                if (arg == "-s")
                {
                    string number = args[i + 1];
                    int.TryParse(number, out int seconds);
                    var countdown = new PowerCountdown(seconds);
                    countdown.Start();

                    return false;
                }


            }

            DisplayUsageInstructions();
            return false;
        }

        static void DisplayUsageInstructions()
        {
            Console.WriteLine("Welcome to Power.Console");
            Console.WriteLine("USAGE: ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-s [CountdownSeconds]");
            Console.WriteLine("");
        }

    }
}

