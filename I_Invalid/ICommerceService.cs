namespace I_Invalid
{
    public interface ICommerceService
    {
        void Buy(int amount);
        void CancelBuying(int id);
        void MakeLog();
        void ShowStatus(int id);
    }
}
