using Basic_asp01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basic_asp01.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            Student s1 = new Student();
            s1.Id = 1;
            s1.Name = "Test1";
            s1.Score = 10;

            var s2 = new Student();
            s2.Id = 2;
            s2.Name = "Test2";
            s2.Score = 4;

            Student s3 = new();
            s3.Id = 3;
            s3.Name = "Test3";
            s3.Score = 7;

            List<Student> allStudents = new List<Student>();
            allStudents.Add(s1);
            allStudents.Add(s2);
            allStudents.Add(s3);

           return View(allStudents);
        }

        public IActionResult Create ()
        {
            return View();
        }
        public IActionResult ShowScore (int id)
        {
            return View();
        }
    }
}
