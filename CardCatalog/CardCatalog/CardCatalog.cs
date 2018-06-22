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
    public class CardCatalog
    {
        public string _filename { get; set; }
        private string[] books = { "book1", "book2" };
        
        public CardCatalog(string fileName)
        {
            /*
            _filename = fileName;
            //deserialize...
            Stream readStream = new FileStream(_filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            CardCatalog cardCat1 = (CardCatalog)formatter.Deserialize(readStream);
            readStream.Close();
            readStream.Dispose();
            */
        }
        //come back
        public void ListBooks()
        {
            Book newbook = new Book();
            List<Book> newBook = new List<Book>()
            {
                new Book() {Title = "Harry Potter", Author = "JK Rowling"},
                new Book() {Title = "Dracula", Author = "Bram Stoker"},
                new Book() {Title = "The Phantom of the Opera", Author = "Gaston LeRoux"}
            };

            var alphabetizedBooks = from allbooks in newBook
                    orderby allbooks.Title ascending
                    select allbooks;

            foreach (var item in alphabetizedBooks)
            {
                Console.WriteLine("{0} written by {1}", item.Title, item.Author);
            }
            
        }

        public void AddBook()
        {
            Book newbook = new Book();
            newbook.Title = "";
            newbook.Author = "";                    
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(_filename, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, _filename);
            stream.Close();
            stream.Dispose();
            
        }
    }
}
