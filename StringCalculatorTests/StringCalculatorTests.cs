using NUnit.Framework;
using CodingKata;

namespace CodingKata
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [TestCase]
        public void Add_WhenPassedEmptyString_ReturnZero()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("");
            Assert.AreEqual(0, result);
        }

        [TestCase("1", 1)]
        [TestCase("2", 2)]
        public void Add_WhenPassedNumberAsString_ReturnThatNumber(string input, int output)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(input);
            Assert.AreEqual(output, result);
        }

        [TestCase("1,2", 3)]
        [TestCase("3,4", 7)]
        public void Add_WhenPassedTwoNumbersSeparatedByCommaAsString_ReturnSum(string input, int output)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(input);
            Assert.AreEqual(output, result);
        }

        [TestCase("1,2,3", 6)]
        [TestCase("1,2,3,4,5,6,7", 28)]
        public void Add_WhenPassedUnknownAmountOfNumbersSeparatedByCommaAsString_ReturnSum(string input, int output)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(input);
            Assert.AreEqual(output, result);
        }

        [TestCase("1,2\n3", 6)]
        [TestCase("1,2\n3,4,5\n6,7", 28)]
        public void Add_WhenPassedUnknownAmountOfNumbersSeparatedByCommaAndNewLineAsString_ReturnSum(string input, int output)
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add(input);
            Assert.AreEqual(output, result);
        }
    }
}