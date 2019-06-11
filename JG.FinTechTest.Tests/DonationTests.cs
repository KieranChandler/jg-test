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
    }
}