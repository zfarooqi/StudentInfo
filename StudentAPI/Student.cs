using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI
{
    public class Student
    {
        public int SchoolCode { get; set; }
        public int StudentId { get; set; }
        public string LastName { get; set; } = String.Empty;
        public string FirstName { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public int ZipCode { get; set; }
    }
}
