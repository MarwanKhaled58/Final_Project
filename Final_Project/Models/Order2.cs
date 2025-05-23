using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Order2
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }  // Changed from string to int
        public string? TableID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerNumber { get; set; }
        public float TotalPrice { get; set; }
        public List<CustomizedOrder> CustomizedOrders { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}