using System.ComponentModel.DataAnnotations;

namespace Infinity_app.Models
{
    public class Main_info
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string ImageName { get; set; }
    }
}