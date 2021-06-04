using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2015
{
    public class Day5
    {
        private bool HasThreeVowels(string stringToCheck)
        {
            Regex vowelCheck = new Regex(@"(a)|(e)|(i)|(o)|(u)");
            MatchCollection vowelMatches = vowelCheck.Matches(stringToCheck);
            if (vowelMatches.Count > 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasNaughtyWords(string stringToCheck)
        {
            Regex naughtyStringCheck = new Regex(@"(ab)|(cd)|(pq)|(xy)");
            bool naughtyWordsPresent = naughtyStringCheck.IsMatch(stringToCheck);
            if (naughtyWordsPresent)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasTwoCharsInARow(string stringToCheck)
        {
            Regex twoCharsCheck = new Regex(@"(\w)\1");
            bool twoCharsInARowOccurs = twoCharsCheck.IsMatch(stringToCheck);
            if (twoCharsInARowOccurs)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool HasTwoPair(string stringToCheck)
        {
            // TODO: implement
            return true;
        }

        private bool HasSandwichedChar(string stringToCheck)
        {
            // TODO: implement
            return true;
        }

        public bool IsNicePartOne(string stringToCheck)
        {
            bool hasThreeVowels = HasThreeVowels(stringToCheck);
            bool hasNaughtyWords = HasNaughtyWords(stringToCheck);
            bool hasTwoCharsInARow = HasTwoCharsInARow(stringToCheck);
            if (hasThreeVowels == true & hasNaughtyWords == false & hasTwoCharsInARow == true){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNicePartTwo(string stringToCheck)
        {
            bool hasTwoPair = HasTwoPair(stringToCheck);
            bool hasSandwichedChar = HasSandwichedChar(stringToCheck);
            if (hasTwoPair == true & hasSandwichedChar == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
