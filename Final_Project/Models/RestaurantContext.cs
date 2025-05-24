using Microsoft.EntityFrameworkCore;
using Final_Project.Models;

namespace Final_Project.Models
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Branch2> Branches2 { get; set; }
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

        public DbSet<Order2> Orders2 { get; set; }
        public DbSet<CustomizedOrder> CustomizedOrders { get; set; }



        public RestaurantContext() : base()
        {
        }

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=DESKTOP-5GF48P6\\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=False");
        //    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // Configure Branch2
            modelBuilder.Entity<Branch2>()
                .Property(b => b.Location)
                .HasColumnType("geography");
            modelBuilder.Entity<Branch2>()
                .Property(b => b.Location)
                .HasComputedColumnSql("geography::Point(Latitude, Longitude, 4326)", stored: true);
            modelBuilder.Entity<Branch2>()
                .Property(b => b.Latitude)
                .HasPrecision(9, 6)
                .IsRequired();
            modelBuilder.Entity<Branch2>()
                .Property(b => b.Longitude)
                .HasPrecision(9, 6)
                .IsRequired();
            modelBuilder.Entity<Branch2>()
                .Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Branch2>()
                .Property(b => b.Address)
                .HasMaxLength(200);



            // Seed Branch2 data
            modelBuilder.Entity<Branch2>().HasData(
                new Branch2 { Id = 1, Name = "Downtown Branch", Address = "123 Main St", Latitude = 40.7128, Longitude = -74.0060 },
                new Branch2 { Id = 2, Name = "Uptown Branch", Address = "456 Oak Ave", Latitude = 40.7831, Longitude = -73.9712 },
                new Branch2 { Id = 3, Name = "Seaside Branch", Address = "789 Beach Rd", Latitude = 40.6782, Longitude = -73.9442 },
                new Branch2 { Id = 4, Name = "City Center Branch", Address = "101 Central Sq", Latitude = 40.7484, Longitude = -73.9857 },
                new Branch2 { Id = 5, Name = "Mall Branch", Address = "202 Mall St", Latitude = 40.7589, Longitude = -73.9891 }
            );
        }
    }
}
        

    



