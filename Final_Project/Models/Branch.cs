using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string ContactNumber { get; set; }

        public int ManagerID { get; set; }

        // Navigation properties
        public virtual ICollection<Table> Tables { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }

}
