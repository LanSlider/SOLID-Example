namespace S_Valid
{
    public class Book
    {
        public BookModel CurrentBook { get; set; }

        public void NextPage()
        { }

        public void PrevPage()
        { }

        public void ToFirstPage()
        { }

        public void PrintPage(IPrinter printer)
        { }
    }
}
