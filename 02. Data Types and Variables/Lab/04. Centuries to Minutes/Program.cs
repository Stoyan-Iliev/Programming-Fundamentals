﻿using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            long days = (long)(years * 365.2422);
            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
