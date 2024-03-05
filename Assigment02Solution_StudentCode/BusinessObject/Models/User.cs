using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        //[Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? EmailAddress { get; set; }

        //[Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password length must be between 6 and 20 characters.")]
        public string? Password { get; set; }

        //[Required(ErrorMessage = "Source is required.")]
        public string? Source { get; set; }

        //[Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name length cannot exceed 50 characters.")]
        public string? FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Middle name length cannot exceed 50 characters.")]
        public string? MiddleName { get; set; }

        //[Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, ErrorMessage = "Last name length cannot exceed 50 characters.")]
        public string? LastName { get; set; }

        // Khai báo khóa ngoại đến bảng Role
        [ForeignKey("RoleId")]
        public virtual Role? Role { get; set; }
        public int? RoleId { get; set; }

        // Khai báo khóa ngoại đến bảng Publisher
        [ForeignKey("PubId")]
        public virtual Publisher? Publisher { get; set; }
        public int? PubId { get; set; }

        //[Required(ErrorMessage = "Hire date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid hire date format.")]
        public DateTime? HireDate { get; set; }


    }
}
