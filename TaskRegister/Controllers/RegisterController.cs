using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskRegister.Models;
using TaskRegister.Models.Repositories;

namespace TaskRegister.Controllers
{
    public class RegisterController : Controller
    {
        public readonly IRepository<User> repository;

        public RegisterController(IRepository<User> _repository)
        {
            this.repository = _repository;
        }
        // GET: RegisterController
        public ActionResult Index()
        {
            var users = repository.List();

            return View(users);
        }

        // GET: RegisterController/Details/5
        public ActionResult Details(int id)
        {
            var users = repository.Find(id);

            return View(users);
        }

        // GET: RegisterController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User model , int id )
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    
                    repository.Add(model ,1);
                    var newlyCreatedId = model.user_ID;
                    return RedirectToAction(nameof(Details), new { id = newlyCreatedId });
                }
                catch
                {
                    return View();
                }
            }
                ModelState.AddModelError("", "Achtung !");
                return View("Create", new User());

            }

        // GET: RegisterController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegisterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
