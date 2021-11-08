using Microsoft.EntityFrameworkCore;
using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditClone.Database
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<RedditPost> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RedditPost>(e => e
            .HasOne<User>(p => p.User)
            .WithMany(u => u.Posts)
            .HasForeignKey(p => p.Userid)
            .IsRequired(true));
        }
    }
}
