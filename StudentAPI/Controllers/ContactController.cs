using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        //This should be read from a database.
        private static List<Contact> contacts = new List<Contact>
        {
            new Contact() {StudentId=99400001,LastName="Abbott",FirstName="Sara",Relationship="Mother",EmailAddress="sara@example.com",Mobile="949-123-45678",Address="1118 Glenview Lane",City=" ",State="CA", ZipCode=99999 },
            new Contact() {StudentId=99400001,LastName="Abbott",FirstName="Adam",Relationship="Father",EmailAddress="adam@example.com",Mobile="949-123-45679",Address="1118 Glenview Lane",City=" ",State="CA", ZipCode=99999 },
             new Contact() {StudentId=99400011,LastName="Abrahamson",FirstName="Jonathan",Relationship="Uncle",EmailAddress="jonathan@example.com",Mobile="949-234-4567",Address="1126 E Walton Rd.",City=" ",State="CA", ZipCode=99999 },
             new Contact() {StudentId=99400012,LastName="Acosta",FirstName="Christine",Relationship="Mother",EmailAddress="christine@example.com",Mobile="949-345-6789",Address="115 W Norgate St",City=" ",State="CA", ZipCode=99999 },
             new Contact() {StudentId=99400013,LastName="Abrego",FirstName="Rezvan",Relationship="Father",EmailAddress="rezvan@example.com",Mobile="949-456-7891",Address="13642 Green Valley B",City=" ",State="CA", ZipCode=99999 },
             new Contact() {StudentId=99400014,LastName="AbuJohn",FirstName="Selina",Relationship="Mother",EmailAddress="selina@example.com",Mobile="949-567-8912",Address="1123 N Barston Ave",City=" ",State="CA", ZipCode=99999 },
             new Contact() {StudentId=99400015,LastName="Aceves",FirstName="Jacob",Relationship="Father",EmailAddress="jacob@example.com",Mobile="949-678-9123",Address="1110 Avenida Loma Vista",City=" ",State="CA",ZipCode=99999 }
        };
        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get()
        {
            return Ok(contacts);
        }
    }
}
