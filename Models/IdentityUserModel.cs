using Microsoft.AspNetCore.Identity;

namespace eLearning.Models
{
    public class IdentityUserModel : IdentityUser
    {
        public string RoleId { get; set; }
    }
}
