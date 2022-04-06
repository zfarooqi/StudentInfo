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
    public class StudentController : ControllerBase
    {
        //This should be read from a database. 
        private static List<Student> students = new List<Student>
            {
                new  Student ()  {   SchoolCode=994,StudentId=99400001,LastName="Abbott",FirstName="Allan",Address="1118 Glenview Lane",City = "Eagle Rock",State = "CA",ZipCode = 99999 }                ,
                new  Student ()  {   SchoolCode=994,StudentId=99400011,LastName="Abrahamson",FirstName="Arnold",Address="1126 E Walton Rd.",City = "Eagle Rock",State = "CA",ZipCode = 99999},
                new  Student ()  {   SchoolCode=994,StudentId=99400012,LastName="Abrego",FirstName="Alice",Address="115 W Norgate St",City = "Eagle Rock",State = "CA",ZipCode = 99999},
                new  Student ()  {   SchoolCode=994,StudentId=99400013,LastName="Abrego",FirstName="Ivette",Address="13642 Green Valley B",City = "Eagle Rock",State = "CA",ZipCode = 99999},
                new  Student ()  {   SchoolCode=994,StudentId=99400014,LastName="AbuJohn",FirstName="Edgar",Address="1123 N Barston Ave",City = "Eagle Rock",State = "CA",ZipCode = 99999},
                new  Student ()  {   SchoolCode=994,StudentId=99400015,LastName="Aceves",FirstName="Steven",Address="1110 Avenida Loma Vista",City = "Eagle Rock",State = "CA",ZipCode = 99999}
            };

        [HttpGet]
        public async Task<ActionResult<List<Student>>> Get()
        {
            return Ok(students);
        }
    }
}
