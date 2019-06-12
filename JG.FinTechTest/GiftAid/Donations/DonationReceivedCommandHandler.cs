using System.Threading.Tasks;

namespace JG.FinTechTest.GiftAid.Donations
{
    public class DonationReceivedCommand
    {
        public string Name { get; set; }

        public string PostCode { get; set; }

        public decimal DonationAmount { get; set; }
    }

    public class DonationReceivedCommandHandler
    {
        private readonly IDonationRepository _donations;

        public DonationReceivedCommandHandler(IDonationRepository donations)
        {
            _donations = donations;
        }

        public async Task HandleAsync(DonationReceivedCommand command)
        {
            var newDonation = new Donation(command.Name, command.PostCode, command.DonationAmount);

            await _donations.SaveAsync(newDonation);
        }
    }
}