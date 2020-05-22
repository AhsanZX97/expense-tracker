using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Range(1, 16)]
        [Required]
        public string password { get; set; }
    }
}
