using Microsoft.AspNetCore.Mvc;
using Final_Project.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Final_Project.Controllers
{
    public class FoodItemController : Controller
    {
        RestaurantContext context = new RestaurantContext();

        public IActionResult Index()
        {
            List<FoodItem> foodItemList = context.FoodItems.ToList();
            return View("Index", foodItemList);
        }

        public IActionResult Details(int id)
        {
            var foodItem = context.FoodItems.FirstOrDefault(f => f.FoodItemID == id);
            if (foodItem == null)
            {
                return NotFound();
            }
            return View("Details", foodItem);
        }

        public IActionResult Create()
        {
            ViewBag.FoodCategoryID = new SelectList(context.FoodCategories, "CategoryID", "CategoryName");
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(FoodItem foodItem)
        {
            if (ModelState.IsValid)
            {
                context.FoodItems.Add(foodItem);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FoodCategoryID = new SelectList(context.FoodCategories, "CategoryID", "CategoryName", foodItem.FoodCategoryID);
            return View("Create", foodItem);
        }

        public IActionResult Edit(int id)
        {
            var foodItem = context.FoodItems.FirstOrDefault(f => f.FoodItemID == id);
            if (foodItem == null)
            {
                return NotFound();
            }
            ViewBag.FoodCategoryID = new SelectList(context.FoodCategories, "CategoryID", "CategoryName", foodItem.FoodCategoryID);
            return View("Edit", foodItem);
        }

        [HttpPost]
        public IActionResult Edit(FoodItem foodItem)
        {
            if (ModelState.IsValid)
            {
                context.FoodItems.Update(foodItem);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FoodCategoryID = new SelectList(context.FoodCategories, "CategoryID", "CategoryName", foodItem.FoodCategoryID);
            return View("Edit", foodItem);
        }

        public IActionResult Delete(int id)
        {
            var foodItem = context.FoodItems.FirstOrDefault(f => f.FoodItemID == id);
            if (foodItem == null)
            {
                return NotFound();
            }
            return View("Delete", foodItem);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var foodItem = context.FoodItems.FirstOrDefault(f => f.FoodItemID == id);
            if (foodItem != null)
            {
                context.FoodItems.Remove(foodItem);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
