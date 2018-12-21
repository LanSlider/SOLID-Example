using System;

namespace I_Valid.Implementation
{
    class EbayCommerceService : ICommerceService, IRepairService
    {
        public void Buy(int id, int amount)
        {
            throw new NotImplementedException();
        }

        public void CancelBuying(int id)
        {
            throw new NotImplementedException();
        }

        public void SendRepairsRequest(int id, DateTime purchaseDate)
        {
            throw new NotImplementedException();
        }
    }
}
