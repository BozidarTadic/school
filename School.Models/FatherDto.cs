using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class FatherDto
    {
        [Name("FATHERFIRSTNAME")]
        [Required]
        public string firstname { get; set; }
        [Required]
        public string middlename { get; set; }
        [Name("FATHERLASTNAME")]
        [Required]
        public string lastname { get; set; }
        [Name("FATHERPHONE")]
        [Required]
        public string phone { get; set; }
    }
}
