﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;
using System.Linq;
using Infinity_app.Models;
using Infinity_app.Models.Main_models;

namespace Infinity_app.Controllers
{
    [Route("api/services")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        ApplicationContext db;

        public ServicesController(ApplicationContext context)
        {
            db = context;
            if (!db.Services.Any())
            {
                db.Services.AddRange(
                    new Services
                    {
                        Id = 1,
                        Title = "What Can I Do For You?",
                        Short_desc = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do.",
                        Title_service = "Web Development",
                        Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                    },
                    new Services
                    {
                        Id = 2,
                        Title_service = "Web Development",
                        Description = "Lorem ipsum Do commodo in proident enim in dolor cupidatat adipisicing dolore officia nisi aliqua incididunt Ut veniam lorem ipsum Consectetur ut in in eu do."
                    }
                    );
                db.SaveChanges();
            }
            else
            {
                db.Services.ToList();
            }
        }

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