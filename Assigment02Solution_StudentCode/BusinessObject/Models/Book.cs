using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bookid { get; set; }

        //[Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }

        //[Required(ErrorMessage = "Type is required")]
        public string? Type { get; set; }

        [ForeignKey("Publisher")]
        public int Pub_id { get; set; }
        public virtual Publisher? Publisher { get; set; }

        //[Required(ErrorMessage = "Price is required")]
        public decimal Price { get; set; }

        //[Required(ErrorMessage = "Advance is required")]
        public decimal Advance { get; set; }

        //[Required(ErrorMessage = "Royalty is required")]
        public decimal Royalty { get; set; }

        //[Required(ErrorMessage = "YTD sales is required")]
        public int Ytd_sales { get; set; }

        public string? Notes { get; set; }

        //[Required(ErrorMessage = "Published date is required")]
        public DateTime Published_date { get; set; }
    }
}
