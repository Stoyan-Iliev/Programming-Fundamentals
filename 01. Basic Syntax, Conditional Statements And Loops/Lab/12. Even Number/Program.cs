﻿using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: {0}", Math.Abs(num));
        }
    }
}