using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class MotherDto
    {
        [Name("MOTHERFIRSTNAME")]
        [Required]
        public string firstname { get; set; }
        [Required]
        public string middlename { get; set; }
        [Name("MOTHERLASTNAME")]
        [Required]
        public string lastname { get; set; }
        [Name("MOTHERPHONE")]
        [Required]
        public string phone { get; set; }
    }
}
