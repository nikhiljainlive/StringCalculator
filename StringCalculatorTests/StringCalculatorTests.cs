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

        [TestCase]
        public void Add_WhenPassedOneAndTwoAsString_ReturnThree()
        {
            var stringCalculator = new StringCalculator();
            var result = stringCalculator.Add("1,2");
            Assert.AreEqual(3, result);
        }
    }
}