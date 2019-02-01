﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public string  LastName { get; set; }

        public List<Contact> Contacts { get; set; }

        public string FirstLastName => $"{FirstName} {LastName}";
        public string LastFirstName => $"{LastName} {FirstName}";
    }
}