using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public int Quantity { get; set; }

        [StringLength(255)]
        

        // Navigation properties
        public virtual ICollection<Recipe> Recipes { get; set; }
    }


}
