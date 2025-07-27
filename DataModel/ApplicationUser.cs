using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Library_Management_System.DataModel
{
    public class ApplicationUser : IdentityUser
{
        public string? Adress { get; set; }
        public string? BloadGroup { get; set; }
        public string? IDNumber { get; set; }
    }
}
