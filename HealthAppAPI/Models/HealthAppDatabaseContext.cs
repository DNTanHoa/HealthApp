using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HealthAppAPI.Models
{
    public partial class HealthAppDatabaseContext : DbContext
    {
        public HealthAppDatabaseContext()
        {
        }

        public HealthAppDatabaseContext(DbContextOptions<HealthAppDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hospitals> Hospitals { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<PostCategory> PostCategory { get; set; }
        public virtual DbSet<PostContent> PostContent { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<SystemRoles> SystemRoles { get; set; }
        public virtual DbSet<SystemUsers> SystemUsers { get; set; }
        public virtual DbSet<XpobjectType> XpobjectType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=94.237.77.204; Database=minaheal_health;user=minaheal_admin;password=for_admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hospitals>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Hospitals", "minaheal_health");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_Hospitals");

                entity.HasIndex(e => e.Region)
                    .HasName("iregion_Hospitals");

                entity.Property(e => e.Oid)
                    .HasColumnType("char(38)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Gcrecord)
                    .HasColumnName("GCRecord")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OptimisticLockField)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.RegionNavigation)
                    .WithMany(p => p.Hospitals)
                    .HasForeignKey(d => d.Region)
                    .HasConstraintName("FK_Hospitals_region");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Post", "minaheal_health");

                entity.HasIndex(e => e.Category)
                    .HasName("icategory_Post");

                entity.Property(e => e.Oid).HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("char(38)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Summary)
                    .HasColumnName("summary")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.CategoryNavigation)
                    .WithMany(p => p.Post)
                    .HasForeignKey(d => d.Category)
                    .HasConstraintName("FK_Post_category");
            });

            modelBuilder.Entity<PostCategory>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PostCategory", "minaheal_health");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_PostCategory");

                entity.Property(e => e.Oid)
                    .HasColumnType("char(38)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gcrecord)
                    .HasColumnName("GCRecord")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OptimisticLockField)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<PostContent>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("PostContent", "minaheal_health");

                entity.HasIndex(e => e.Post)
                    .HasName("ipost_PostContent");

                entity.Property(e => e.Oid).HasColumnType("int(11)");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Post)
                    .HasColumnName("post")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.HasOne(d => d.PostNavigation)
                    .WithMany(p => p.PostContent)
                    .HasForeignKey(d => d.Post)
                    .HasConstraintName("FK_PostContent_post");
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("Regions", "minaheal_health");

                entity.Property(e => e.Oid).HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<SystemRoles>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SystemRoles", "minaheal_health");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SystemRoles");

                entity.Property(e => e.Oid)
                    .HasColumnType("char(38)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gcrecord)
                    .HasColumnName("GCRecord")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OptimisticLockField)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<SystemUsers>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("SystemUsers", "minaheal_health");

                entity.HasIndex(e => e.Gcrecord)
                    .HasName("iGCRecord_SystemUsers");

                entity.Property(e => e.Oid)
                    .HasColumnType("char(38)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Gcrecord)
                    .HasColumnName("GCRecord")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.OptimisticLockField)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.StoredPassword)
                    .HasColumnName("storedPassword")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });

            modelBuilder.Entity<XpobjectType>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.ToTable("XPObjectType", "minaheal_health");

                entity.HasIndex(e => e.TypeName)
                    .HasName("iTypeName_XPObjectType")
                    .IsUnique();

                entity.Property(e => e.Oid)
                    .HasColumnName("OID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssemblyName)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(254)
                    .IsUnicode(false)
                    .HasDefaultValueSql("NULL");
            });
        }
    }
}
