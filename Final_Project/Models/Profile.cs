using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Profile
    {
        [Key]
        public int ProfileID { get; set; }

        [Required]
        public int CustomerID { get; set; }

 
        public DateTime? DateOfBirth { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public bool ReceivePromotions { get; set; }

        public DateTime RegisteredDate { get; set; }

        [StringLength(255)]
        public string? ProfilePictureUrl { get; set; }

        // Navigation property
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}
