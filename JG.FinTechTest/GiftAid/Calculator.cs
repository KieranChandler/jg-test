namespace JG.FinTechTest.GiftAid
{
    public class Calculator
    {
        private const decimal giftAidMultiplier = 0.2m;

        public decimal CalculateGiftAid(decimal principalAmount)
        {
            return principalAmount * giftAidMultiplier;
        }
    }
}