namespace I_Valid
{
    public interface ICommerceService
    {
        void Buy(int amount);
        void CancelBuying(int id);
        void ShowStatus(int id);
    }
}
