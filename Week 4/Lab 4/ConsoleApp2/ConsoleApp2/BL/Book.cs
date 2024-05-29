using System.Collections.Generic;

namespace ConsoleApp2.BL
{
    internal class Book
    {
        public Book(string title ,string author,int pages,int bookMark,int price) 
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.bookMark = bookMark;
            this.price = price;


        }
        private string title;
        private string author;
        private int pages;
        private List<string> chapters = new List<string>();
        private int bookMark;
        private int price;
        private bool isAvailable;

        public bool isBookAvailable()
        {

        }
    }
}
