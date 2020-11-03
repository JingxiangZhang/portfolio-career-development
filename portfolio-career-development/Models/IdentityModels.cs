using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace portfolio_career_development.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "Please Enter the First Name !")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please Enter the Last Name !")]
        [StringLength(20, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Please Enter the Contact number !")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public string contactNumber { get; set; }
        

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<portfolio_career_development.Models.Article> Articles { get; set; }

        public System.Data.Entity.DbSet<portfolio_career_development.Models.Webinar> Webinars { get; set; }
    }
}