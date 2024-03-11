using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Concert.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}
