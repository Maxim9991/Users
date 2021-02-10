using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Users.Classes
{
    [Table("tblAspNetUserRoles")]
    public class AspNetUserRoles
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public virtual AspNetUsers users { get; set; }
        public virtual AspNetRoles roles { get; set; }
    }
}
