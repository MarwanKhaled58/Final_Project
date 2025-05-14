using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        // Navigation properties
        [ForeignKey("CategoryID")]
        public virtual FoodCategory Category { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Nutrition Nutrition { get; set; }
    }

}

