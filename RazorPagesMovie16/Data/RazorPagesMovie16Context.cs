using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie16.Models;

namespace RazorPagesMovie16.Data
{
    public class RazorPagesMovie16Context : DbContext
    {
        public RazorPagesMovie16Context (DbContextOptions<RazorPagesMovie16Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie16.Models.Movie> Movie { get; set; }
    }
}
