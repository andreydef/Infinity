using Microsoft.AspNetCore.Mvc;
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

        public ContactMeController() { }

        [HttpGet]
        public IEnumerable<Contact_me> Get()
        {
            return db.Contact_me.ToList();
        }

        [HttpGet("{id}")]
        public Contact_me Get(int id)
        {
            Contact_me contact_me = db.Contact_me.FirstOrDefault(x => x.Id == id);
            return contact_me;
        }

        [HttpPut]
        public IActionResult Put(Contact_me contact_me)
        {
            if (ModelState.IsValid)
            {
                db.Contact_me.Add(contact_me);
                db.SaveChanges();
                return Ok(contact_me);
            }
            return BadRequest(ModelState);
        }
    }
}