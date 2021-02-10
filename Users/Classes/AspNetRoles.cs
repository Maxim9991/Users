using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Users.Classes
{
    [Table("tblAspNetRoles")]
    public class AspNetRoles
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string NormalizedName { get; set; }
        [StringLength(1000)]
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<AspNetUserRoles> UserRoles { get; set; }
    }
}
