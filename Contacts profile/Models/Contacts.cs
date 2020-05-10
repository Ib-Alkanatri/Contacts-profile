using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Contacts_profile.Models
{
    public class Contacts
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string ContactFirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string  ContactLastName { get; set; }
        [Required]
        [DisplayName("Email")]
        public string ContactEmail { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string ContactPhoneNum { get; set; }
        [Required]
        [DisplayName("Address")]
        public string ContactAddress { get; set; }
    }
}