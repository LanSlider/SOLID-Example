using System;

namespace I_Invalid
{
    class EbayCommerceService : ICommerceService
    {
        public void ShowStatus(int id)
        { }

        public void Buy(int id, int amount)
        {
            throw new NotImplementedException();
        }

        public void CancelBuying(int id)
        {
            throw new NotImplementedException();
        }

        public void SendCallback(int number)
        {
            throw new NotImplementedException();
        }

        public void SendRepairsRequest(int id, DateTime purchaseDate)
        {
            throw new NotImplementedException();
        }
    }
}
