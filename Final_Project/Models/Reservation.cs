using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [Required]


        public int BranchID { get; set; }
        public int TableID { get; set; }
        //public string TableStatus { get; set; }
        [Required]

        public int CustomerID { get; set; }

        [Required]
        [FutureDate(ErrorMessage = "Reservation time must be in the future")]
        public DateTime ReservationTime { get; set; }

        [Required]
        [Range(1, 50, ErrorMessage = "Number of guests must be between 1 and 50")]
        public int NumberOfGuests { get; set; }
     

        [Required]
        public string Status { get; set; } = "Pending"; // Default to Pending

        // Navigation properties
        [ForeignKey("TableID")]
     
        public virtual Table Table { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }

    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime date && date > DateTime.Now)
                return ValidationResult.Success;
            return new ValidationResult(ErrorMessage);
        }
    }
}