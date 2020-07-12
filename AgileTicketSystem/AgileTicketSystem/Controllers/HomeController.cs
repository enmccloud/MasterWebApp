/***************************************************************
* Name        : Agile Ticket System
* Author      : Nikki McCloud
* Created     : 7/5/20
* Course      : CIS 174 – Adv C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            
*               specifications issued by our instructor
* Description : Saves tickets to a database and allows for	 	 
* 		   	    editing of ticket progression.                                                      
*			 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AgileTicketSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AgileTicketSystem.Controllers
{
    public class HomeController : Controller
    {
        // Initilization of context
        private TicketContext context;
        public HomeController(TicketContext ctx) => context = ctx;

        // Taking my filters and returns view with filter capability
        public IActionResult Index(string id)
        {
            TicketViewModel model = new TicketViewModel();

            var filters = new Filters(id);

            model.Filters = new Filters(id);
            model.Redo_Sprints = context.Redo_Sprints.ToList();
            model.Redo_Statuses = context.Redo_Statuses.ToList();
            model.DueFilters = Filters.DueFilterValues;

            // Displays tickets based on filtered selections.

            IQueryable<Ticket> query = context.Redo_Tickets.Include(t => t.Sprint).Include(t => t.Status);
            if (filters.HasSprint)
            {
                query = query.Where(t => t.SprintId == filters.SprintID);
            }
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusID);
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

        // Redirects to add view along with all components for Adding a ticket.
        public IActionResult Add()
        {
            TicketViewModel model = new TicketViewModel();
            model.Redo_Sprints = context.Redo_Sprints.ToList();
            model.Redo_Statuses = context.Redo_Statuses.ToList();
            return View(model);
        }

        //Binding to my view model
        [HttpPost]
        public IActionResult Add(TicketViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.Redo_Tickets.Add(model.CurrentTask);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                model.Redo_Sprints = context.Redo_Sprints.ToList();
                model.Redo_Statuses = context.Redo_Statuses.ToList();
                return View(model);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Ticket onSelect)
        {
            if (onSelect.StatusId == null)
            {
                context.Redo_Tickets.Remove(onSelect);
            }
            else
            {
                string newStatusId = onSelect.StatusId;
                onSelect = context.Redo_Tickets.Find(onSelect.TicketID);
                onSelect.StatusId = newStatusId;
                context.Redo_Tickets.Update(onSelect);
            }
            context.SaveChanges();
            return RedirectToAction("Index", new { ID = id });
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
