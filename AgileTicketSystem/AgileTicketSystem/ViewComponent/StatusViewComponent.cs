using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AgileTicketSystem.Models;

namespace AgileTicketSystem.ViewComponent
{
    public class StatusViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Ticket ticket)
        {
            return View(ticket);
        }
    }
}
