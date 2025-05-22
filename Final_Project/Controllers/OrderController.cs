using Final_Project.Models;
using Final_Project.Repositories;
using Final_Project.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository orderRepo;
        IFoodItemRepository foodItemRepo;
        IFoodCategoryRepository foodCategoryRepo;
        IBranchRepository branchRepo;

        public OrderController(IOrderRepository _orderRepo,
                              IFoodItemRepository _foodItemRepo,
                              IFoodCategoryRepository _foodCategoryRepo,
                              IBranchRepository _branchRepo)
        {
            orderRepo = _orderRepo;
            foodItemRepo = _foodItemRepo;
            foodCategoryRepo = _foodCategoryRepo;
            branchRepo = _branchRepo;
        }

        public IActionResult Index()
        {
            List<Order> Orders = orderRepo.GetAll("Customer,Branch");
            return View("Index", Orders);
        }

        public IActionResult Menu()
        {
            List<FoodCategory> Categories = foodCategoryRepo.GetAll("FoodItems");
            return View("Menu", Categories);
        }

        public IActionResult GetFoodItemsByCategory(int categoryId)
        {
            List<FoodItem> FoodItems = (List<FoodItem>)foodItemRepo.GetFoodItemsByCategory(categoryId);
            return Json(FoodItems);
        }

        public IActionResult Create()
        {
            CreateOrderViewModel OrderVM = new CreateOrderViewModel();
            OrderVM.AvailableFoodItems = foodItemRepo.GetAll("FoodCategory");
            OrderVM.AvailableBranches = branchRepo.GetAll();
            OrderVM.OrderItems = new List<OrderItemViewModel>();

            ViewBag.BranchID = new SelectList(branchRepo.GetAll(), "BranchID", "Name");

            return View("Create", OrderVM);
        }

        [HttpPost]
        public IActionResult SaveNew(CreateOrderViewModel NewOrder)
        {
            if (ModelState.IsValid == true)
            {
                Order Order = new Order
                {
                    CustomerID = NewOrder.CustomerID,
                    BranchID = NewOrder.BranchID,
                    TableID = NewOrder.TableID,
                    OrderTime = DateTime.Now,
                    Status = "Pending",
                    TotalAmount = NewOrder.OrderItems.Sum(item => item.Price * item.Quantity),
                    PaymentMethod = NewOrder.PaymentMethod
                };

                List<OrderItem> OrderItems = new List<OrderItem>();
                foreach (var item in NewOrder.OrderItems)
                {
                    OrderItems.Add(new OrderItem
                    {
                        FoodItemID = item.FoodItemID,
                        Quantity = item.Quantity,
                        Price = item.Price
                    });
                }

                orderRepo.AddOrderWithItems(Order, OrderItems);

                return RedirectToAction("Index");
            }

            NewOrder.AvailableFoodItems = foodItemRepo.GetAll("FoodCategory");
            NewOrder.AvailableBranches = branchRepo.GetAll();
            ViewBag.BranchID = new SelectList(branchRepo.GetAll(), "BranchID", "Name", NewOrder.BranchID);

            return View("Create", NewOrder);
        }

        public IActionResult GetFoodItemDetails(int id)
        {
            FoodItem FoodItem = foodItemRepo.GetById(id);
            return Json(new { id = FoodItem.FoodItemID, name = FoodItem.Name, price = FoodItem.Price });
        }
    }
}