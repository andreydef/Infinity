using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/work-experience")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {
        ApplicationContext db;

        public WorkExperienceController(ApplicationContext context) { }

        [HttpGet]
        public IEnumerable<Work_Experience> Get()
        {
            return db.Work_Experience.ToList();
        }

        [HttpGet("{id}")]
        public Work_Experience Get(int id)
        {
            Work_Experience work = db.Work_Experience.FirstOrDefault(x => x.Id == id);
            return work;
        }

        [HttpPut]
        public IActionResult Put(Work_Experience work)
        {
            if (ModelState.IsValid)
            {
                db.Work_Experience.Add(work);
                db.SaveChanges();
                return Ok(work);
            }
            return BadRequest(ModelState);
        }
    }
}