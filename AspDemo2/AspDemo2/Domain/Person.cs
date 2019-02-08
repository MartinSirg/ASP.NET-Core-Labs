using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class Person : BaseEntity
    {
        [MaxLength(64)]
        [MinLength(1)]
        [Required]
        public string FirstName { get; set; }
        
        [MaxLength(64)]
        [MinLength(1)]
        [Required]
        public string LastName { get; set; }

        public List<Contact> Contacts { get; set; }

        [MaxLength(64)]
        [MinLength(1)]
        [Required]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        
        public string FirstLastName => FirstName + " " + LastName;
        public string LastFirstName => LastName + " " + FirstName;
    }
}