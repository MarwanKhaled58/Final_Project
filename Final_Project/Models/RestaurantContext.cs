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
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<Profile> Profiles { get; set; }
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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-9F3RAET\\SQLEXPRESS;Initial Catalog=FinalDB;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Branches
            modelBuilder.Entity<Branch>().HasData(
                new Branch { BranchID = 1, Name = "Downtown Branch", Address = "123 Main St", ContactNumber = "555-0101", ManagerID = 1 },
                new Branch { BranchID = 2, Name = "Uptown Branch", Address = "456 Oak Ave", ContactNumber = "555-0102", ManagerID = 2 },
                new Branch { BranchID = 3, Name = "Seaside Branch", Address = "789 Beach Rd", ContactNumber = "555-0103", ManagerID = 3 },
                new Branch { BranchID = 4, Name = "City Center Branch", Address = "101 Central Sq", ContactNumber = "555-0104", ManagerID = 4 },
                new Branch { BranchID = 5, Name = "Mall Branch", Address = "202 Mall St", ContactNumber = "555-0105", ManagerID = 5 }
            );

            // Seed Customers
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, Name = "Salma Goda", ContactNumber = "555-0123", Email = "john.doe@example.com", Address = "321 Elm St" },
                new Customer { CustomerID = 2, Name = "Eman", ContactNumber = "555-0124", Email = "jane.smith@example.com", Address = "654 Pine St" },
                new Customer { CustomerID = 3, Name = "Marwan", ContactNumber = "555-0125", Email = "ahmed.ali@example.com", Address = "987 Cedar St" },
                new Customer { CustomerID = 4, Name = "Mostafa", ContactNumber = "555-0126", Email = "sara.hassan@example.com", Address = "147 Maple St" },
                new Customer { CustomerID = 5, Name = "Sama", ContactNumber = "555-0127", Email = "omar.khaled@example.com", Address = "258 Oak St" }
            );

            // Seed FoodCategories
            modelBuilder.Entity<FoodCategory>().HasData(
                new FoodCategory { CategoryID = 1, CategoryName = "Appetizers" },
                new FoodCategory { CategoryID = 2, CategoryName = "Main Course" },
                new FoodCategory { CategoryID = 3, CategoryName = "Desserts" },
                new FoodCategory { CategoryID = 4, CategoryName = "Beverages" },
                new FoodCategory { CategoryID = 5, CategoryName = "Salads" }
            );

            // Seed Ingredients
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient { IngredientID = 1, Name = "Chicken", Quantity = 50 },
                new Ingredient { IngredientID = 2, Name = "Flour", Quantity = 100 },
                new Ingredient { IngredientID = 3, Name = "Chocolate", Quantity = 20 },
                new Ingredient { IngredientID = 4, Name = "Tomato", Quantity = 30 },
                new Ingredient { IngredientID = 5, Name = "Lettuce", Quantity = 40 }
            );

            // Seed Roles
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleID = 1, RoleName = "Manager" },
                new Role { RoleID = 2, RoleName = "Waiter" },
                new Role { RoleID = 3, RoleName = "Chef" },
                new Role { RoleID = 4, RoleName = "Cashier" },
                new Role { RoleID = 5, RoleName = "Host" }
            );

            // Seed Staff
            modelBuilder.Entity<Staff>().HasData(
                new Staff { StaffID = 1, BranchID = 1, Name = "Alice Johnson", ContactNumber = "555-0201", RoleID = 1, Salary = 5000m },
                new Staff { StaffID = 2, BranchID = 2, Name = "Bob Williams", ContactNumber = "555-0202", RoleID = 1, Salary = 5200m },
                new Staff { StaffID = 3, BranchID = 3, Name = "Clara Lee", ContactNumber = "555-0203", RoleID = 1, Salary = 5100m },
                new Staff { StaffID = 4, BranchID = 4, Name = "David Kim", ContactNumber = "555-0204", RoleID = 1, Salary = 5300m },
                new Staff { StaffID = 5, BranchID = 5, Name = "Emma Brown", ContactNumber = "555-0205", RoleID = 1, Salary = 5400m }
            );

            // Seed Tables
            modelBuilder.Entity<Table>().HasData(
                new Table { TableID = 1, BranchID = 1, Capacity = 4, Location = "Indoor", Status = "Available" },
                new Table { TableID = 2, BranchID = 1, Capacity = 6, Location = "Outdoor", Status = "Available" },
                new Table { TableID = 3, BranchID = 2, Capacity = 2, Location = "Indoor", Status = "Occupied" },
                new Table { TableID = 4, BranchID = 3, Capacity = 8, Location = "Terrace", Status = "Available" },
                new Table { TableID = 5, BranchID = 4, Capacity = 4, Location = "Indoor", Status = "Reserved" }
            );

            // Seed Profiles
            modelBuilder.Entity<Profile>().HasData(
                new Profile { ProfileID = 1, CustomerID = 1, DateOfBirth = new DateTime(1990, 5, 15), Gender = "Male", ReceivePromotions = true, RegisteredDate = DateTime.Now, ProfilePictureUrl = "john.jpg" },
                new Profile { ProfileID = 2, CustomerID = 2, DateOfBirth = new DateTime(1985, 8, 22), Gender = "Female", ReceivePromotions = false, RegisteredDate = DateTime.Now, ProfilePictureUrl = "jane.jpg" },
                new Profile { ProfileID = 3, CustomerID = 3, DateOfBirth = new DateTime(1992, 3, 10), Gender = "Male", ReceivePromotions = true, RegisteredDate = DateTime.Now, ProfilePictureUrl = null },
                new Profile { ProfileID = 4, CustomerID = 4, DateOfBirth = new DateTime(1995, 11, 30), Gender = "Female", ReceivePromotions = true, RegisteredDate = DateTime.Now, ProfilePictureUrl = "sara.jpg" },
                new Profile { ProfileID = 5, CustomerID = 5, DateOfBirth = new DateTime(1988, 7, 5), Gender = "Male", ReceivePromotions = false, RegisteredDate = DateTime.Now, ProfilePictureUrl = null }
            );

            // Seed Reservations
            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationID = 1, BranchID = 1, CustomerID = 1, ReservationTime = DateTime.Now.AddDays(1), NumberOfGuests = 4, Status = "Confirmed" },
                new Reservation { ReservationID = 2, BranchID = 2, CustomerID = 2, ReservationTime = DateTime.Now.AddDays(2), NumberOfGuests = 6, Status = "Pending" },
                new Reservation { ReservationID = 3, BranchID = 3, CustomerID = 3, ReservationTime = DateTime.Now.AddDays(3), NumberOfGuests = 2, Status = "Confirmed" },
                new Reservation { ReservationID = 4, BranchID = 4, CustomerID = 4, ReservationTime = DateTime.Now.AddDays(4), NumberOfGuests = 8, Status = "Cancelled" },
                new Reservation { ReservationID = 5, BranchID = 5, CustomerID = 5, ReservationTime = DateTime.Now.AddDays(5), NumberOfGuests = 4, Status = "Confirmed" }
            );

            // Seed FoodItems
            modelBuilder.Entity<FoodItem>().HasData(
                new FoodItem { FoodItemID = 1, Name = "Spring Rolls", Price = 5.99m, FoodCategoryID = 1, Description = "Crispy vegetable rolls" },
                new FoodItem { FoodItemID = 2, Name = "Grilled Chicken", Price = 12.99m, FoodCategoryID = 2, Description = "Juicy grilled chicken breast" },
                new FoodItem { FoodItemID = 3, Name = "Chocolate Cake", Price = 4.99m, FoodCategoryID = 3, Description = "Rich chocolate cake" },
                new FoodItem { FoodItemID = 4, Name = "Iced Coffee", Price = 3.99m, FoodCategoryID = 4, Description = "Chilled coffee with milk" },
                new FoodItem { FoodItemID = 5, Name = "Caesar Salad", Price = 6.99m, FoodCategoryID = 5, Description = "Fresh salad with Caesar dressing" }
            );

            // Seed Orders
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderID = 1, BranchID = 1, CustomerID = 1, TableID = 1, OrderTime = DateTime.Now, Status = "Completed", TotalAmount = 18.98m, PaymentMethod = "Credit Card" },
                new Order { OrderID = 2, BranchID = 2, CustomerID = 2, TableID = 3, OrderTime = DateTime.Now, Status = "Pending", TotalAmount = 17.98m, PaymentMethod = "Cash" },
                new Order { OrderID = 3, BranchID = 3, CustomerID = 3, TableID = null, OrderTime = DateTime.Now, Status = "Completed", TotalAmount = 10.98m, PaymentMethod = "Credit Card" },
                new Order { OrderID = 4, BranchID = 4, CustomerID = 4, TableID = 4, OrderTime = DateTime.Now, Status = "Cancelled", TotalAmount = 25.97m, PaymentMethod = "Cash" },
                new Order { OrderID = 5, BranchID = 5, CustomerID = 5, TableID = 5, OrderTime = DateTime.Now, Status = "Completed", TotalAmount = 13.98m, PaymentMethod = "Credit Card" }
            );

    }


}
