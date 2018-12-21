using System;

namespace S_Invalid
{
    public class ReadBook
    {
        public BookModel CurrentBook { get; set; }

        public void NextPage()
        { }

        public void PrevPage()
        { }

        public void ToPage(int id)
        { }

        public void ToFirstPage()
        { }

        public void PrintPage()
        {
            Console.WriteLine(this.CurrentBook.CurrentPage);
        }
    }
}
