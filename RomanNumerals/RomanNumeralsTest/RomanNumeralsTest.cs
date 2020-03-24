namespace RomanNumeralsTest
{
    using System;
    using FluentAssertions;
    using RomanNumerals;
    using Xunit;

    public class RomanNumeralsTest
    {
        [Fact]
        public void FromInteger_Zero_ShouldGenerate_Exception() // Or we can throw exception
        {
            Action action = () => RomanNumeralsConverter.FromInteger(0);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void FromInteger_One_ShouldReturn_I()
        {
            string result = RomanNumeralsConverter.FromInteger(1);
            result.Should().Be("I");
        }

        [Fact]
        public void FromInteger_Two_ShouldReturn_II()
        {
            string result = RomanNumeralsConverter.FromInteger(2);
            result.Should().Be("II");
        }

        // Basic Cases
        [InlineData(3, "III")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        [InlineData(1000, "M")]
        // Special Cases
        [InlineData(4, "IV")]
        [InlineData(9, "IX")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        // Further Test Cases
        [InlineData(25, "XXV")]
        [InlineData(49, "XLIX")]
        [InlineData(93, "XCIII")]
        [InlineData(94, "XCIV")]
        [InlineData(99, "XCIX")]
        [InlineData(999, "CMXCIX")]
        [InlineData(1954, "MCMLIV")]
        [InlineData(1990, "MCMXC")]
        [InlineData(2014, "MMXIV")]
        [InlineData(3999, "MMMCMXCIX")]
        [Theory]
        public void FromInteger_Number_ShouldReturn_RomanNumerals(int valueToConvert, string expected)
        {
            string actual = RomanNumeralsConverter.FromInteger(valueToConvert);
            actual.Should().Be(expected);
        }

        [InlineData(4000)]
        [InlineData(4001)]
        [InlineData(5000)]
        [InlineData(6001)]
        [InlineData(10001)]
        [Theory]
        public void FromInteger_Number4000andAbove_ShouldReturn_EmptyString(int valueToConvert) // Or we can throw exception
        {
            Action action = () => RomanNumeralsConverter.FromInteger(valueToConvert);

            action.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}
