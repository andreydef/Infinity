using System.ComponentModel.DataAnnotations;

namespace Infinity_app.Models
{
    public class Contact_info
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 40, ErrorMessage = "Максимальна довжина введеної стрічки - 40 символів")]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required]
        public string Short_desc { get; set; }

        public string ImageName { get; set; }

        public string Link_facebook { get; set; }

        public string Link_github { get; set; }

        public string Link_twitter { get; set; }

        public string Link_instagram { get; set; }
    }
}