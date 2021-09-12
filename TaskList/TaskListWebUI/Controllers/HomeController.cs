using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskList.DataLayer;
using TaskListWebUI.Models;

namespace TaskListWebUI.Controllers
{
    public class HomeController : Controller
    {
        private TaskListDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, TaskListDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Tasks()
        {

            return View(_db.TaskItems.AsEnumerable());
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
