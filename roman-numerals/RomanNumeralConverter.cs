using System;
using System.Collections.Generic;
using System.Linq;

namespace roman_numerals
{
    internal class RomanNumeralConverter
    {

        Dictionary<int, string> specialNumbers = new Dictionary<int, string>()
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

        List<int> keys;

        public RomanNumeralConverter()
        {
            keys = specialNumbers.Keys.ToList();
            keys.Sort();
            keys.Reverse();
        }


        internal string Convert(int number)
        {
            string roman = "";
            
            foreach(int key in keys)
            {
                while (number >= key)
                {
                    roman += specialNumbers[key];
                    number -= key;
                }
            }
            
            return roman;
        }

        private string Repeat(char ch, int count)
        {
            return new string(ch, count);
        }

        internal int Convert(string roman)
        {
            int number = 0;

            for(int i = 0; i < roman.Length; i++)
            {
                if (i+1 < roman.Length && roman[i] == 'I' && roman[i+1] == 'V')
                {
                    number += 4;
                    i++;
                }
                else if (roman[i] == 'I')
                {
                    number++;
                }
            }

            return number;
        }
    }
}