﻿using System;
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
            
            //Serialize...
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Cardcat.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, cardCat);
            stream.Close();
            
            //Deserialize...
            Stream readStream = new FileStream("Cardcat.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            CardCatalog cardCat1 = (CardCatalog)formatter.Deserialize(readStream);
            readStream.Close();
            
        }
    }
}
