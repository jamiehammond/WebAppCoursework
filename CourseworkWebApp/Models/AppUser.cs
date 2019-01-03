using Microsoft.AspNetCore.Identity;
using System;

namespace CourseworkWebApp.Models
{
    public class AppUser : IdentityUser
    {

        public Boolean IsAdmin { get; set; }
    }
}
