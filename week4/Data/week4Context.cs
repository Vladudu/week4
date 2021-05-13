using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using week4.Models;

namespace week4.Data
{
    public class week4Context : DbContext
    {
        public DbSet<week4.Models.Movie> Movie { get; set; }
        public week4Context (DbContextOptions<week4Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Models.Movie>().HasData(new Models.Movie() { ID = new Guid("{116AAAC8-85F2-4245-8AA8-74AB40B29242}"), Name = "Movie2", PublishDate = new DateTime(2021, 10, 10});
        }


    }
}
