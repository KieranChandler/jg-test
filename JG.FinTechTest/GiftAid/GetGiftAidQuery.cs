namespace JG.FinTechTest.GiftAid
{
    public class GetGiftAidQuery : IGetGiftAidQuery
    {
        public GetGiftAidQueryResponse Query(GetGiftAidQueryRequest request)
        {
            var calculator = new Calculator();
            var giftAid = calculator.CalculateGiftAid(request.PrincipalAmount);

            return new GetGiftAidQueryResponse
            {
                DonationAmount = request.PrincipalAmount,
                GiftAidAmount = giftAid
            };
        }
    }
}