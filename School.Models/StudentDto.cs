using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class StudentDto
    {
        [Name("USERID")]
        [Required]
        public string userId { get; set; }
        [Name("FIRSTNAME")]
        [Required]
        public string firstname { get; set; }
        [Name("MIDDLENAME")]
        [Required]
        public string middlename { get; set; }
        [Name("LASTNAME")]
        [Required]
        public string lastname { get; set; }
        [Name("STUDENTID")]
        [Required]
        public string studentid { get; set; }
        [Name("PHONE")]
        [Required]
        public string phone { get; set; }
        [Required]
        public ParentDto parent { get; set; }
        [Name("NOTE")]
        public string? note { get; set; }
    }
}
