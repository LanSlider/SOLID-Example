using System;

namespace I_Invalid
{
    class AmazonCommerceService : ICommerceService
    {
        public void Log(string text)
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

        public void ShowStatus(int id)
        {
            throw new NotImplementedException();
        }

        public void SendRepairsRequest(int id, DateTime purchaseDate)
        {
            throw new NotImplementedException();
        }
    }
}
