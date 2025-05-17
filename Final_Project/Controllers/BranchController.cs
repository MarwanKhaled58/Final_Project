using Microsoft.AspNetCore.Mvc;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class BranchController : Controller
    {
        RestaurantContext context = new RestaurantContext();

        public IActionResult Index()
        {
            List<Branch> branchList = context.Branches.ToList();
            return View("Index", branchList);
        }

        public IActionResult Details(int id)
        {
            var branch = context.Branches.FirstOrDefault(b => b.BranchID == id);
            if (branch == null)
            {
                return NotFound();
            }
            return View("Details", branch);
        }

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Branch branch)
        {
            if (ModelState.IsValid)
            {
                context.Branches.Add(branch);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Create", branch);
        }

        public IActionResult Edit(int id)
        {
            var branch = context.Branches.FirstOrDefault(b => b.BranchID == id);
            if (branch == null)
            {
                return NotFound();
            }
            return View("Edit", branch);
        }

        [HttpPost]
        public IActionResult Edit(Branch branch)
        {
            if (ModelState.IsValid)
            {
                context.Branches.Update(branch);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", branch);
        }

        public IActionResult Delete(int id)
        {
            var branch = context.Branches.FirstOrDefault(b => b.BranchID == id);
            if (branch == null)
            {
                return NotFound();
            }
            return View("Delete", branch);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var branch = context.Branches.FirstOrDefault(b => b.BranchID == id);
            if (branch != null)
            {
                context.Branches.Remove(branch);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}