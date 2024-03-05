using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Author
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Author_Id { get; set; }

        //[Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Last name must be less than 50 characters.")]
        public string? LastName { get; set; }

        //[Required(ErrorMessage = "First name is required.")]
        [MaxLength(50, ErrorMessage = "First name must be less than 50 characters.")]
        public string? FirstName { get; set; }

        [RegularExpression(@"^(\d{3}-\d{3}-\d{4})?$", ErrorMessage = "Invalid phone number.")]
        public string? Phone { get; set; }

        [MaxLength(100, ErrorMessage = "Address must be less than 100 characters.")]
        public string? Address { get; set; }

        //[Required(ErrorMessage = "City is required.")]
        [MaxLength(50, ErrorMessage = "City must be less than 50 characters.")]
        public string? City { get; set; }

        //[Required(ErrorMessage = "State is required.")]
        [MaxLength(2, ErrorMessage = "State must be 2 characters.")]
        public string? State { get; set; }

        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid zip code.")]
        public string? Zip { get; set; }

        //[Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? EmailAddress { get; set; }
    }
}
