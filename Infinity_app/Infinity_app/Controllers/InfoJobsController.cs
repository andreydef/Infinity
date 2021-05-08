using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/info-job")]
    [ApiController]
    public class InfoJobsController : ControllerBase
    {
        ApplicationContext db;

        public InfoJobsController() { }

        [HttpGet]
        public IEnumerable<Info_jobs> Get()
        {
            return db.Info_jobs.ToList();
        }

        [HttpGet("{id}")]
        public Info_jobs Get(int id)
        {
            Info_jobs info_jobs = db.Info_jobs.FirstOrDefault(x => x.Id == id);
            return info_jobs;
        }

        [HttpPut]
        public IActionResult Put(Info_jobs info_jobs)
        {
            if (ModelState.IsValid)
            {
                db.Info_jobs.Add(info_jobs);
                db.SaveChanges();
                return Ok(info_jobs);
            }
            return BadRequest(ModelState);
        }
    }
}