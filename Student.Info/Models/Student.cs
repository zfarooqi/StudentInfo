using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentInfo.Models
{
    public class Student
    {
        [Display(Name = "School Code")]
        public int SchoolCode { get; set; }

        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; } = String.Empty;

        [Display(Name = "First Name")]
        public string FirstName { get; set; } = String.Empty;

        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;

        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
    }
}
