using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoodBoys.Models;

namespace GoodBoys.Controllers
{
    public class HomeController : Controller
    {
        private readonly MySqlContext _context;

        public HomeController(MySqlContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            _context.Add(new PendingApprove());
            _context.SaveChanges();
            
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
