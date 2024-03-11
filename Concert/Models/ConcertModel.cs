using System.ComponentModel.DataAnnotations;

namespace Concert.Models
{
    public class ConcertModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public float Price { get; set; }
        public string Place { get; set; }

        public string? ImageUrl { get; set; }
    }
}
