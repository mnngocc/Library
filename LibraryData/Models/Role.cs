using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Data.Models
{
    public class Role
    {
        public int RoleID { get; set; }
        [Required]  public string RoleName { get; set; }
        public virtual IEnumerable<User> Users { get; set; }

    }
}
