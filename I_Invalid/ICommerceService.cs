using System;

namespace I_Invalid
{
    public interface ICommerceService
    {
        void Buy(int id,int amount);
        void CancelBuying(int id);
        void SendCallback(int number);
        void SendRepaitRequest(int id, DateTime purchaseDate); 
    }
}
