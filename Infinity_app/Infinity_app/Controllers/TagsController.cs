﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;
using Infinity_app.Models.Main_models;

namespace Infinity_app.Controllers
{
    [Route("api/tags")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        ApplicationContext db;

        public TagsController(ApplicationContext context)
        {
            db = context;
            if (!db.Languages.Any())
            {
                db.Tags.AddRange(
                    new Tags
                    {
                        Id = 1,
                        Title = "Website"
                    },
                    new Tags
                    {
                        Id = 2,
                        Title = "Bank"
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Tags.ToList();
            }
        }

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