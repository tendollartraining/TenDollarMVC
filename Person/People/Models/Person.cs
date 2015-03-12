using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace People.Models
{
    public class Person
    {
        // Constructor
        public Person(){

            LastName = "Fill";
        
        }

        public int PersonID { get; set; }

        [DisplayName("Your First Name")]
        [Required]
        public string FirstName { get; set; }

        //[DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Age")]
        public string Age { get; set; }



    }
}