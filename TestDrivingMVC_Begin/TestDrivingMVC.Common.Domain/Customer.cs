
using System;
using System.ComponentModel.DataAnnotations;

namespace TestDrivingMVC.Common.Domain {

    public class Customer {

        public long Id { get; set; }

        [Required(ErrorMessage = "{0} is required"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "{0} is required"), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "{0} is required"), Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

    }
}
