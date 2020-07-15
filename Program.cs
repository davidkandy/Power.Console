﻿using Power.Countdown;
using System;

namespace Power
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            // Generate a random number each time
            Random random = new Random();
            int seconds = 3600 * 2;//random.Next(3600, 86400 * 10);

            Console.WriteLine($"Hello there. I'll be counting down to {seconds} seconds");
            Console.WriteLine("");

            var countdown = new PowerCountdown(seconds);
            countdown.Start();
        }
    }
}

