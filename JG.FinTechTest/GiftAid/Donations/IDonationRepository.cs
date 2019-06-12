using System.Threading.Tasks;

namespace JG.FinTechTest.GiftAid.Donations
{
    public interface IDonationRepository
    {
        Task SaveAsync(Donation donation);
    }
}