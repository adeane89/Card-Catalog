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
    public class Program
    {
        static void Main(string[] args)
        {
            
            CardCatalog cardCat = new CardCatalog();
            cardCat._filename= "HP";
            
            /*            
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
                Console.WriteLine(item.Title+item.Author);
            }
            */

            Console.ReadLine();

        } 

     }
}
