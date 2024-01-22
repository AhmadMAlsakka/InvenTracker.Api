using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InvenTracker.Api.Models;

public partial class InvenTrackerContext : DbContext
{
    public InvenTrackerContext()
    {
    }

    public InvenTrackerContext(DbContextOptions<InvenTrackerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }

    public virtual DbSet<CustomerOrderItem> CustomerOrderItems { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductVariant> ProductVariants { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Vendor> Vendors { get; set; }

    public virtual DbSet<Warehouse> Warehouses { get; set; }

    public virtual DbSet<WarehouseOrder> WarehouseOrders { get; set; }

    public virtual DbSet<WarehouseOrderItem> WarehouseOrderItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AHMAD-PC;Database=InvenTracker;Trusted_Connection=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B88AC349C4");

            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("CustomerID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LandlinePhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Customer__C3905BAFF8B5E507");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerOrders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerO__Custo__52593CB8");

            entity.HasOne(d => d.User).WithMany(p => p.CustomerOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__CustomerO__UserI__5165187F");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.CustomerOrders)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__CustomerO__Wareh__60A75C0F");
        });

        modelBuilder.Entity<CustomerOrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK__Customer__57ED06A124AD14CF");

            entity.Property(e => e.OrderItemId)
                .ValueGeneratedNever()
                .HasColumnName("OrderItemID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.VariantId).HasColumnName("VariantID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Order).WithMany(p => p.CustomerOrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__CustomerO__Order__5535A963");

            entity.HasOne(d => d.Product).WithMany(p => p.CustomerOrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CustomerO__Produ__5629CD9C");

            entity.HasOne(d => d.Unit).WithMany(p => p.CustomerOrderItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__CustomerO__UnitI__5812160E");

            entity.HasOne(d => d.Variant).WithMany(p => p.CustomerOrderItems)
                .HasForeignKey(d => d.VariantId)
                .HasConstraintName("FK__CustomerO__Varia__571DF1D5");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.CustomerOrderItems)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__CustomerO__Wareh__5EBF139D");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PK__Invoices__D796AAD5E56084D5");

            entity.HasIndex(e => e.OrderId, "UQ__Invoices__C3905BAE123F25B6").IsUnique();

            entity.Property(e => e.InvoiceId)
                .ValueGeneratedNever()
                .HasColumnName("InvoiceID");
            entity.Property(e => e.Costs).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Profit).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Order).WithOne(p => p.Invoice)
                .HasForeignKey<Invoice>(d => d.OrderId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Invoices__OrderI__5BE2A6F2");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDA525BE12");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("ProductID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");

            entity.HasOne(d => d.Unit).WithMany(p => p.Products)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__Products__UnitID__3F466844");
        });

        modelBuilder.Entity<ProductVariant>(entity =>
        {
            entity.HasKey(e => e.VariantId).HasName("PK__ProductV__0EA233E449B65408");

            entity.Property(e => e.VariantId)
                .ValueGeneratedNever()
                .HasColumnName("VariantID");
            entity.Property(e => e.PriceAdjustment).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.VariantName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Product).WithMany(p => p.ProductVariants)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductVa__Produ__4222D4EF");

            entity.HasOne(d => d.Unit).WithMany(p => p.ProductVariants)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__ProductVa__UnitI__4316F928");
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasKey(e => e.UnitId).HasName("PK__Units__44F5EC9573179FED");

            entity.Property(e => e.UnitId)
                .ValueGeneratedNever()
                .HasColumnName("UnitID");
            entity.Property(e => e.UnitName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC48073466");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.PasswordHash)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vendor>(entity =>
        {
            entity.HasKey(e => e.VendorId).HasName("PK__Vendors__FC8618D350979CB3");

            entity.Property(e => e.VendorId)
                .ValueGeneratedNever()
                .HasColumnName("VendorID");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LandlinePhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MobilePhone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Warehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId).HasName("PK__Warehous__2608AFD907B675B5");

            entity.Property(e => e.WarehouseId)
                .ValueGeneratedNever()
                .HasColumnName("WarehouseID");
            entity.Property(e => e.Location)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WarehouseOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Warehous__C3905BAF9A60E11C");

            entity.Property(e => e.OrderId)
                .ValueGeneratedNever()
                .HasColumnName("OrderID");
            entity.Property(e => e.OrderDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.VendorId).HasColumnName("VendorID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.User).WithMany(p => p.WarehouseOrders)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Warehouse__UserI__46E78A0C");

            entity.HasOne(d => d.Vendor).WithMany(p => p.WarehouseOrders)
                .HasForeignKey(d => d.VendorId)
                .HasConstraintName("FK__Warehouse__Vendo__47DBAE45");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehouseOrders)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__Warehouse__Wareh__619B8048");
        });

        modelBuilder.Entity<WarehouseOrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PK__Warehous__57ED06A198F54D90");

            entity.Property(e => e.OrderItemId)
                .ValueGeneratedNever()
                .HasColumnName("OrderItemID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.VariantId).HasColumnName("VariantID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Order).WithMany(p => p.WarehouseOrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Warehouse__Order__4AB81AF0");

            entity.HasOne(d => d.Product).WithMany(p => p.WarehouseOrderItems)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Warehouse__Produ__4BAC3F29");

            entity.HasOne(d => d.Unit).WithMany(p => p.WarehouseOrderItems)
                .HasForeignKey(d => d.UnitId)
                .HasConstraintName("FK__Warehouse__UnitI__4D94879B");

            entity.HasOne(d => d.Variant).WithMany(p => p.WarehouseOrderItems)
                .HasForeignKey(d => d.VariantId)
                .HasConstraintName("FK__Warehouse__Varia__4CA06362");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.WarehouseOrderItems)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__Warehouse__Wareh__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
