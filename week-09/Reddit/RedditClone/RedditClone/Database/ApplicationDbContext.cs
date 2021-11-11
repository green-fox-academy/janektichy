using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RedditClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace RedditClone.Database
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<RedditPost> Posts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        private readonly IHttpContextAccessor _httpContextAccessor;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
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
