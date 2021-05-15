using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/about")]
    [ApiController]
    public class AboutController : Controller
    {
        ApplicationContext db;

        public AboutController(ApplicationContext context)
        {
            db = context;
            if (!db.About.Any())
            {
                db.About.Add(
                    new About
                    {
                        Id = 1,
                        Title = "ABOUT US",
                        Description = "is a creative digital agency based in Manila, Philippines. We are composed of creative designers and experienced developers."
                    });
                db.SaveChanges();
            }
            else
            {
                db.About.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<About> Get()
        {
            return db.About.ToList();
        }
    }
}