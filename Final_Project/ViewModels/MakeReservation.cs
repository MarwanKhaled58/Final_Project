using Final_Project.Models;

namespace Final_Project.ViewModels
{
    public class MakeReservation
    {
        public int Id { get; set; }
        public int BranchID { get; set; }
        //public List<Branch>? Branches { get; set; }
        public int CustomerID { get; set; }
        public DateTime ReservationTime { get; set; }
        public int NumberOfGuests { get; set; }
        public bool Indoor_Outdoor { get; set; }
        public int TableID { get; set; }

        public bool TableStatus { get; set; }
        public string Status { get; set; } = "Pending";

    }
}
