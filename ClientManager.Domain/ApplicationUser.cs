using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;


namespace ClientManager.Domain
{

    public class ApplicationUser : IdentityUser
    {
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(1)]
        public string Gender { get; set; }
    }
}
