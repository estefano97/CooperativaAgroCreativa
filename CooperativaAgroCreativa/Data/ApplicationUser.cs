using Microsoft.AspNetCore.Identity;
 
namespace CooperativaAgroCreativa.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Direction { get; set; }
        public string Movil { get; set; }
        public string IsConfirmed { get; set; }
        public string Role { get; set; }
    }
}
