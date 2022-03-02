using System.ComponentModel.DataAnnotations;

namespace TheBookSpot.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}
