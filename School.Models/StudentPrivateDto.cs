using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class StudentPrivateDto
    {
        [Name("USERID")]
        [Required]
        public string userId { get; set; }
        [Name("STUDENTFIRSTNAME")]
        [Required]
        public string firstname { get; set; }
        [Name("STUDENTMIDDLENAME")]
        [Required]
        public string middlename { get; set; }
        [Name("STUDENTLASTNAME")]
        [Required]
        public string lastname { get; set; }
        [Name("STUDENTID")]
        [Required]
        public string studentid { get; set; }
        [Name("STUDENTPHONE")]
        [Required]
        public string phone { get; set; }
        [Required]
        public FatherDto fatherDto { get; set; }
        [Required]
        public MotherDto motherDto { get; set; }
        [Name("NOTE")]
        public string? note { get; set; }
    }
}
