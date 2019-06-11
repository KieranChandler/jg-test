using System;
using JG.FinTechTest.GiftAid.Donations;
using NUnit.Framework;

namespace JG.FinTechTest.Tests
{
    public class PostCodeTests
    {
        [Theory]
        [TestCase("AB12CD")]
        [TestCase("AB1 2CD")]
        [TestCase("AB12 2CD")]
        public void CanCreatePostCode(string postCodeRaw)
        {
            // Arrange

            // Act
            TestDelegate act = () => { var postCode = new PostCode(postCodeRaw); };

            // Assert
            Assert.DoesNotThrow(act);
        }

        [Theory]
        [TestCase("AAB12CD")]
        [TestCase("AB1 222SCD")]
        [TestCase("AB12 2DCD")]
        public void GivenRawFormatIsInvalid_ShouldThrowFormatException(string postCodeRaw)
        {
            // Arrange

            // Act
            TestDelegate act = () => { var postCode = new PostCode(postCodeRaw); };

            // Assert
            Assert.Throws<FormatException>(act);
        }
    }
}