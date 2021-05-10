using System.ComponentModel.DataAnnotations;

namespace Infinity_app.Models
{
    public class Calculator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
        [Required]
        public string CMS { get; set; }
        [Required]
        public string Struct { get; set; }
        [Required]
        public string Layout { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public string Geolocation { get; set; }
        [Required]
        public string Products { get; set; }
        [Required]
        public string Forms { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Money { get; set; }
        [Required]
        public string Socials { get; set; }
        [Required]
        public string Domen { get; set; }
    }
}
