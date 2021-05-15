using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;
using Infinity_app.Models;

namespace Infinity_app.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : Controller
    {
        ApplicationContext db;
        public ContactsController(ApplicationContext context)
        {
            db = context;
            if (!db.Contacts.Any())
            {
                db.Contacts.Add(
                    new Contacts
                    {
                        Id = 1,
                        Name = "test",
                        Email = "test@gmail.com",
                        Subject = "test",
                        Message = "test message"
                    });
                db.SaveChanges();
            }
            else
            {
                db.Contacts.ToList();
            }
        }

        [HttpPost]
        public void PostContact(Contacts contact)
        {
            db.Contacts.Add(contact);
            db.SaveChangesAsync();

            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("69dd5b88b980d4", "15fc0d5f3f4936"),
                EnableSsl = true
            };
            client.Send("from@example.com", "admin@example.com", "New message", 
                $"You have a new message! \n" +
                $"Name: {contact.Name} \n" +
                $"Email: {contact.Email} \n" +
                $"Subject: {contact.Subject} \n" +
                $"Message: {contact.Message}");
        }
    }
}