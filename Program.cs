using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Configuration;

namespace _2015
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            To run an excercise, create a new object instance of the excercise class, and run the objects .Run() method

            For example, to run Day One's solution:

            var DayOneSolution = new Day1();
            DayOneSolution.Run();

            */

            // Day 5
            /*
            int niceWordCounter = 0;
            string data = "C:/Repos/excercises/Advent of Code/data/2015/05.txt";
            var NiceChecker = new Day5();
            
            foreach (string line in File.ReadLines(data))
            {
                bool isNice = NiceChecker.IsNicePartOne(line);
                if (isNice)
                {
                    niceWordCounter++;
                }
            }
            Console.WriteLine($"Total number of nice words: {niceWordCounter}");
            */
            string stringToCheck = "abcdefeghi";

            Regex twoCharsCheck = new Regex(@"(\w)\1(\w)");
            bool twoCharsInARowOccurs = twoCharsCheck.IsMatch(stringToCheck);
            Console.WriteLine($"Sandwiched: {twoCharsInARowOccurs}");

        }
    }
}
