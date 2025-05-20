using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Migrations
{
    /// <inheritdoc />
    public partial class name2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchID", "Address", "ContactNumber", "ManagerID", "Name" },
                values: new object[,]
                {
                    { 1, "123 Main St", "555-0101", 1, "Downtown Branch" },
                    { 2, "456 Oak Ave", "555-0102", 2, "Uptown Branch" },
                    { 3, "789 Beach Rd", "555-0103", 3, "Seaside Branch" },
                    { 4, "101 Central Sq", "555-0104", 4, "City Center Branch" },
                    { 5, "202 Mall St", "555-0105", 5, "Mall Branch" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Address", "ContactNumber", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "321 Elm St", "555-0123", "john.doe@example.com", "Salma Goda" },
                    { 2, "654 Pine St", "555-0124", "jane.smith@example.com", "Eman" },
                    { 3, "987 Cedar St", "555-0125", "ahmed.ali@example.com", "Marwan" },
                    { 4, "147 Maple St", "555-0126", "sara.hassan@example.com", "Mostafa" },
                    { 5, "258 Oak St", "555-0127", "omar.khaled@example.com", "Sama" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Appetizers" },
                    { 2, "Main Course" },
                    { 3, "Desserts" },
                    { 4, "Beverages" },
                    { 5, "Salads" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientID", "Name", "Quantity" },
                values: new object[,]
                {
                    { 1, "Chicken", 50 },
                    { 2, "Flour", 100 },
                    { 3, "Chocolate", 20 },
                    { 4, "Tomato", 30 },
                    { 5, "Lettuce", 40 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleID", "RoleName" },
                values: new object[,]
                {
                    { 1, "Manager" },
                    { 2, "Waiter" },
                    { 3, "Chef" },
                    { 4, "Cashier" },
                    { 5, "Host" }
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemID", "Description", "FoodCategoryID", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Crispy vegetable rolls", 1, "Spring Rolls", 5.99m },
                    { 2, "Juicy grilled chicken breast", 2, "Grilled Chicken", 12.99m },
                    { 3, "Rich chocolate cake", 3, "Chocolate Cake", 4.99m },
                    { 4, "Chilled coffee with milk", 4, "Iced Coffee", 3.99m },
                    { 5, "Fresh salad with Caesar dressing", 5, "Caesar Salad", 6.99m }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "BranchID", "CustomerID", "OrderTime", "PaymentMethod", "Status", "TableID", "TotalAmount" },
                values: new object[] { 3, 3, 3, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8713), "Credit Card", "Completed", null, 10.98m });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "ProfileID", "CustomerID", "DateOfBirth", "Gender", "ProfilePictureUrl", "ReceivePromotions", "RegisteredDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", "john.jpg", true, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8561) },
                    { 2, 2, new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "jane.jpg", false, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8611) },
                    { 3, 3, new DateTime(1992, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", null, true, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8614) },
                    { 4, 4, new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Female", "sara.jpg", true, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8616) },
                    { 5, 5, new DateTime(1988, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Male", null, false, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8619) }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationID", "BranchID", "CustomerID", "NumberOfGuests", "ReservationTime", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, 4, new DateTime(2025, 5, 17, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8645), "Confirmed" },
                    { 2, 2, 2, 6, new DateTime(2025, 5, 18, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8650), "Pending" },
                    { 3, 3, 3, 2, new DateTime(2025, 5, 19, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8652), "Confirmed" },
                    { 4, 4, 4, 8, new DateTime(2025, 5, 20, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8654), "Cancelled" },
                    { 5, 5, 5, 4, new DateTime(2025, 5, 21, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8656), "Confirmed" }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffID", "BranchID", "ContactNumber", "Name", "RoleID", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "555-0201", "Alice Johnson", 1, 5000m },
                    { 2, 2, "555-0202", "Bob Williams", 1, 5200m },
                    { 3, 3, "555-0203", "Clara Lee", 1, 5100m },
                    { 4, 4, "555-0204", "David Kim", 1, 5300m },
                    { 5, 5, "555-0205", "Emma Brown", 1, 5400m }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableID", "BranchID", "Capacity", "Location", "Status" },
                values: new object[,]
                {
                    { 1, 1, 4, "Indoor", "Available" },
                    { 2, 1, 6, "Outdoor", "Available" },
                    { 3, 2, 2, "Indoor", "Occupied" },
                    { 4, 3, 8, "Terrace", "Available" },
                    { 5, 4, 4, "Indoor", "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "Nutritions",
                columns: new[] { "NutritionID", "Calories", "Carbohydrates", "Fat", "Fiber", "FoodItemID", "Protein", "Sugar" },
                values: new object[,]
                {
                    { 1, 200, 30m, 10m, 2m, 1, 5m, 5m },
                    { 2, 300, 10m, 15m, 1m, 2, 25m, 2m },
                    { 3, 400, 50m, 20m, 3m, 3, 5m, 30m },
                    { 4, 150, 20m, 5m, 0m, 4, 3m, 15m },
                    { 5, 180, 15m, 8m, 4m, 5, 6m, 3m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemID", "FoodItemID", "OrderID", "Price", "Quantity" },
                values: new object[] { 4, 4, 3, 3.99m, 3 });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderID", "BranchID", "CustomerID", "OrderTime", "PaymentMethod", "Status", "TableID", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8706), "Credit Card", "Completed", 1, 18.98m },
                    { 2, 2, 2, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8710), "Cash", "Pending", 3, 17.98m },
                    { 4, 4, 4, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8716), "Cash", "Cancelled", 4, 25.97m },
                    { 5, 5, 5, new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8718), "Credit Card", "Completed", 5, 13.98m }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "Amount", "OrderID", "PaymentMethod", "PaymentTime" },
                values: new object[] { 3, 10m, 3, "Credit Card", new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeID", "FoodItemID", "IngredientID", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 2, 0.1m },
                    { 2, 2, 1, 0.2m },
                    { 3, 3, 3, 0.15m },
                    { 4, 4, 4, 0.05m },
                    { 5, 5, 5, 0.3m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemID", "FoodItemID", "OrderID", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 5.99m, 2 },
                    { 2, 2, 1, 12.99m, 1 },
                    { 3, 3, 2, 4.99m, 2 },
                    { 5, 5, 4, 6.99m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentID", "Amount", "OrderID", "PaymentMethod", "PaymentTime" },
                values: new object[,]
                {
                    { 1, 18m, 1, "Credit Card", new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8892) },
                    { 2, 17m, 2, "Cash", new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8896) },
                    { 4, 25m, 4, "Cash", new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8900) },
                    { 5, 13m, 5, "Credit Card", new DateTime(2025, 5, 16, 20, 33, 31, 318, DateTimeKind.Local).AddTicks(8901) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "NutritionID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "NutritionID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "NutritionID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "NutritionID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nutritions",
                keyColumn: "NutritionID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "OrderItemID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "ProfileID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "StaffID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "CategoryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchID",
                keyValue: 4);
        }
    }
}
