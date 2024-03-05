using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Publisher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pub_id { get; set; }

        [Required(ErrorMessage = "Publisher name is required")]
        [MaxLength(50)]
        public string? Publisher_name { get; set; }

        //[Required(ErrorMessage = "City is required")]
        [MaxLength(50)]
        public string? City { get; set; }

        //[Required(ErrorMessage = "State is required")]
        [MaxLength(50)]
        public string? State { get; set; }

        //[Required(ErrorMessage = "Country is required")]
        [MaxLength(50)]
        public string? Country { get; set; }
    }
}
