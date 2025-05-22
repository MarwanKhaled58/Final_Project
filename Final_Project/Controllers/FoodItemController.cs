using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Controllers
{
    public class FoodItemController : Controller
    {
        IFoodItemRepository foodItemRepo;
        IFoodCategoryRepository foodCategoryRepo;

        public FoodItemController(IFoodItemRepository _foodItemRepo,
                                 IFoodCategoryRepository _foodCategoryRepo)
        {
            foodItemRepo = _foodItemRepo;
            foodCategoryRepo = _foodCategoryRepo;
        }

        public IActionResult Index()
        {
            List<FoodItem> FoodItemList = foodItemRepo.GetAll();
            return View("Index", FoodItemList);
        }

        public IActionResult Details(int id)
        {
            FoodItem FoodItem = foodItemRepo.GetById(id);
            if (FoodItem == null)
            {
                return NotFound();
            }
            return View("Details", FoodItem);
        }

        public IActionResult Create()
        {
            ViewBag.FoodCategoryID = new SelectList(foodCategoryRepo.GetAll(), "CategoryID", "CategoryName");
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(FoodItem foodItem)
        {
            if (ModelState.IsValid == true)
            {
                foodItemRepo.Add(foodItem);
                foodItemRepo.Save();
                return RedirectToAction("Index");
            }
            ViewBag.FoodCategoryID = new SelectList(foodCategoryRepo.GetAll(), "CategoryID", "CategoryName", foodItem.FoodCategoryID);
            return View("Create", foodItem);
        }

        public IActionResult Edit(int id)
        {
            FoodItem FoodItem = foodItemRepo.GetById(id);
            if (FoodItem == null)
            {
                return NotFound();
            }
            ViewBag.FoodCategoryID = new SelectList(foodCategoryRepo.GetAll(), "CategoryID", "CategoryName", FoodItem.FoodCategoryID);
            return View("Edit", FoodItem);
        }

        [HttpPost]
        public IActionResult Edit(FoodItem foodItem)
        {
            if (ModelState.IsValid == true)
            {
                foodItemRepo.Update(foodItem);
                foodItemRepo.Save();
                return RedirectToAction("Index");
            }
            ViewBag.FoodCategoryID = new SelectList(foodCategoryRepo.GetAll(), "CategoryID", "CategoryName", foodItem.FoodCategoryID);
            return View("Edit", foodItem);
        }

        public IActionResult Delete(int id)
        {
            FoodItem FoodItem = foodItemRepo.GetById(id);
            if (FoodItem == null)
            {
                return NotFound();
            }
            return View("Delete", FoodItem);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            foodItemRepo.Delete(id);
            foodItemRepo.Save();
            return RedirectToAction("Index");
        }
    }
}