using System;
using System.Collections.Generic;
using System.Text;
using HappyBrainDump.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HappyBrainDump.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Interest> Interests { get; set; }
        public DbSet<UserInterest> UserInterests { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInterest>().HasKey(et => new { et.UserId, et.InterestId });

            base.OnModelCreating(modelBuilder);
        }

    }
}
