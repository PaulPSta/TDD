using NUnit.Framework;

namespace Converter.Tests
{
    public class ConverterTests
    {
        [TestCase("I", 1)]
        [TestCase("V", 5)]
        [TestCase("X", 10)]
        [TestCase("L", 50)]
        [TestCase("C", 100)]
        [TestCase("D", 500)]
        [TestCase("M", 1000)]
        public void Convert_ConvertSingleNumeral_WhenInputIsValid(string numeral, int expected)
        {
            // arrange
            var converter = new Converter();

            // act
            var result = converter.Convert(numeral);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("IV", 4)]
        [TestCase("XC", 90)]
        [TestCase("CD", 400)]
        [TestCase("MCM", 1900)]
        public void Convert_ConvertComplexNumeral_WhenInputIsValid(string numeral, int expected)
        {
            // arrange
            var converter = new Converter();

            // act
            var result = converter.Convert(numeral);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}