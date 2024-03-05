using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class BookAuthor
    {
        [Key]
        [Column(Order = 1)]
        public int Author_id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Book_id { get; set; }

        [Required]
        public int Author_order { get; set; }

        [Required]
        [Range(0, 100)]
        public int Royality_percentage { get; set; }

        [ForeignKey("authorid")]
        public Author? Author { get; set; }

        [ForeignKey("bookid")]
        public Book? Book { get; set; }

        //Validation for author_order field, must not be negative.
        public bool IsValidAuthorOrder()
        {
            return (Author_order >= 0);
        }
    }
}
