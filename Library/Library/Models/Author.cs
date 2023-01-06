using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateOnly? DateOfBirth { get; set; }

        // One-to-many relationship with books
        public List<Book>? Books { get; set; }
    }
}
