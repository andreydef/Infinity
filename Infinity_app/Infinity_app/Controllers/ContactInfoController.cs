using Microsoft.AspNetCore.Mvc;
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

        public ContactInfoController() { }

        [HttpGet]
        public IEnumerable<Contact_info> Get()
        {
            return db.Contact_info.ToList();
        }

        [HttpGet("{id}")]
        public Contact_info Get(int id)
        {
            Contact_info contact = db.Contact_info.FirstOrDefault(x => x.Id == id);
            return contact;
        }

        [HttpPut]
        public IActionResult Put(Contact_info contact)
        {
            if (ModelState.IsValid)
            {
                db.Contact_info.Add(contact);
                db.SaveChanges();
                return Ok(contact);
            }
            return BadRequest(ModelState);
        }
    }
}