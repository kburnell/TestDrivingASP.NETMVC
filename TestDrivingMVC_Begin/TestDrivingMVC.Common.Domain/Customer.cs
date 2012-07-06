
using System;
using System.ComponentModel.DataAnnotations;

namespace TestDrivingMVC.Common.Domain {

    public class Customer {

        public long Id { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

    }
}
