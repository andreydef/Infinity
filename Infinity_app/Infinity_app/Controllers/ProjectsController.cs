using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        ApplicationContext db;

        public ProjectsController() { }

        [HttpGet]
        public IEnumerable<Projects> Get()
        {
            return db.Projects.ToList();
        }

        [HttpGet("{id}")]
        public Projects Get(int id)
        {
            Projects proj = db.Projects.FirstOrDefault(x => x.Id == id);
            return proj;
        }

        [HttpPut]
        public IActionResult Put(Projects proj)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(proj);
                db.SaveChanges();
                return Ok(proj);
            }
            return BadRequest(ModelState);
        }
    }
}