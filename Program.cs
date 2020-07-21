using Power.Countdown;
using System;

namespace Power
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!! Welcome to Power.Countdown");

            //int hours = new Int32(); //random.Next(3600, 86400 * 10);
            //int minutes = new Int32();
            //int seconds = new Int32();


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

            // var countdown = new PowerCountdown(timeleft);
            var countdown = new PowerCountdown(hours, minutes, seconds); // <= Check this out, though...
            countdown.Start();

            //Console.WriteLine($"Hello there. I'll be counting down to {hours}:{minutes}:{seconds} ");
            Console.WriteLine(""); //What's the purpose of this line 


        }
    }
}

