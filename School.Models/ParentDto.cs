using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class ParentDto
    {
        [Name("PARENTFIRSTNAME")]
        [Required]
        public string firstname { get; set; }
        [Required]
        public string middlename { get; set; }
        [Name("PARENTLASTNAME")]
        [Required]
        public string lastname { get; set; }
        [Name("PARENTPHONE")]
        [Required]
        public string phone { get; set; }
    }
}
