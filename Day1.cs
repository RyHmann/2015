using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015
{
    public class Day1
    {
        private string _instructions { get; set; }
        public int FinalLocation { get; set; }
        public int InitialPointOfEntry { get; set; }

        public Day1()
        {
            string data = "C:/Repos/excercises/Advent of Code/data/2015/01.txt";
            _instructions = File.ReadAllText(data).Trim();
        }

        public Day1(string instructions)
        {
            _instructions = instructions;
        }

        public int PartOne()
        {
            char goUp = '(';
            char goDown = ')';
            int totalUp = _instructions.Count(f => f == goUp);
            int totalDown = _instructions.Count(f => f == goDown);
            int finalLocation = totalUp - totalDown;
            return finalLocation;
        }

        public int PartTwo()
        {
            char goUp = '(';
            char goDown = ')';
            int currentLevel = 0;
            int currentIndex = 0;
            foreach (var item in _instructions)
            {
                currentIndex++;
                if (item == goUp)
                {
                    currentLevel++;
                }
                else if (item == goDown)
                {
                    currentLevel--;
                }
                if (currentLevel < 0)
                {
                    return currentIndex;
                }
            }
            return 0;
        }

        public void Run()
        {
            FinalLocation = PartOne();
            InitialPointOfEntry = PartTwo();
            Console.WriteLine($"Final location: {FinalLocation}.");
            Console.WriteLine($"Inital point of basement entry: {InitialPointOfEntry}.");
        }
    }
}
