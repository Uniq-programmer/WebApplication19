using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace WebApplication19.Models
{
    public class BarAlemDBContext:DbContext
    {
        public BarAlemDBContext(DbContextOptions<BarAlemDBContext> op) : base(op)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Kniga> Kniga { get; set; }

    }
}
