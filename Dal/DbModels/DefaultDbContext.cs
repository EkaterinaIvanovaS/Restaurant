using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dal.DbModels
{
    public partial class DefaultDbContext : DbContext
    {
        public DefaultDbContext()
        {
        }

        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShopCard> ShopCards { get; set; }
        public virtual DbSet<ShopCardItem> ShopCardItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-A0U6BIR9\\SQLEXPRESS;Initial Catalog=DonnaPizza;Integrated security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Products__Catego__3B75D760");
            });

            modelBuilder.Entity<ShopCard>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(300)
                    .HasColumnName("id");
            });

            modelBuilder.Entity<ShopCardItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdProduct).HasColumnName("id_Product");

                entity.Property(e => e.IdShopCard)
                    .HasMaxLength(300)
                    .HasColumnName("id_ShopCard");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ShopCardI__id_Pr__2F9A1060");

                entity.HasOne(d => d.IdShopCardNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdShopCard)
                    .HasConstraintName("FK__ShopCardI__id_Sh__308E3499");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
