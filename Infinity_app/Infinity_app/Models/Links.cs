using System.ComponentModel.DataAnnotations;

namespace Infinity_app.Models
{
    public class Links
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Link_facebook { get; set; }

        [Required]
        public string Link_github { get; set; }

        [Required]
        public string Link_twitter { get; set; }

        [Required]
        public string Link_instagram { get; set; }
    }
}