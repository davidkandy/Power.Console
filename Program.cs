using Power.Countdown;
using System;

namespace Power
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello!!!");

            int hours = new Int32(); //random.Next(3600, 86400 * 10);
            int minutes = new Int32();
            int seconds = new Int32();

            Console.WriteLine($"Hello there. I'll be counting down to {hours} {minutes} {seconds} ");
            Console.WriteLine("");

            int timeleft = hours * 3600 + minutes * 60 + seconds;

            var countdown = new PowerCountdown(timeleft);
            countdown.Start();
        }
    }
}

