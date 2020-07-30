using Power.Countdown;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Power
{
    public class Program
    {
        // This was a little clever....
        private IEnumerable<string> args;

        static void Main(string[] args)
        {            
            Console.WriteLine("Hello!!! Welcome to Power.Countdown");

            // Console.WriteLine($"Hey, did you just say '{args.ElementAtOrDefault(0)}'?");


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

            // int timeleft = ((hours * 3600) + (minutes * 60) + seconds); <= Really clever...

            Console.WriteLine($"Hello there. I'll be counting down to {hours}:{minutes}:{seconds} ");

            // var countdown = new PowerCountdown(timeleft);

            var countdown = new PowerCountdown(hours, minutes, seconds); // <= Check this out, though...

            countdown.Start();

            // ProcessArgs(string[], args);
        }

        /*
        void ProcessArgs()
        {
            foreach (string argument in args)
            {
                Console.WriteLine(argument);
            }
        }
        */

        static bool ProcessArguments(string[] args)
        {
            if (args.Length <= 0)
                return true;
            
            // if (args.Contains("-s"))
            // var countdown = new PowerCountdown(hours, minutes, seconds); // Call the countdown from here...maybe
            // countdown.Start()
            // else
            {
                DisplayUsageInstructions();
                return false;
            }
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

