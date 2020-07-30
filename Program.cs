using Power.Countdown;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Power
{
    public class Program
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
=======
        // This was a little clever....
        private IEnumerable<string> args;

        static void Main(string[] args)
        {            
>>>>>>> 502eff8fb90fe4011636f319cd0793544dca9c09
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
<<<<<<< HEAD
=======

>>>>>>> 502eff8fb90fe4011636f319cd0793544dca9c09
        static bool ProcessArguments(string[] args)
        {
            if (args.Length <= 0)
                return true;
<<<<<<< HEAD

            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];
                if (arg == "-s")
                {
                    string number = args[i + 1];
                    int.TryParse(number, out int seconds);
                    var countdown = new PowerCountdown(seconds);
                    countdown.Start();
                }
            }

            // if (args.Contains("-s"))
            //var countdown = new PowerCountdown(seconds); // Call the countdown from here...maybe
            //countdown.Start();
=======
            
            // if (args.Contains("-s"))
            // var countdown = new PowerCountdown(hours, minutes, seconds); // Call the countdown from here...maybe
            // countdown.Start()
>>>>>>> 502eff8fb90fe4011636f319cd0793544dca9c09
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

