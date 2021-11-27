using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Serialization.Models
{
    public class Book
    {
        public int BookID { get; set;}
        public string BookName{ get; set; }
        public string AuthorName { get; set; }

    }
}
