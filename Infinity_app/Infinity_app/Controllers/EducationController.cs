using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/education")]
    [ApiController]
    public class EducationController : ControllerBase
    {
        ApplicationContext db;

        public EducationController() { }

        [HttpGet]
        public IEnumerable<Education> Get()
        {
            return db.Education.ToList();
        }

        [HttpGet("{id}")]
        public Education Get(int id)
        {
            Education education = db.Education.FirstOrDefault(x => x.Id == id);
            return education;
        }

        [HttpPut]
        public IActionResult Put(Education education)
        {
            if (ModelState.IsValid)
            {
                db.Education.Add(education);
                db.SaveChanges();
                return Ok(education);
            }
            return BadRequest(ModelState);
        }
    }
}