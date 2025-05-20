using System.Linq.Expressions;
using Final_Project.Models;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class ReservationController : Controller
    {
        RestaurantContext context = new();
        public IActionResult Index()
        {
            List<Reservation> AllReservations=context.Reservations.ToList();    

            return View();
        }
        public IActionResult Details(int id)
        {
           Reservation Reservation = context.Reservations.FirstOrDefault(r=>r.ReservationID==id);

            return View();
        }
        public IActionResult AddReservation()
        {
            List<Branch> branches = context.Branches.ToList();
            MakeReservation makeReservation = new();
            //makeReservation.Branches= branches;

            return View("AddReservation", makeReservation);
        }
        public IActionResult SaveReservation(MakeReservation makeReservation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Table tableToBeAssigned;
                    Reservation reservation = new();
                    reservation.BranchID=makeReservation.BranchID;
                    reservation.CustomerID = makeReservation.CustomerID;
                    reservation.ReservationTime = makeReservation.ReservationTime;
                    reservation.NumberOfGuests = makeReservation.NumberOfGuests;
                    reservation.Status = "Confirmed";
                    
                    if(makeReservation.Indoor_Outdoor == true)
                    {
                        switch (makeReservation.NumberOfGuests)
                        {
                            case 1:
                                //reservation.TableID = 1;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 2:
                                //reservation.TableID = 2;
                                //reservation.TableStatus = "Reserved";

                                break;
                            case 3:
                                //reservation.TableID = 3;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 4:
                                //reservation.TableID = 4;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 5:
                                //reservation.TableID = 5;
                                //reservation.TableStatus = "Reserved";
                                break;
                        }
                    }
                    else
                    {
                        switch (makeReservation.NumberOfGuests)
                        {
                            case 1:
                                //reservation.TableID = 1;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 2:
                                //reservation.TableID = 2;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 3:
                                //reservation.TableID = 3;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 4:
                                //reservation.TableID = 4;
                                //reservation.TableStatus = "Reserved";
                                break;
                            case 5:
                                //reservation.TableID = 5;
                                //reservation.TableStatus = "Reserved";
                                break;
                        }
                    }
                  
                        context.SaveChanges();
                    return RedirectToAction("........");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Key", ex.InnerException.Message);
                }
            }
            //makeReservation.Branches=context.Branches.ToList();
            return View("AddReservation", makeReservation);
        }
        public IActionResult EditReservation(int id)
        {
            Reservation reservation = context.Reservations.FirstOrDefault(r => r.ReservationID==id);
            MakeReservation editreservation= new();
            //Table table = context.Tables.FirstOrDefault(t=>t.TableID==reservation.TableID);

            editreservation.BranchID = reservation.BranchID;
            editreservation.CustomerID = reservation.CustomerID;
            editreservation.ReservationTime = reservation.ReservationTime;
            editreservation.NumberOfGuests = reservation.NumberOfGuests;
            //editreservation.Indoor_Outdoor = Table.location;
            //editreservation.TableID = reservation.TableID;
            //editreservation.TableStatus = reservation.tablestatus;
            editreservation.Status = reservation.Status;


            return View("EditReservation", editreservation);
        }
        public IActionResult SaveEditReservation(MakeReservation editreservation)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    Reservation reservation=context.Reservations.FirstOrDefault(r=>r.ReservationID==editreservation.Id);
                    //Table table = context.Tables.FirstOrDefault(t=>t.TableID==reservation.TableID);


                    reservation.BranchID = editreservation.BranchID;
                    reservation.CustomerID = editreservation.CustomerID;
                    reservation.ReservationID = editreservation.Id;
                    reservation.NumberOfGuests = editreservation.NumberOfGuests;
                    //reservation.tableid = editreservation.TableID;
                    //reservation.tablestatus = editreservation.TableStatus;
                    reservation.BranchID = editreservation.BranchID;
                    reservation.Status = editreservation.Status;
                    reservation.ReservationTime = editreservation.ReservationTime;
                    //Table.location = editreservation.Indoor_Outdoor;

                    context.SaveChanges();  


                    return RedirectToAction("........");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("Key", ex.InnerException.Message);
                }
            }
            //Table table = context.Tables.FirstOrDefault(t=>t.TableID==reservation.TableID);
            //editreservation.Indoor_Outdoor = table.location;
            return View("EditNutrition", editreservation);


        }
    }
}
