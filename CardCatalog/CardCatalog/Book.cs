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
    [Serializable]
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public string Genre { get; set; }
        public int YearPublished { get; set; }
    }
}
