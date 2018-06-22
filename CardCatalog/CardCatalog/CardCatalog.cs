using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CardCatalog
{
    [Serializable()]
    public class CardCatalog : ISerializable
    {
        //private string _filename;
        public string _filename { get; set; }
        private string[] books;

        public CardCatalog()
        {
            //empty constructor required to compile
        }
        
        public CardCatalog(string fileName)
        {
            Console.WriteLine("Please enter the name of a file: ");
            fileName = Console.ReadLine();
            _filename = fileName;
        }
        //come back
        public static void ListBooks(Book addList = null)
        {
            List<Book> newBook = new List<Book>()
            {
                new Book() {Title = "Harry Potter", Author = "JK Rowling"},
                new Book() {Title = "Dracula", Author = "Bram Stoker"},
                new Book() {Title = "The Phantom of the Opera", Author = "Gaston LeRoux"}
            };

            if(addList == null)
            {
                
            }
            else
            {
                newBook.Add(addList);
            }

            var alphabetizedBooks = from allbooks in newBook
                    orderby allbooks.Title ascending
                    select allbooks;

            foreach (var item in alphabetizedBooks)
            {
                Console.WriteLine("{0} written by {1}", item.Title, item.Author);
            }
            
        }

        public void AddBook(string title, string author)
        {
            Book addNewBook = new Book() { Title = title, Author = author};

            ListBooks(addNewBook);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

        }
    }
}
