using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebPanel.Models;


namespace WebPanel.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult ZSK_Umrechner(Rechner rechne)
        {

            return View("ergebnis", rechne);
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ZSK_Umrechner()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Ergebnis(Rechner rechne)
        {
            if (ModelState.IsValid)
            {
                Store.AddStore(rechne);
                rechne.Rechne();
                return View("ergebnis", Store.Stores);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (
                ModelState.IsValid)
            {
                Repository.AddResponses(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}