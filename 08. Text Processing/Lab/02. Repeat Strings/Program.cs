﻿using System;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ');

            var result = new StringBuilder();

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                }
            }

            Console.WriteLine(result);
        }
    }
}
