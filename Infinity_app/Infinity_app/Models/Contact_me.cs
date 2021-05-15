using System.ComponentModel.DataAnnotations;

namespace Infinity_app.Models
{
    public class Contact_me
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}