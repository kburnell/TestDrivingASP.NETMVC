
using System;
using System.ComponentModel.DataAnnotations;

namespace TestDrivingMVC.Common.Domain {

    public class Customer {

        public long Id { get; set; }

        [Required, Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

    }
}
