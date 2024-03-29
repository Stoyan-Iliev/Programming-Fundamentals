﻿using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
