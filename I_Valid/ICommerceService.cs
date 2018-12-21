namespace I_Valid
{
    public interface ICommerceService
    {
        void Buy(int id, int amount);
        void CancelBuying(int id);
    }
}
