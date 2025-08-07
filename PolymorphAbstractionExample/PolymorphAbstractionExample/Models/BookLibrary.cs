using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphAbstractionExample.Models
{
    internal class BookLibrary
    {

     
        string _name;
        Book[] _books=new Book[0];

        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Book[] Books
        {
            get { return _books; }
            set { _books = value; }
        }

        public void Add(Book book)
        {
            Array.Resize(ref _books, Books.Length +1);
            Books[Books.Length - 1] = book;
        }
        public void Remove(string name)
        {
            //{A, B, C}  {"A",""}
             //0  1  2    0  1
            Book[] newBooks = new Book[Books.Length - 1];

            int j= 0;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name != name){

                    newBooks[j]= Books[i];
                    j++;
                  }
            }
            Books = newBooks;

        }
        public void ShowAll()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].PrintInfo();
            }
        }


        public void BorrowBook(string name)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name == name)
                {
                    Console.WriteLine("Kitab movcuddur");
                    if (Books[i].IsAvailable)
                    {
                        Books[i].IsAvailable = false;
                        Console.WriteLine("Kitabi goture bilersiz");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Artiq goturulub");
                        return;
                    }
                }
            }

            Console.WriteLine("Kitab movcud deyil");
        }

    }
}
