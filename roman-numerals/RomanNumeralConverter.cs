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
            if (number >= 5)
            {
                roman += "V";
                number -= 5;
            }
            else if (number >= 4)
            {
                roman += "IV";
                number -= 4;
            }

            roman += Repeat('I', number);

            return roman;
        }

        private string Repeat(char ch, int count)
        {
            return new string(ch, count);
        }
    }
}