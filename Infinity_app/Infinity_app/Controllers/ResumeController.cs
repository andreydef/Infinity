using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/resume")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        ApplicationContext db;

        public ResumeController(ApplicationContext context) { }

        [HttpGet]
        public IEnumerable<Resume> Get()
        {
            return db.Resume.ToList();
        }

        [HttpGet("{id}")]
        public Resume Get(int id)
        {
            Resume resume = db.Resume.FirstOrDefault(x => x.Id == id);
            return resume;
        }

        [HttpPut]
        public IActionResult Put(Resume resume)
        {
            if (ModelState.IsValid)
            {
                db.Resume.Add(resume);
                db.SaveChanges();
                return Ok(resume);
            }
            return BadRequest(ModelState);
        }
    }
}