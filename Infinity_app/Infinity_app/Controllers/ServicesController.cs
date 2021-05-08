using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/services")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        ApplicationContext db;

        public ServicesController() { }

        [HttpGet]
        public IEnumerable<Services> Get()
        {
            return db.Services.ToList();
        }

        [HttpGet("{id}")]
        public Services Get(int id)
        {
            Services service = db.Services.FirstOrDefault(x => x.Id == id);
            return service;
        }

        [HttpPut]
        public IActionResult Put(Services service)
        {
            if (ModelState.IsValid)
            {
                db.Services.Add(service);
                db.SaveChanges();
                return Ok(service);
            }
            return BadRequest(ModelState);
        }
    }
}