using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infoline.Api.Entities
{
    public class Context : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<UsersAnswer> UserAnswers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=Infoline; Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
