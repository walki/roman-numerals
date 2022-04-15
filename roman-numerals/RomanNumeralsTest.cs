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
        public void OneReturnsI()
        {
            string one = converter.Convert(1);
            Assert.That(one, Is.EqualTo("I"));
        }

        [Test]
        public void TwoReturnsII()
        {
            string two = converter.Convert(2);
            Assert.That(two, Is.EqualTo("II"));
        }

        [Test]
        public void ThreeReturnsIII()
        {
            string three = converter.Convert(3);
            Assert.That(three, Is.EqualTo("III"));
        }

        [Test]
        public void FourReturnsIV()
        {
            string four = converter.Convert(4);
            Assert.That(four, Is.EqualTo("IV"));
        }

        [Test]
        public void FiveReturnsV()
        {
            string five = converter.Convert(5);
            Assert.That(five, Is.EqualTo("V"));
        }

        [Test]
        public void SixReturnsVI()
        {
            string six = converter.Convert(6);
            Assert.That(six, Is.EqualTo("VI"));
        }
    }
}
