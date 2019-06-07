using FluentValidation;

namespace JG.FinTechTest.GiftAid
{
    public class GetGiftAidApiRequest
    {
        public decimal Amount { get; set; }
    }

    public class GetGiftAidApiRequestValidator : AbstractValidator<GetGiftAidApiRequest>
    {
        public GetGiftAidApiRequestValidator()
        {
            RuleFor(req => req.Amount)
                .GreaterThanOrEqualTo(2)
                .LessThanOrEqualTo(100000);
        }
    }
}