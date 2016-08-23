using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bamboo.Models
{
    [Table("users")]
    public class RegistrationModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}")]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "char(1)")]
        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

    }
}
