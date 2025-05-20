using Microsoft.AspNetCore.Mvc;
using Final_Project.Models;
using Final_Project.ViewModels;
namespace Final_Project.Controllers
{
    public class OrderController : Controller
    {
        RestaurantContext context=new();
        public IActionResult Index()
        {
           List<Order> orders=context.Orders.ToList();
            return View();
        }
    }
}
