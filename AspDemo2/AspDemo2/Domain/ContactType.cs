using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class ContactType : BaseEntity
    {
        [MaxLength(64)]
        [MinLength(1)]
        [Required]
        public string ContactTypeName { get; set; }

        
        public List<Contact> Contacts { get; set; }
    }
}