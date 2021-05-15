using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/contact-me")]
    [ApiController]
    public class ContactMeController : ControllerBase
    {
        ApplicationContext db;

        public ContactMeController(ApplicationContext context)
        {
            db = context;
            if (!db.Contact_me.Any())
            {
                db.Contact_me.Add(
                    new Contact_me
                    {
                        Id = 1,
                        Title = "Get In Touch.",
                        Description = "Quisque velit nisi, pretium ut lacinia in, elementum id enim. Curabitur arcu erat, accumsan id imperdiet et, porttitor at sem. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi."
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Contact_me.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Contact_me> Get()
        {
            return db.Contact_me.ToList();
        }
    }
}