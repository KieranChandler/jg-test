using FluentValidation;

namespace JG.FinTechTest.GiftAid.Donations
{
    public class NewDonationRequest
    {
        public string Name { get; set; }

        public string PostCode { get; set; }

        public decimal DonationAmount { get; set; }
    }

    public class NewDonationRequestValidator : AbstractValidator<NewDonationRequest>
    {
        public NewDonationRequestValidator()
        {
            RuleFor(req => req.Name)
                .NotEmpty();

            RuleFor(req => req.PostCode)
                .NotEmpty();

            RuleFor(req => req.DonationAmount)
                .GreaterThanOrEqualTo(2)
                .LessThanOrEqualTo(100000);
        }
    }
}