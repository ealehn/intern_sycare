
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Project.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }
        public string LevelOfEducation { get; set; }
        public string photofilepath { get; set; }

        public bool isremoved { get; set; }

    }
}
