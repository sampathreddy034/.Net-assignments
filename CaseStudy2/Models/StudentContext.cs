using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CaseStudy2.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("name=Student")
        { }
        public DbSet<Student> Students { get; set; }
    }
}