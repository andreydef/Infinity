using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/tags")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        ApplicationContext db;

        public TagsController() { }

        [HttpGet]
        public IEnumerable<Tags> Get()
        {
            return db.Tags.ToList();
        }

        [HttpGet("{id}")]
        public Tags Get(int id)
        {
            Tags tags = db.Tags.FirstOrDefault(x => x.Id == id);
            return tags;
        }

        [HttpPut]
        public IActionResult Put(Tags tags)
        {
            if (ModelState.IsValid)
            {
                db.Tags.Add(tags);
                db.SaveChanges();
                return Ok(tags);
            }
            return BadRequest(ModelState);
        }
    }
}