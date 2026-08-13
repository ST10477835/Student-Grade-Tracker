using Microsoft.AspNetCore.Mvc;
using Student_Grade_Tracker.Models;

namespace Student_Grade_Tracker.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Emma",   LastName = "Johnson",  Email = "emma.johnson@example.com" },
            new Student { Id = 2, FirstName = "Liam",   LastName = "Smith",    Email = "liam.smith@example.com" },
            new Student { Id = 3, FirstName = "Olivia", LastName = "Brown",    Email = "olivia.brown@example.com" },
            new Student { Id = 4, FirstName = "Noah",   LastName = "Davis",    Email = "noah.davis@example.com" },
            new Student { Id = 5, FirstName = "Ava",    LastName = "Wilson",   Email = "ava.wilson@example.com" }
        };
        public IActionResult Index()
        {
            return View(students);
        }
        [HttpGet]
        public IActionResult GetStudent(int Id)
        {
            var student = students.Find(s => s.Id == Id);
            return View(student);
        }
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            students.Add(student);
            return View();
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int Id)
        {
            var student = students.FirstOrDefault(s => s.Id == Id);
            students.Remove(student);
            return View();
        }
        [HttpPut]
        public IActionResult UpdateStudent(Student _student)
        {
            var student = students.FirstOrDefault(s => s.Id == _student.Id);
            int index = students.IndexOf(_student);

            student.FirstName = _student.FirstName;
            student.LastName = _student.LastName;
            student.Email = _student.Email;

            students[index] = student;
            return RedirectToAction();
        }
    }
}
