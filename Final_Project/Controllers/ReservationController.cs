using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Final_Project.Controllers
{
    public class ReservationController : Controller
    {
        private readonly RestaurantContext _context;

        public ReservationController(RestaurantContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Reservation> allReservations = _context.Reservations
                .Include(r => r.Table)
                .Include(r => r.Customer)
                .ToList();
            return View("Index",allReservations);
        }

        public IActionResult Details(int id)
        {
            Reservation reservation = _context.Reservations
                .Include(r => r.Table)
                .Include(r => r.Customer)
                .FirstOrDefault(r => r.ReservationID == id);
            if (reservation == null)
                return NotFound();
            return View(reservation);
        }

        public IActionResult AddReservation()
        {
            var makeReservation = new MakeReservation
            {
                //AvailableTables = _context.Tables
                //    .Where(t => t.Status == "Available")
                //    .ToList()
            };
            return View(makeReservation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveReservation(MakeReservation makeReservation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //if (makeReservation.IsIndoor==true &&makeReservation.NumberOfGuests==)
                    //{
                    
                    //}


                    //Table table = _context.Tables
                    //    .FirstOrDefault(t => 
                    //                       t.Capacity >= makeReservation.NumberOfGuests
                    //                      && t.Location == (makeReservation.IsIndoor ? "Indoor" : "Outdoor")
                    //                      && t.Status == "Available");

                    //makeReservation.TableID = table.TableID;

                    
                    Table table = _context.Tables
                        .FirstOrDefault(t => t.TableID == makeReservation.TableID
                                          && t.Capacity >= makeReservation.NumberOfGuests
                                          && t.Location == (makeReservation.IsIndoor ? "Indoor" : "Outdoor")
                                          && t.Status == "Available");

                    if (table == null)
                    {
                        ModelState.AddModelError("", "No suitable table available for the selected criteria.");
                        makeReservation.AvailableTables = _context.Tables
                            .Where(t => t.Status == "Available")
                            .ToList();
                        return View("AddReservation", makeReservation);
                        }

                    // Check for reservation conflicts
                    bool hasConflict = _context.Reservations
                        .Any(r => r.TableID == table.TableID
                               && r.ReservationTime == makeReservation.ReservationTime
                               && r.Status == "Confirmed");
                    if (hasConflict)
                    {
                        ModelState.AddModelError("", "The selected table is already reserved at this time.");
                        makeReservation.AvailableTables = _context.Tables
                            .Where(t => t.Status == "Available")
                            .ToList();
                        return View("AddReservation", makeReservation);
                        }
                  
                    // Create reservation
                    Reservation reservation = new()
                    {
                        CustomerID = makeReservation.CustomerID,
                        ReservationTime = makeReservation.ReservationTime,
                        NumberOfGuests = makeReservation.NumberOfGuests,
                        Status = "Confirmed",
                        TableID = table.TableID
                    };

                    // Update table status
                    table.Status = "Reserved";

                    _context.Reservations.Add(reservation);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            makeReservation.AvailableTables = _context.Tables
                .Where(t => t.Status == "Available")
                .ToList();
            return View("AddReservation", makeReservation);
        }

        public IActionResult EditReservation(int id)
        {
            Reservation reservation = _context.Reservations
                .Include(r => r.Table)
                .FirstOrDefault(r => r.ReservationID == id);
            if (reservation == null)
                return NotFound();

            var editReservation = new MakeReservation
            {
                ReservationID = reservation.ReservationID,
                CustomerID = reservation.CustomerID,
                ReservationTime = reservation.ReservationTime,
                NumberOfGuests = reservation.NumberOfGuests,
                IsIndoor = reservation.Table.Location == "Indoor",
                TableID = reservation.TableID,
                Status = reservation.Status,
                AvailableTables = _context.Tables
                    .Where(t => t.Status == "Available" || t.TableID == reservation.TableID)
                    .ToList()
            };

            return View("EditReservation", editReservation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEditReservation(MakeReservation editReservation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Reservation reservation = _context.Reservations
                        .Include(r => r.Table)
                        .FirstOrDefault(r => r.ReservationID == editReservation.ReservationID);
                    if (reservation == null)
                        return NotFound();

                    // Find a suitable table
                    Table table = _context.Tables
                        .FirstOrDefault(t => t.TableID == editReservation.TableID
                                          && t.Capacity >= editReservation.NumberOfGuests
                                          && t.Location == (editReservation.IsIndoor ? "Indoor" : "Outdoor")
                                          && (t.Status == "Available" || t.TableID == reservation.TableID));

                    if (table == null)
                    {
                        ModelState.AddModelError("", "No suitable table available for the selected criteria.");
                        editReservation.AvailableTables = _context.Tables
                            .Where(t => t.Status == "Available" || t.TableID == reservation.TableID)
                            .ToList();
                        return View("EditReservation", editReservation);
                    }

                    // Check for reservation conflicts
                    bool hasConflict = _context.Reservations
                        .Any(r => r.TableID == table.TableID
                               && r.ReservationTime == editReservation.ReservationTime
                               && r.Status == "Confirmed"
                               && r.ReservationID != editReservation.ReservationID);
                    if (hasConflict)
                    {
                        ModelState.AddModelError("", "The selected table is already reserved at this time.");
                        editReservation.AvailableTables = _context.Tables
                            .Where(t => t.Status == "Available" || t.TableID == reservation.TableID)
                            .ToList();
                        return View("EditReservation", editReservation);
                    }

                    // Update the original table's status
                    if (reservation.TableID != table.TableID)
                    {
                        reservation.Table.Status = "Available";
                    }

                    // Update reservation
                    reservation.CustomerID = editReservation.CustomerID;
                    reservation.ReservationTime = editReservation.ReservationTime;
                    reservation.NumberOfGuests = editReservation.NumberOfGuests;
                    reservation.TableID = table.TableID;
                    reservation.Status = editReservation.Status;

                    // Update new table's status
                    table.Status = "Reserved";

                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                }
            }

            editReservation.AvailableTables = _context.Tables
                .Where(t => t.Status == "Available")
                .ToList();
            return View("EditReservation", editReservation);
                }

        public IActionResult CancelReservation(int id)
        {
            Reservation reservation = _context.Reservations
                .Include(r => r.Table)
                .FirstOrDefault(r => r.ReservationID == id);
            if (reservation == null)
                return NotFound();

            return View(reservation);
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ConfirmCancelReservation(int id)
        {
            try
            {
                Reservation reservation = _context.Reservations
                    .Include(r => r.Table)
                    .FirstOrDefault(r => r.ReservationID == id);
                if (reservation == null)
                    return NotFound();

                // Update reservation status to Canceled
                reservation.Status = "Canceled";

                // Update table status to Available
                reservation.Table.Status = "Available";

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("CancelReservation", _context.Reservations
                    .Include(r => r.Table)
                    .FirstOrDefault(r => r.ReservationID == id));
            }
        }
    }
}
