using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreSideKick.WebUI
{
    public class CreateEmployeeDTO
    {
        public string? Name {get; set;}
        public string? Surname {get; set;}
        public decimal? Salary {get; set;}
        public string? Department {get; set;}
        public bool? Status {get; set;}
    }
}
