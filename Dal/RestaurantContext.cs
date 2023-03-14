using Microsoft.EntityFrameworkCore;
using System;

namespace Dal
{
    public partial class RestaurantContext: DbContext
    {
        public RestaurantContext()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=LAPTOP-A0U6BIR9\\SQLEXPRESS;Initial Catalog=DonnaPizza;Integrated security=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
