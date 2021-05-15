using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/links")]
    [ApiController]
    public class LinksController : ControllerBase
    {
        ApplicationContext db;

        public LinksController(ApplicationContext context)
        {
            db = context;
            if (!db.Links.Any())
            {
                db.Links.Add(
                    new Links
                    {
                        Id = 1,
                        Link_facebook = "https://www.facebook.com/profile.php?id=100009036657512",
                        Link_github = "https://github.com/andreydef",
                        Link_twitter = "https://twitter.com/Andriy346",
                        Link_instagram = "https://www.instagram.com/_andriy_halelyuka_/"
                    });
                db.SaveChanges();
            }
            else
            {
                db.Links.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Links> Get()
        {
            return db.Links.ToList();
        }
    }
}