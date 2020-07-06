using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AgileTicketWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileTicketWebApp.Controllers
{
    public class HomeController : Controller
    {
        private AgileContext context;
        public HomeController(AgileContext ctx) => context = ctx;

        public IActionResult Index(string id)
        {
            //store current filters and data needed for filter drop downs 
            TicketView model = new TicketView();

            var filters = new Filters(id);

            model.Filters = new Filters(id);
            model.Sprints = context.New_Sprints.ToList();
            model.Statuses = context.New_Statuses.ToList();
            model.DueFilters = Filters.DueFilterValues;

            IQueryable<Ticket> query = context.New_Tickets.Include(t => t.Sprint).Include(t => t.Status);
            if (filters.HasSprint)
            {
                query = query.Where(t => t.AgileSprintID == filters.AgileSprintID);
            }
            if (filters.HasStatus)
            {
                query = query.Where(t => t.AgileStatusID == filters.AgileStatusID);
            }
            if (filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    query = query.Where(t => t.Deadline < today);
                else if (filters.IsFuture)
                    query = query.Where(t => t.Deadline > today);
                else if (filters.IsToday)
                    query = query.Where(t => t.Deadline == today);
            }
            var tasks = query.OrderBy(t => t.Deadline).ToList();
            model.Tasks = tasks;
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            TicketView model = new TicketView();
            model.Sprints = context.New_Sprints.ToList();
            model.Statuses = context.New_Statuses.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(TicketView model)
        {
            if (ModelState.IsValid)
            {
                context.New_Tickets.Add(model.CurrentTask);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                model.Sprints = context.New_Sprints.ToList();
                model.Statuses = context.New_Statuses.ToList();
                return View(model);
            }
        }
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Ticket selected)
        {
            if (selected.AgileStatusID == null)
            {
                context.New_Tickets.Remove(selected);
            }
            else
            {
                string newStatusId = selected.AgileStatusID;
                selected = context.New_Tickets.Find(selected.AgileTicketID);
                selected.AgileStatusID = newStatusId;
                context.New_Tickets.Update(selected);
            }
            context.SaveChanges();
            return RedirectToAction("Index", new { ID = id });
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
