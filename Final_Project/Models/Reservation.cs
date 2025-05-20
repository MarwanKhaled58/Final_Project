using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [Required]
        public int BranchID { get; set; }
        //public int TableID { get; set; }
        //public string TableStatus { get; set; }
        [Required]
        public int CustomerID { get; set; }

        [Required]
        public DateTime ReservationTime { get; set; }

        [Required]
        public int NumberOfGuests { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } // Confirmed, Cancelled, Completed, etc.

        // Navigation properties
        [ForeignKey("BranchID")]
        public virtual Branch Branch { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }


}

