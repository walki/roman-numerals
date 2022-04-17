using System;
using System.Collections.Generic;
using System.Linq;

namespace roman_numerals
{
    internal class RomanNumeralConverter
    {

        Dictionary<int, string> numToRoman = new Dictionary<int, string>()
        {
            { 1, "I" },
            { 4, "IV" },
            { 5, "V" },
            { 9, "IX" },
            { 10, "X" },
            { 40, "XL" },
            { 50, "L" },
            { 90, "XC" },
            { 100, "C" },
            { 400, "CD" },
            { 500, "D" },
            { 900, "DM" },
            { 1000, "M" },
        };


        Dictionary<string, int> romanToNum = new Dictionary<string, int>()
        {
            { "I",  1 },
            { "IV", 4 },
            { "V",  5 },
            { "IX", 9 },
            { "X",  10 },
            { "XL", 40 },
            { "L",  50 },
            { "XC", 90 },
            { "C",  100 },
            { "CD", 400 },
            { "D",  500 },
            { "DM", 900 },
            { "M",  1000 },
        };

        List<int> keys;

        List<char> validChars = new List<char>() { 'I','V','X','L','C','D','M' };
        List<char> validRepeatChars = new List<char>() { 'I', 'X', 'C', 'M' };

        public RomanNumeralConverter()
        {
            keys = numToRoman.Keys.ToList();
            keys.Sort();
            keys.Reverse();
        }


        internal string Convert(int number)
        {
            string roman = "";

            foreach (int key in keys)
            {
                while (number >= key)
                {
                    roman += numToRoman[key];
                    number -= key;
                }
            }

            return roman;
        }


        internal int Convert(string roman)
        {
            int number = 0;

            while (roman.Length > 0)
            {
                if (IsLeftSubtractingDigit(roman))
                {
                    number += romanToNum[roman.Substring(0, 2)];
                    roman = roman.Substring(2);
                }
                else
                {
                    number += romanToNum[roman.Substring(0, 1)];
                    roman = roman.Substring(1);
                }
            }
            return number;
        }

        private bool IsLeftSubtractingDigit(string roman)
        {
            return roman.Length > 1 && romanToNum.Keys.Contains(roman.Substring(0, 2));
        }

        internal bool Validate(string roman)
        {
            return IsOnlyValidChars(roman) && AreRepeatingCharsValid(roman);
        }

        private bool IsOnlyValidChars(string roman)
        {
            return roman.Where(c => !validChars.Contains(c)).Count() == 0;
        }

        private bool AreRepeatingCharsValid(string roman)
        {
            bool valid = true;
            char last = '\0';
            int repeat = 1;

            foreach (var digit in roman)
            {
                if (digit == last)
                {
                    repeat++;
                    last = digit;
                }
                else
                {
                    repeat = 1;
                    last = digit;
                }

                if (IsInvalidRepeat(repeat, digit))
                {
                    valid = false;
                }
            }

            return valid;
        }

        private bool IsInvalidRepeat(int repeat, char digit)
        {

            return (repeat > 1 && !validRepeatChars.Contains(digit)) 
                || repeat > 3;
        }
    }
}