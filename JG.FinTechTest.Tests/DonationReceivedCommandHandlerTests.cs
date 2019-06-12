using JG.FinTechTest.GiftAid.Donations;
using JG.FinTechTest.Persistence;
using NUnit.Framework;

namespace JG.FinTechTest.Tests
{
    public class DonationReceivedCommandHandlerTests
    {
        [Test]
        public void CanHandleCommand()
        {
            // Arrange
            var command = new DonationReceivedCommand
            {
                Name = "Test User",
                PostCode = "AB12CD",
                DonationAmount = 2.0m
            };

            var commandHandler = new DonationReceivedCommandHandler(new DonationInMemoryRepository());

            // Act
            AsyncTestDelegate act = async () => await commandHandler.HandleAsync(command);

            // Assert
            Assert.DoesNotThrowAsync(act);
        }
    }
}