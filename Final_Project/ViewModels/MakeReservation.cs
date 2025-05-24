
﻿using System.ComponentModel.DataAnnotations;
using Final_Project.Models;
using System.Collections.Generic;
namespace Final_Project.ViewModels
{
    public class MakeReservation
    {

        public int ReservationID { get; set; }

        [Required(ErrorMessage = "Customer ID is required")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Reservation time is required")]
        [FutureDate(ErrorMessage = "Reservation time must be in the future")]
        public DateTime ReservationTime { get; set; }

        [Required(ErrorMessage = "Number of guests is required")]
        [Range(1, 50, ErrorMessage = "Number of guests must be between 1 and 50")]
        public int NumberOfGuests { get; set; }
        public Table Table { get; set; }
        
        public bool IsIndoor { get; set; } // Still used for UI input (true for Indoor, false for Outdoor)

        //[Required(ErrorMessage = "Table ID is required")]
        public int TableID { get; set; }

        [Required]
        public string Status { get; set; } = "Pending";

        public IEnumerable<Table> AvailableTables { get; set; } = new List<Table>();
    }
}

