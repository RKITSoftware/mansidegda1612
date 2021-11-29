using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationDemo
{
    [Serializable]
    public class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
    }
}
