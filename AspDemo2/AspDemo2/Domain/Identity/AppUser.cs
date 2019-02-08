using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    public class AppUser : IdentityUser
    {
        public List<Person> Persons { get; set; }
    }
}