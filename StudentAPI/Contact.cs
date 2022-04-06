using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI
{
    public class Contact
    {
        public int StudentId { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Relationship { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public int ZipCode { get; set; }
    }
}
