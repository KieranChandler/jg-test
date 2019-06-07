using JG.FinTechTest.GiftAid;
using NUnit.Framework;

namespace Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Theory]
        [TestCase(100, 20)]
        [TestCase(80, 16)]
        public void ShouldReturn20Percent(decimal principalAmount, decimal expectedGiftAid)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var giftAid = calculator.CalculateGiftAid(principalAmount);

            // Assert
            Assert.AreEqual(expectedGiftAid, giftAid);
        }
    }
}