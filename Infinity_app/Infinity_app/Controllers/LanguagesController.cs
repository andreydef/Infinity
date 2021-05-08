using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/languages")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        ApplicationContext db;

        public LanguagesController() { }

        [HttpGet]
        public IEnumerable<Languages> Get()
        {
            return db.Languages.ToList();
        }

        [HttpGet("{id}")]
        public Languages Get(int id)
        {
            Languages lang = db.Languages.FirstOrDefault(x => x.Id == id);
            return lang;
        }

        [HttpPut]
        public IActionResult Put(Languages lang)
        {
            if (ModelState.IsValid)
            {
                db.Languages.Add(lang);
                db.SaveChanges();
                return Ok(lang);
            }
            return BadRequest(ModelState);
        }
    }
}