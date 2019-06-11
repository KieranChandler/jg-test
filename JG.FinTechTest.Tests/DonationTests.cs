using System;
using JG.FinTechTest.GiftAid.Donations;
using NUnit.Framework;

namespace JG.FinTechTest.Tests
{
    public class DonationTests
    {
        [Test]
        public void CanCreateDonation()
        {
            // Arrange
            string name = "Test User";
            string postCode = "AB12CD";
            decimal donationAmount = 2.0m;

            // Act
            TestDelegate act = () => { var newDonation = new Donation(name, postCode, donationAmount); };

            // Assert
            Assert.DoesNotThrow(act);
        }

        [Test]
        public void GivenNameIsNull_ShouldThrowArgumentException()
        {
            // Arrange
            string name = null;
            string postCode = "AB12CD";
            decimal donationAmount = 2.0m;

            // Act
            TestDelegate act = () => { var newDonation = new Donation(name, postCode, donationAmount); };

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Test]
        public void GivenNameIsPostCode_ShouldThrowArgumentException()
        {
            // Arrange
            string name = "Test User";
            string postCode = null;
            decimal donationAmount = 2.0m;

            // Act
            TestDelegate act = () => { var newDonation = new Donation(name, postCode, donationAmount); };

            // Assert
            Assert.Throws<ArgumentException>(act);
        }

        [Theory]
        [TestCase(1.99)]
        [TestCase(100000.01)]
        public void GivenNameIsDonationAmountIsNotInRange_ShouldThrowArgumentException(decimal donationAmount)
        {
            // Arrange
            string name = "Test User";
            string postCode = "AB12CD";

            // Act
            TestDelegate act = () => { var newDonation = new Donation(name, postCode, donationAmount); };

            // Assert
            Assert.Throws<ArgumentException>(act);
        }
    }
}