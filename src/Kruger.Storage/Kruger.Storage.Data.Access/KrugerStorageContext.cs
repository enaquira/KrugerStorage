using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace Kruger.Storage.Data.Access.Entities
{
    public partial class KrugerStorageContext : DbContext
    {
        private readonly IConfiguration _config;

        public KrugerStorageContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Rack> Rack { get; set; }
        public virtual DbSet<Storage> Storage { get; set; }
        public virtual DbSet<StorageOrder> StorageOrder { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("KrugerStorage"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer", "Sales");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeId).HasColumnName("DocumentTypeID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(10);

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_CustomerType");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.ToTable("CustomerType", "Sales");

                entity.Property(e => e.CustomerTypeId).HasColumnName("CustomerTypeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDescription).HasMaxLength(10);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product", "Operations");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Size).HasMaxLength(5);

                entity.Property(e => e.SizeUnitMeasureCode).HasMaxLength(3);

                entity.Property(e => e.Weight).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.WeightUnitMeasureCode).HasMaxLength(3);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Product_Customer");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_ProductCategory");

                entity.HasOne(d => d.SizeUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductSizeUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.SizeUnitMeasureCode)
                    .HasConstraintName("FK_Product_UnitMeasure");

                entity.HasOne(d => d.WeightUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductWeightUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.WeightUnitMeasureCode)
                    .HasConstraintName("FK_Product_UnitMeasure1");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.ToTable("ProductCategory", "Operations");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rack>(entity =>
            {
                entity.ToTable("Rack", "Operations");

                entity.Property(e => e.RackId).HasColumnName("RackID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorageId).HasColumnName("StorageID");

                entity.HasOne(d => d.Storage)
                    .WithMany(p => p.Rack)
                    .HasForeignKey(d => d.StorageId)
                    .HasConstraintName("FK_Rack_Storage");
            });

            modelBuilder.Entity<Storage>(entity =>
            {
                entity.ToTable("Storage", "Operations");

                entity.Property(e => e.StorageId).HasColumnName("StorageID");

                entity.Property(e => e.ProductCategoryId).HasColumnName("ProductCategoryID");
            });

            modelBuilder.Entity<StorageOrder>(entity =>
            {
                entity.ToTable("StorageOrder", "Operations");

                entity.Property(e => e.StorageOrderId).HasColumnName("StorageOrderID");

                entity.Property(e => e.DepartureDate).HasColumnType("datetime");

                entity.Property(e => e.DiscontinuedDate).HasColumnType("date");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RackId).HasColumnName("RackID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.StorageOrder)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_StorageOrder_Product");

                entity.HasOne(d => d.Rack)
                    .WithMany(p => p.StorageOrder)
                    .HasForeignKey(d => d.RackId)
                    .HasConstraintName("FK_StorageOrder_Rack");
            });

            modelBuilder.Entity<UnitMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitMeasureCode);

                entity.ToTable("UnitMeasure", "Operations");

                entity.Property(e => e.UnitMeasureCode)
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });
        }
    }
}
