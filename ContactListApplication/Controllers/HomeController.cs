using ContactListApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContactListApplication.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext Context { get; set; }

        public HomeController(ContactContext ctx)
        {
            Context = ctx;
        }

        public IActionResult Index()
        {
            var contacts = Context.Contacts.OrderBy(m => m.Name).ToList();
            return View(contacts);
        }
    }
}
