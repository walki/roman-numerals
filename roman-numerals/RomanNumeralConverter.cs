using System;

namespace roman_numerals
{
    internal class RomanNumeralConverter
    {
        public RomanNumeralConverter()
        {
        }

        internal string Convert(int number)
        {
            string roman = "";
            for (int i = 0; i < number; i++)
            {
                roman += "I";
            }
            return roman;
        }
    }
}