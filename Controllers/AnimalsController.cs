using COM580Assignment02.Models;
using COM580Assignment02.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace COM580Assignment02.Controllers
{
    public class AnimalsController : Controller
    {
        private IAnimalDataService service;

        public AnimalsController()
        {
            service = new AnimalDataService();
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            List<Animal> animals = (List<Animal>)service.SelectAll();
            return View(animals);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Animal obj)
        {
            if (ModelState.IsValid)
            {
                service.Insert(obj);
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        [HttpGet, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Animal existing = service.SelectByID(id);
            return View(existing);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Animal existing = service.SelectByID(id);
            return View(existing);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Animal obj)
        {
            if (ModelState.IsValid)
            {
                service.Update(obj);
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Animal existing = service.SelectByID(id);
            return View(existing);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
