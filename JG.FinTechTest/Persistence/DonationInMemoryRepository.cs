using System.Collections.Generic;
using System.Threading.Tasks;
using JG.FinTechTest.GiftAid.Donations;

namespace JG.FinTechTest.Persistence
{
    public class DonationInMemoryRepository : IDonationRepository
    {
        private List<Donation> Collection
        {
            get
            {
                if (_collection == null)
                    _collection = new List<Donation>();

                return _collection;
            }
        }
        private static List<Donation> _collection;

        public Task SaveAsync(Donation donation)
        {
            if (donation == null)
                throw new System.ArgumentNullException(nameof(donation));

            Collection.Add(donation);

            return Task.CompletedTask;
        }
    }
}