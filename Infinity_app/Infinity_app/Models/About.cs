using System;
using System.ComponentModel.DataAnnotations;

namespace Infinity_app.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Максимальна довжина введеної стрічки - 50 символів")]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}