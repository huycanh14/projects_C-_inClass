namespace WebsiteBanDienThoai.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admins> Admins { get; set; }
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Order_items> Order_items { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product_categories> Product_categories { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brands)
                .HasForeignKey(e => e.brand_id);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.customer_id);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.Order_items)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.order_id);

            modelBuilder.Entity<Product_categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Product_categories)
                .HasForeignKey(e => e.product_category_id);

            modelBuilder.Entity<Products>()
                .Property(e => e.img)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Order_items)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.product_id);
        }
    }
}
