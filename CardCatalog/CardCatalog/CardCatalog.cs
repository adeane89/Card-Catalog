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
        

        public void ListBooks()
        {
           
        }

        public void AddBook()
        {
            //Book newbook = new Book();
            //newbook.Title = title;
            //newbook.Author = author;   
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
