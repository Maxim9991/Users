using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Classes
{
    public class MyContext : DbContext
    {
        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.238.103.51;Port=5743;Database=maximdb;Username=maxim;Password=$544$B77w**G)K$t!Ube22}rad");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AspNetUserRoles>(aspnetroles => 
            {
                aspnetroles.HasKey(asp => new { asp.RoleId, asp.UserId });

                aspnetroles.HasOne(asp => asp.users).WithMany(a => a.uRoles).HasForeignKey(a => a.RoleId).IsRequired();

                aspnetroles.HasOne(asp => asp.roles).WithMany(a => a.UserRoles).HasForeignKey(a => a.UserId).IsRequired();
            });
        }
    }
}
