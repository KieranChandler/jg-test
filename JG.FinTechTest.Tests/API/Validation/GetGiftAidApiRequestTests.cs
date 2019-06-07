using System.Linq;
using JG.FinTechTest.GiftAid;
using NUnit.Framework;

namespace JG.FinTechTest.Tests.API.Validation
{
    public class GetGiftAidApiRequestTests
    {
        [Test]
        public void GivenAmountIsLessThan2_ShouldReturnInvalid()
        {
            // Arrange
            GetGiftAidApiRequestValidator validator = new GetGiftAidApiRequestValidator();

            GetGiftAidApiRequest request = new GetGiftAidApiRequest
            {
                Amount = 1.99m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.False(result.IsValid);
        }

        [Test]
        public void GivenAmountIsLessThan2_ShouldReturnAppropriateError()
        {
            // Arrange
            GetGiftAidApiRequestValidator validator = new GetGiftAidApiRequestValidator();

            GetGiftAidApiRequest request = new GetGiftAidApiRequest
            {
                Amount = 1.99m
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
        public void GivenAmountIsMoreThan100000_ShouldReturnInvalid()
        {
            // Arrange
            GetGiftAidApiRequestValidator validator = new GetGiftAidApiRequestValidator();

            GetGiftAidApiRequest request = new GetGiftAidApiRequest
            {
                Amount = 100001.01m
            };

            // Act
            var result = validator.Validate(request);

            // Assert
            Assert.False(result.IsValid);
        }

        [Test]
        public void GivenAmountIsMoreThan100000_ShouldReturnAppropriateError()
        {
            // Arrange
            GetGiftAidApiRequestValidator validator = new GetGiftAidApiRequestValidator();

            GetGiftAidApiRequest request = new GetGiftAidApiRequest
            {
                Amount = 100001.01m
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