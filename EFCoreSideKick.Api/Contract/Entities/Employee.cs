using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSideKick.Api
{
    public partial class Employee
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Surname { get; set; }

        public decimal? Salary { get; set; }

        [StringLength(50)]
        public string? Department { get; set; }

        public bool? Status { get; set; }
    }
}
