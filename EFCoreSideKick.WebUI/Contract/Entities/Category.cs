using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSideKick.WebUI
{
    public partial class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        public bool? Status { get; set; }

        public virtual ICollection<Product> Categories { get; set; } = new HashSet<Product>();
    }
}
