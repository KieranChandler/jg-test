namespace JG.FinTechTest.GiftAid
{
    public class GetGiftAidQueryRequest
    {
        public decimal PrincipalAmount { get; set; }
    }

    public class GetGiftAidQueryResponse
    {
        public decimal DonationAmount { get; set; }
        
        public decimal GiftAidAmount { get; set; }
    }

    public interface IGetGiftAidQuery
    {
        GetGiftAidQueryResponse Query(GetGiftAidQueryRequest request);
    }
}