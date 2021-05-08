using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/main-info")]
    [ApiController]
    public class MainInfoController : ControllerBase
    {
        ApplicationContext db;

        public MainInfoController() { }

        [HttpGet]
        public IEnumerable<Main_info> Get()
        {
            return db.Main_info.ToList();
        }

        [HttpGet("{id}")]
        public Main_info Get(int id)
        {
            Main_info main_info = db.Main_info.FirstOrDefault(x => x.Id == id);
            return main_info;
        }

        [HttpPut]
        public IActionResult Put(Main_info main_info)
        {
            if (ModelState.IsValid)
            {
                db.Main_info.Add(main_info);
                db.SaveChanges();
                return Ok(main_info);
            }
            return BadRequest(ModelState);
        }
    }
}