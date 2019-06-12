using JG.FinTechTest.GiftAid.Donations;
using NUnit.Framework;
using System.Linq;

namespace JG.FinTechTest.Tests.API.Validation
{
    public class NewDonationRequestTests
    {
        [Test]
        public void GivenNameIsNullOrEmpty_ShouldReturnInvalid()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                PostCode = "AB12CD",
                DonationAmount = 20.0m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.False(result.IsValid);
        }

        [Test]
        public void GivenNameIsNullOrEmpty_ShouldReturnAppropriateError()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                PostCode = "AB12CD",
                DonationAmount = 20.0m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.IsNotEmpty(result.Errors);
            Assert.True(
                result.Errors.Any(
                    x => x.ErrorMessage.Contains("not be empty")
                ));
        }

        [Test]
        public void GivenPostCodeIsNullOrEmpty_ShouldReturnInvalid()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                Name = "Test User",
                DonationAmount = 20.0m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.False(result.IsValid);
        }

        [Test]
        public void GivenPostCodeIsNullOrEmpty_ShouldReturnAppropriateError()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                Name = "Test User",
                DonationAmount = 20.0m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.IsNotEmpty(result.Errors);
            Assert.True(
                result.Errors.Any(
                    x => x.ErrorMessage.Contains("not be empty")
                ));
        }

        [Test]
        public void GivenDonationAmountIsLessThan2_ShouldReturnInvalid()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                Name = "Test User",
                PostCode = "AB12CD",
                DonationAmount = 1.99m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.False(result.IsValid);
        }

        [Test]
        public void GivenDonationAmountIsLessThan2_ShouldReturnAppropriateError()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                Name = "Test User",
                PostCode = "AB12CD",
                DonationAmount = 1.99m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.IsNotEmpty(result.Errors);
            Assert.True(
                result.Errors.Any(
                    x => x.ErrorMessage.Contains("greater than or equal to '2'")
                ));
        }

        [Test]
        public void GivenDonationAmountIsMoreThan100000_ShouldReturnInvalid()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                Name = "Test User",
                PostCode = "AB12CD",
                DonationAmount = 100001.01m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.False(result.IsValid);
        }

        [Test]
        public void GivenDonationAmountIsMoreThan100000_ShouldReturnAppropriateError()
        {
            // Arrange
            NewDonationRequestValidator validator = new NewDonationRequestValidator();

            NewDonationRequest request = new NewDonationRequest
            {
                Name = "Test User",
                PostCode = "AB12CD",
                DonationAmount = 100001.01m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.IsNotEmpty(result.Errors);
            Assert.True(
                result.Errors.Any(
                    x => x.ErrorMessage.Contains("less than or equal to '100000'")
                ));
        }

    }
}