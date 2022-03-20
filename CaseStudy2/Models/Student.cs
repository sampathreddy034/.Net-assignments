using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CaseStudy2.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudId { get; set; }
        public string StudName { get; set; }
        public string Branch { get; set; }
        public int Percentage { get; set; }
        public string City { get; set; }
    }
}
