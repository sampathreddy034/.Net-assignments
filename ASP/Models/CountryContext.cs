using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class CountryContext:DbContext
    {
        public CountryContext():base("name=Country")
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}