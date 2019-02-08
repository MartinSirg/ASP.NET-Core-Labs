using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new BoolToZeroOneConverter<Int16>();

            modelBuilder
                .Entity<IdentityUser>()
                .Property(user => user.LockoutEnabled)
                .HasConversion(converter);
            
            modelBuilder
                .Entity<IdentityUser>()
                .Property(user => user.TwoFactorEnabled)
                .HasConversion(converter);

            modelBuilder
                .Entity<IdentityUser>()
                .Property(user => user.EmailConfirmed)
                .HasConversion(converter);
            
            modelBuilder
                .Entity<IdentityUser>()
                .Property(user => user.PhoneNumberConfirmed)
                .HasConversion(converter);
            
            base.OnModelCreating(modelBuilder);
                  
        }
    }
}