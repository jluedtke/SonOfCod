using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SonOfCod.Models
{
    [Table("Recipient")]
    public class Recipient
    {
        [Key]
        private int RecipeintId { get; set; }
        private string Email { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string PhoneNumber { get; set; }
    }
}
