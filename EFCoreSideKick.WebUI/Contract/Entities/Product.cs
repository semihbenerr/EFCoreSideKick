using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSideKick.WebUI
{
    public partial class Product
    {
        [Required]
        [Key]
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        public decimal? Price { get; set; }

        public int? Stock { get; set; }

        public bool? Status { get; set; }

        public virtual Category? Category { get; set; }
    }
}
