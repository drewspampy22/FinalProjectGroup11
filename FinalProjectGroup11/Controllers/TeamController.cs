using Microsoft.AspNetCore.Mvc;
using FinalProjectGroup11.Models;
using System.Collections.Generic;


namespace FinalProjectGroup11.Controllers
{
    public class TeamController : Controller
    {
        
        public ActionResult Index()
        {
            var teamMembers = new List<TeamMember>
            {
                new TeamMember { Name = "Drew Spampinato", Role = "Developer", Email = "spampiap@mail.uc.edu" },
                new TeamMember { Name = "Harsh Patel", Role = "Developer", Email = "patelhj@mail.uc.edu" },
                new TeamMember { Name = "Muyiwa Abimbola", Role = "Developer", Email = "abimbomj@mail.uc.edu" }
            };

            return View(teamMembers);
        }
    }
}
