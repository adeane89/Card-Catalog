using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
        }
    }

    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
    }

    //why won't Book turn blue????
    public class CardCatalog : Book
    {
        private string _filename { get; set; }

        //we have to do something with this code
        private List<Book> books = new List<Book>() { };
        
        
        public CardCatalog(string filename)
        {
            _filename = filename;
        }
        
        // static List<string> movieTitles = new List<string>();

        static void optionMenu()
        {

        }                   
              
        public void ListBooks(Book addMoreBooks = null)
        {
            List<Book> bookList = new List<Book>()
            {
                new Book{Title = "Rosemary's Baby", Author = "Ira Levin", Genre = "Horror" },
                new Book{Title = "50 Shades of Grey", Author = "E.L.Green", Genre = "Erotica"},
                new Book{Title = "Harry Potter", Author = "J.K. Rowling", Genre = "Young Adult"},
                new Book{Title = "Salem's Lot", Author = "Stephen King", Genre = "Horror"},
                new Book{Title = "Percy Jackson", Author = "Rick Riordan", Genre = "Young Adult" },
            };

            if (addMoreBooks == null)
            {

            }

            else
            {
                Console.WriteLine(books);
            }

            var alphabetizedBooks = from allbooks in bookList
                                    orderby allbooks.Title ascending
                                    select allbooks;
                               

            foreach (var item in alphabetizedBooks)
            {
                Console.WriteLine("{0} written by {1}", item.Title, item.Author);
            }
        }

        public void AddBook()
        {
            string bookTitle = "";
            string bookAuthor = "";
            string bookGenre = "";

            Console.WriteLine("Please enter a Title: ");
            bookTitle = Console.ReadLine();

            Console.WriteLine("Please enter an Author: ");
            bookAuthor = Console.ReadLine();

            Console.WriteLine("Please enter a genre: ");
            bookGenre = Console.ReadLine();

            Book newBook = new Book { Title = bookTitle, Author = bookAuthor, Genre = bookGenre };
            books.Add(newBook);
        }

        public void Save()
        {
            /*
            XmlSerializer xs = new XmlSerializer(typeof(CardCatalog));
            Stream stream = File.OpenWrite(_filename);
            xs.Serialize(stream, books);
            stream.Close();
            stream.Dispose();
            */
            //serialize with binary
            /*
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this.books);
            stream.Close();
            stream.Dispose();
            */
        }
    }
}

