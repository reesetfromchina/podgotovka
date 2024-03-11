

using System.ComponentModel.DataAnnotations;

namespace Concert.Models
{

    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public int NumberOfPeople { get; set; }

        public Guid ConcertId { get; set; }
        public virtual ConcertModel? Concert { get; set; }
        //    // fetch types na relacii virtual ??
    }
}
