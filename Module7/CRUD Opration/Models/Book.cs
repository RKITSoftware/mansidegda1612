using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Opration.Models
{
    /// <summary>
    /// Book model
    /// fields :
    /// public BookID
    /// public BookName
    /// public AuthorName
    /// </summary>
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        [Required(ErrorMessage = "This property is Required")]
        [StringLength(50, ErrorMessage = "string length can't be more than 50")]
        public string BookName { get; set; }
        public string AuthorName { get; set; }
    }
}
