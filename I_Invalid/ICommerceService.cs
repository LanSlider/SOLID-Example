namespace I_Invalid
{
    public interface ICommerceService
    {
        void Buy(int id,int amount);
        void CancelBuying(int id);
        void ShowStatus(int id);

        void MakeConsoleLog();
        void MakeFileLog();   
    }
}
