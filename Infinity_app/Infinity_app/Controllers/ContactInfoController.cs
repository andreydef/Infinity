using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/contact-info")]
    [ApiController]
    public class ContactInfoController : ControllerBase
    {
        ApplicationContext db;

        public ContactInfoController(ApplicationContext context)
        {
            db = context;
            if (!db.Contact_info.Any())
            {
                db.Contact_info.AddRange(
                    new Contact_info
                    {
                        Id = 1,
                        Title = "WHERE TO FIND ME",
                        Short_desc = "1600 Amphitheatre Parkway Mountain View, CA 94043 US"
                    },
                    new Contact_info
                    {
                        Id = 2,
                        Title = "EMAIL ME AT",
                        Short_desc = "someone@kardswebsite.com info@kardswebsite.com"
                    },
                    new Contact_info
                    {
                        Id = 3,
                        Title = "CALL ME AT",
                        Short_desc = "Phone: (+63) 555 1212 Mobile: (+63) 555 0100 Fax: (+63) 555 0101"
                    });
                db.SaveChanges();
            }
            else
            {
                db.Contact_info.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Contact_info> Get()
        {
            return db.Contact_info.ToList();
        }
    }
}