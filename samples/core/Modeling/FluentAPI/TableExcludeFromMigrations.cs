﻿using Microsoft.EntityFrameworkCore;

namespace EFModeling.FluentAPI.Relational.TableExcludeFromMigrations
{
    class MyContext : DbContext
    {
        public DbSet<IdentityUser> Users { get; set; }

        #region TableExcludeFromMigrations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>()
                .ToTable("AspNetUsers", t => t.ExcludeFromMigrations());
        }
        #endregion
    }

    public class IdentityUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
    }
}
