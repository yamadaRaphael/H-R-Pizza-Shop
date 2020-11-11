namespace PizzaApplication.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PizzaApplicationEntities : DbContext
    {
        public PizzaApplicationEntities()
            : base("name=PizzaApplicationEntities")
        {
        }

        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Pizza> Pizzas { get; set; }
        public virtual DbSet<PizzaSize> PizzaSizes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerFirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerLastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerPhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.DetailPizzaSize)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.PizzaName)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.PizzaDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .HasMany(e => e.PizzaSizes)
                .WithRequired(e => e.Pizza)
                .HasForeignKey(e => e.SizePizzaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PizzaSize>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<PizzaSize>()
                .HasMany(e => e.OrderDetails)
                .WithRequired(e => e.PizzaSize)
                .HasForeignKey(e => new { e.DetailPizzaId, e.DetailPizzaSize })
                .WillCascadeOnDelete(false);
        }
    }
}
