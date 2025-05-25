using System.ComponentModel.DataAnnotations;

namespace mvc_architecture.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; } = null;
        public int Age { get; set; }
        public string? Address { get; set; }

    }
}
