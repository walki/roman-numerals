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
        [Test]
        public void Nothing()
        {
            RomanNumeralConverter converter = new RomanNumeralConverter();
            string one = converter.Convert(1);
            Assert.That(one, Is.EqualTo("I"));
        }


    }
}
