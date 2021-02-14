using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    class RecapProjectCarDataBase:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocaldb;Database=RecapProjectCarDataBase;Trusted_Connection=True");
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> brand { get; set; }
        public DbSet<CarColor> CarColor { get; set; }
    }
}
