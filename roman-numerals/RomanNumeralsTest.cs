using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roman_numerals
{
    [TestFixture]
    class RomanNumeralsTest
    {
        private RomanNumeralConverter converter;

        [SetUp]
        public void SetUp()
        {
            converter = new RomanNumeralConverter();
        }

        [Test]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(9, "IX")]
        [TestCase(2022, "MMXXII")]
        [TestCase(54, "LIV")]
        [TestCase(498, "CDXCVIII")]
        public void ConvertReturnsRomanNumerals(int number, string expected)
        {
            string actual = converter.Convert(number);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [Test]
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("IX", 9)]
        [TestCase("MMXXXII", 2032)]
        [TestCase("LXXIV", 74)]
        [TestCase("CDXCVIII", 498)]
        public void ConvertRomanNumeralsToInts(string roman, int expected)
        {
            int actual = converter.Convert(roman);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("MDCLXVI", true, Description = "Valid characters")]
        [TestCase("G", false, Description = "Invalid charactiers")]
        [TestCase("III", true, Description = "I can be repeated up to three times")]
        [TestCase("IIII", false, Description = "I cannot be repeated four times")]
        [TestCase("LL", false,Description = "Only I, X, C, M can repeat")]
        public void ValidateRomanNumeral(string roman, bool expected)
        {
            bool actual = converter.Validate(roman);
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
