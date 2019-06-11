namespace JG.FinTechTest.GiftAid.Donations
{
    public class Donation
    {
        public string Name { get; private set; }

        public string PostCode { get; private set; }

        public decimal DonationAmount { get; private set; }

        public Donation(string name, string postCode, decimal donationAmount)
        {
            Name = name;
            PostCode = postCode;
            DonationAmount = donationAmount;
        }
    }
}