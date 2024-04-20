using Microsoft.AspNetCore.Identity;
namespace OLX_MVC.Data.Entities
{
    public class User : IdentityUser
    {
        public DateTime? Birthdate { get; set; }
    }
}
