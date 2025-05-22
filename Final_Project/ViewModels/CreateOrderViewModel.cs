using Final_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.ViewModels
{
    public class CreateOrderViewModel
    {
        public int CustomerID { get; set; }

        [Required]
        public int BranchID { get; set; }

        public int? TableID { get; set; }

        [Required]
        public List<OrderItemViewModel> OrderItems { get; set; }

        public string PaymentMethod { get; set; }

        // For display purposes
        public List<FoodItem> AvailableFoodItems { get; set; }
        public List<Branch> AvailableBranches { get; set; }
    }

    public class OrderItemViewModel
    {
        public int FoodItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}