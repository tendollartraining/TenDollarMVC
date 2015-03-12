using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamilyDB.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string Fname { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string Lname { get; set; }
        [DisplayName("Street Address")]
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [DisplayName("Zip Code")]
        [Required]
        public string Zip { get; set; }
        [DisplayName("Contact Number")]
        [Required]
        public string Phone { get; set; }

    }
}