using Microsoft.AspNetCore.Identity;

namespace Order.Api.Entities
{
    public class User : IdentityUser<int>
    {
        public UserAddress Address { get; set; }
    }
}