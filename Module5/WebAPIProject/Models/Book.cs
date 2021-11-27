using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required]
        public string BookName { get; set; }
        public string AuthorName { get; set; }
    }
}