using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order2> Orders_2 { get; set; }
        public DbSet<CustomizedOrder> CustomOrders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Unit> Units { get; set; }

        public RestaurantContext() : base()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5GF48P6\\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure composite primary key for CustomizedOrder
            modelBuilder.Entity<CustomizedOrder>()
                .HasKey(co => new { co.OrderID, co.UnitID });

            // Configure the relationships for CustomizedOrder
            modelBuilder.Entity<CustomizedOrder>()
                .HasOne(co => co.Order)
                .WithMany(o => o.CustomizedOrders)
                .HasForeignKey(co => co.OrderID);

            modelBuilder.Entity<CustomizedOrder>()
                .HasOne(co => co.Unit)
                .WithMany(u => u.CustomizedOrders)
                .HasForeignKey(co => co.UnitID);

            // Configure decimal precision for all decimal properties

            // FoodItem
            modelBuilder.Entity<FoodItem>()
                .Property(f => f.Price)
                .HasPrecision(18, 2);

            // Nutrition
            modelBuilder.Entity<Nutrition>()
                .Property(n => n.Carbohydrates)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Nutrition>()
                .Property(n => n.Fat)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Nutrition>()
                .Property(n => n.Fiber)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Nutrition>()
                .Property(n => n.Protein)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Nutrition>()
                .Property(n => n.Sugar)
                .HasPrecision(18, 2);

            // Order
            modelBuilder.Entity<Order>()
                .Property(o => o.TotalAmount)
                .HasPrecision(18, 2);

            // OrderItem
            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Price)
                .HasPrecision(18, 2);

            // Payment
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2);

            // Recipe
            modelBuilder.Entity<Recipe>()
                .Property(r => r.Quantity)
                .HasPrecision(18, 4); // More decimal places for precise measurements

            // Staff
            modelBuilder.Entity<Staff>()
                .Property(s => s.Salary)
                .HasPrecision(18, 2);

            // Unit (if it has a Price property)
            modelBuilder.Entity<Unit>()
                .Property(u => u.Price)
                .HasPrecision(18, 2);

            // SEED DATA REMOVED - Already exists in database from previous migrations
            // To avoid primary key constraint violations
        }
    }
}