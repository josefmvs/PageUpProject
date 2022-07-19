using Microsoft.EntityFrameworkCore;
using PageUpProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageUpProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
         
        }

        public DbSet<Rule> Rules { get; set; }

       // public DbSet<Parcel> Parcels { get; set; }
    }
}
