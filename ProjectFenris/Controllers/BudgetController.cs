﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectFenris.Data;
using ProjectFenris.Models;

namespace ProjectFenris.Controllers
{
    public class BudgetController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;
        public BudgetController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
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
            try
            {
                //Get the user ID
                var id = _userManager.GetUserId(User);
                var dto = new Budget
                {
                    Type = BudgetType.Individual,
                    UserId = Guid.Parse(id),
                    Currency = budget.Currency,
                    Allowance = budget.Allowance,
                    Range = budget.Range,
                    Expenditure = budget.Expenditure,
                    Income = budget.Income,
                    Users = 1
                };
                _context.Add(dto);
                _context.SaveChanges();
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
