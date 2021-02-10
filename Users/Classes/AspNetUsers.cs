using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Users.Classes
{
    [Table("tblAspNetUsers")]
    public class AspNetUsers
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string UserName { get; set; }
        [StringLength(255)]
        public string NormalizedUserName { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string PhoneNumber { get; set; }

        public virtual ICollection<AspNetUserRoles> uRoles { get; set; }
    }
}
