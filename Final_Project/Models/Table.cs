using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Table
    {
        [Key]
        public int TableID { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be at least 1")]
        public int Capacity { get; set; }

        [Required]
        [ValidLocation(ErrorMessage = "Location must be either 'Indoor' or 'Outdoor'")]
        public string Location { get; set; } = "Indoor"; // Default to Indoor

        [Required]
        public string Status { get; set; } = "Available"; // Default to Available

        // Navigation property
        public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    }

    public class ValidLocationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string location && (location == "Indoor" || location == "Outdoor"))
                return ValidationResult.Success;
            return new ValidationResult(ErrorMessage);
        }
    }
}