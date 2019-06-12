using System;

namespace JG.FinTechTest.GiftAid.Donations
{
    public class Donation
    {
        public string Name { get; private set; }

        public PostCode PostCode { get; private set; }

        public decimal DonationAmount { get; private set; }

        public Donation(string name, string postCode, decimal donationAmount)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException($"{nameof(name)} cannot be null or empty", nameof(name));

            if (string.IsNullOrEmpty(postCode))
                throw new ArgumentException($"{nameof(postCode)} cannot be null or empty", nameof(postCode));

            if (donationAmount < 2 || donationAmount > 100000)
                throw new ArgumentException($"{nameof(donationAmount)} must be in the range of 2.00 and 100,000.00", nameof(donationAmount));

            Name = name;
            PostCode = new PostCode(postCode);
            DonationAmount = donationAmount;
        }
    }
}