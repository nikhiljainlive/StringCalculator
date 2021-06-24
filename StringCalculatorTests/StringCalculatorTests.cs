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
    }
}