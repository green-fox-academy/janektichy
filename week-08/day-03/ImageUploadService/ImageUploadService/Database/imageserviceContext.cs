using System;
using ImageUploadService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ImageUploadService.Database
{
    public partial class imageserviceContext : DbContext
    {
        public imageserviceContext()
        {
        }

        public imageserviceContext(DbContextOptions<imageserviceContext> options) : base(options)
        {
        }

        public virtual DbSet<Uploadedimage> Uploadedimages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=imageservice;user=root;password=password", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8mb4")
                .UseCollation("utf8mb4_0900_ai_ci");

            modelBuilder.Entity<Uploadedimage>(entity =>
            {
                entity.HasKey(e => e.ImageId)
                    .HasName("PRIMARY");

                entity.ToTable("uploadedimages");

                entity.Property(e => e.ImageName).HasMaxLength(300);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Uploadedimage>(entity => entity
            .HasOne<User>(u => u.User)
            .WithMany(i => i.AllImages)
            .HasForeignKey(i => i.UserId)
            .IsRequired(false));

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
