using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Shelve
    {
        public string shelveName { get; set; }
        public List<Book> books = new List<Book>();

        public Shelve(string ShelveName)
        {
            this.shelveName = ShelveName;
        }

        public void AddBook(string bookName)
        {
            Book book = new Book(bookName);
            books.Add(book);
        }

        public void RemoveBook(string bookName)
        {
            foreach (Book b in books)
            {
                if (b.bookName == bookName)
                {
                    books.Remove(b);
                }
            }
        }

        public void ShowBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine(b);
            }
        }
    }
}
