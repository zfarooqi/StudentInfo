using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

using StudentInfo.Models;
using System.Net.Http;

namespace StudentInfo.Controllers
{
    public class StudentController : Controller
    {

        private string url = "https://localhost:44387/api/";
        private HttpClientHandler clientHandler = new HttpClientHandler();

        private Student student = new Student();
        private List<Student> students = new List<Student>();

        private Contact contact = new Contact();
        private List<Contact > contacts = new List<Contact>();

        public StudentController()
        {
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }


        public IActionResult Index()
        {
            GetStudents(); 
            return View(students);
        }


        private  void GetStudents()
        {
            var task = GetStudentsAsync();
            students = task.Result;// .WaitAndUnwrapException();
        }


        public async Task<List<Student>> GetStudentsAsync()
        {
            try
            {
                using (var httpClient = new HttpClient(clientHandler))
                {
                    using (var response = await httpClient.GetAsync(url + "Student"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        students = JsonConvert.DeserializeObject<List<Student>>(apiResponse);
                    }
                }
            }
            catch ( Exception ex)
            {
                throw ; 
            }
            return students;
        }


        [HttpGet]
        public async Task<List<Contact>> GetContacts(int studentID)
        {
            try
            {
                using (var httpClient = new HttpClient(clientHandler))
                {
                    using (var response = await httpClient.GetAsync(url + "Contact"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        contacts = JsonConvert.DeserializeObject<List<Contact>>(apiResponse).Where(i => i.StudentId == studentID).ToList();
                    }
                }
                //contacts = contacts.Where(i => i.StudentId == studentID).ToList();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }

            return contacts;
        }
    }
}
