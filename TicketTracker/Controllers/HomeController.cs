using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TicketTracker.Models;
using TicketTrackerModels;

namespace TicketTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestPage()
        {
            var ticket = new Ticket();
            ticket.Id = 999;
            ticket.Priority = Priority.Critical;
            ticket.Status = Status.Open;
            ticket.TicketCreatedBy = "John Appleseed";
            ticket.HoursOfLabor = 5.0;
            ticket.Issue = "You need to complete your cyber awareness";
            ticket.StakeholderEmails = "bob@gmail.com";
            ticket.Description = "idk";
            ViewData["myCustomeKey"] = "myData";
            return View(ticket);
        }
        public IActionResult SimpleDataPage()
        {
            var s = "simple data";
            ViewData["myCustomeKey"] = "myData";
            return View(s);
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