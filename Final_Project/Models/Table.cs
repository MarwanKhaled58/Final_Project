using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Table
    {

        [Key]
        public int TableID { get; set; }

        [Required]
        public int BranchID { get; set; }

        [Required]
        public int Capacity { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } // Available, Reserved, Occupied, etc.

        // Navigation properties
        [ForeignKey("BranchID")]
        public virtual Branch Branch { get; set; }



    }
}
