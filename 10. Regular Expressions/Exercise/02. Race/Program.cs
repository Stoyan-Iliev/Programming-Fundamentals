﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main()
        {
            var nameValidator = new Regex("[A-Za-z]");
            var digitValidator = new Regex("[0-9]");

            var participants = Console.ReadLine()
                .Split(", ");

            var result = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while(!input.Equals("end of race"))
            {
                var match = nameValidator.Match(input);

                if (match.Success)
                {
                    var name = match.Value;

                    match = digitValidator.Match(input);

                    if (match.Success)
                    {
                        var distanceString = match.Value;

                        int distance = 0;

                        foreach (var digit in distanceString)
                        {
                            distance += int.Parse(digit.ToString());
                        }

                        if (participants.Contains(name))
                        {
                            if (!result.ContainsKey(name))
                            {
                                result.Add(name, distance);
                            }
                            else
                            {
                                result[name] += distance;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            // to fix the line below
            result = result.OrderByDescending(x => x.Value).ToDictionary<string, int>();


        }
    }
}
