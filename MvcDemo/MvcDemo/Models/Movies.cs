using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDemo.Models
{
    public class Movies
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Release { get; set; }
    }

    public class MovieContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; } 
    }
}
