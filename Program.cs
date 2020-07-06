using Power.Countdown;
using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Generate a random number each time
            Random random = new Random();
            int seconds = random.Next(0, 60);  // How does the 'seconds' know it's supposed to make 1minute when it has passed 60 seconds?

            Console.WriteLine($"Hello there. I'll be counting down to {seconds}");
            Console.WriteLine("");

            var countdown = new PowerCountdown(seconds);
            countdown.Start();
        }
    }
}

