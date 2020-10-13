using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using ProjectFenris.Data;
using ProjectFenris.Models;

namespace ProjectFenris.Controllers
{
    public class HomeController : Controller
    {
        public readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger,
            ApplicationDbContext context, 
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            //Redirect the user if they aren't logged in
            if (User.Identity.Name == null)
                return Redirect("Home/Welcome");

            Guid userId = Guid.Parse(_userManager.GetUserId(User));
            Customer customer = _context.Customers.Find(userId);
            var budget = _context.Budgets.Select(b => b.UserId == userId).ToList();

            //if user has no budgets prompt the user to create a new one
            if(budget.Count == 0)
            {
                return Redirect("Budget/Index");
            }

            return View(budget);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
