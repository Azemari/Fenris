using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFenris.Models;

namespace ProjectFenris.Controllers
{
    public class BudgetController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        public BudgetController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // GET: Budget/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Budget/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Budget/CreateIndividual
        public ActionResult CreateIndividual()
        {
            return View();
        }

        // POST: Budget/CreateIndividual
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateIndividual(Budget budget)
        {
            //Get the user ID
            var id = _userManager.GetUserId(User);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BudgetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Budget/Edit/5
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

        // GET: Budget/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Budget/Delete/5
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
