using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumerals;

namespace RomanNumeralsTest
{
    [TestFixture]
    public class RomanNumeralsTest
    {
        [Test]
        public void FromInteger_Zero_ShouldGenerate_Exception() // Or we can throw exception
        {
            Assert.That(() => RomanNumeralsConverter.FromInteger(0),
                        Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void FromInteger_One_ShouldReturn_I()
        {
            string result = RomanNumeralsConverter.FromInteger(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        public void FromInteger_Two_ShouldReturn_II()
        {
            string result = RomanNumeralsConverter.FromInteger(2);
            Assert.AreEqual("II", result);
        }

        // Basic Cases
        [TestCase(3, "III")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        // Special Cases
        [TestCase(4, "IV")]
        [TestCase(9, "IX")]
        [TestCase(40, "XL")]
        [TestCase(90, "XC")]
        [TestCase(400, "CD")]
        [TestCase(900, "CM")]
        // Further Test Cases
        [TestCase(25, "XXV")]
        [TestCase(49, "XLIX")]
        [TestCase(93, "XCIII")]
        [TestCase(94, "XCIV")]
        [TestCase(99, "XCIX")]
        [TestCase(999, "CMXCIX")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2014, "MMXIV")]
        [TestCase(3999, "MMMCMXCIX")]
        [Test]
        public void FromInteger_Number_ShouldReturn_RomanNumerals(int valueToConvert, string expected)
        {
            string actual = RomanNumeralsConverter.FromInteger(valueToConvert);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4000)]
        [TestCase(4001)]
        [TestCase(5000)]
        [TestCase(6001)]
        [TestCase(10001)]
        [Test]
        public void FromInteger_Number4000andAbove_ShouldReturn_EmptyString(int valueToConvert) // Or we can throw exception
        {
            Assert.That(() => RomanNumeralsConverter.FromInteger(valueToConvert),
                        Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
