using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/calculator")]
    [ApiController]
    public class CalculatorController : Controller
    {
        ApplicationContext db;

        public CalculatorController(ApplicationContext context)
        {
            db = context;
            if (!db.Calculator.Any())
            {
                db.Calculator.Add(
                    new Calculator
                    {
                        Id = 1,
                        Type = "test",
                        CMS = "test",
                        Struct = "test",
                        Layout = "test",
                        Language = "test",
                        Geolocation = "test",
                        Products = "test",
                        Forms = "test",
                        Image = "test",
                        Money = "test",
                        Socials = "test",
                        Domen = "test"
                    });
                db.SaveChanges();
            }
            else
            {
                db.Calculator.ToList();
            }
        }

        [HttpGet]
        public IEnumerable<Calculator> Get()
        {
            return db.Calculator.ToList();
        }

        [HttpGet("{id}")]
        public Calculator Get(int id)
        {
            Calculator calculator = db.Calculator.FirstOrDefault(x => x.Id == id);
            return calculator;
        }
    }
}