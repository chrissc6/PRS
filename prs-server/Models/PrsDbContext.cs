using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prs.Models
{
    public class PrsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public PrsDbContext(DbContextOptions<PrsDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            builder.Entity<Vendor>()
                .HasIndex(v => v.Code)
                .IsUnique();
        }

        /*
         * protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connStr = @"server = localhost\sqlexpress;" +
                "database = PrsDb3;" +
                "trusted_connection = true;";

            builder.UseSqlServer(connStr);
        }
        */
    }
}
