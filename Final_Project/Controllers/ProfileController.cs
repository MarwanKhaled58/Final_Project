using Final_Project.Models;
using Final_Project.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Final_Project.Controllers
{
    public class ProfileController : Controller
    {
        IProfileRepository ProfileRepo;

        public ProfileController(IProfileRepository profileRepo)
        {
            ProfileRepo = profileRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Profile> profileList = ProfileRepo.GetAll();
            return View("Index", profileList);
        }

        public IActionResult New()
        {
            return View("New");
        }

        [HttpPost]
        public IActionResult SaveNew(Profile profileFromReq)
        {
            if (ModelState.IsValid)
            {
                profileFromReq.RegisteredDate = DateTime.Now;
                ProfileRepo.Add(profileFromReq);
                ProfileRepo.Save();
                return RedirectToAction("Index", "Profile");
            }
            return View("New", profileFromReq);
        }


        public IActionResult Details(int id)
        {
            Profile profile = ProfileRepo.GetById(id);
            if (profile == null)
                return NotFound();

            return View("Details", profile);
        }

        public IActionResult Edit(int id)
        {
            Profile profile = ProfileRepo.GetById(id);
            if (profile == null)
                return NotFound();

            return View("Edit", profile);
        }

        [HttpPost]
        public IActionResult SaveEdit(int id, Profile profileFromReq)
        {
            if (id != profileFromReq.ProfileID)
                return BadRequest();

            if (ModelState.IsValid)
            {
                ProfileRepo.Update(profileFromReq);
                ProfileRepo.Save();
                return RedirectToAction("Index");
            }
            return View("Edit", profileFromReq);
        }


        public IActionResult Delete(int id)
        {
            Profile profile = ProfileRepo.GetById(id);
            if (profile == null)
                return NotFound();

            return View("Delete", profile);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            ProfileRepo.Delete(id);
            ProfileRepo.Save();
            return RedirectToAction("Index");
        }

    }
}