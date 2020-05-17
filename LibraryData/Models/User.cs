using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Data.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        [Required] public string Password { get; set; }
        [Required] public Role Role { get; set; }
       
    }
}
