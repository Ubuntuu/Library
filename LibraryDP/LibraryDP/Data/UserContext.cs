using LibraryDP.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryDP.Data
{
    public class UserContext : IdentityDbContext
    {

        public UserContext(DbContextOptions<UserContext> options)
          : base(options)
        {
        }

        public DbSet<User> MyUsers { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("ListOfUsersDatabase");
            base.OnModelCreating(builder);
        }
    }
}
