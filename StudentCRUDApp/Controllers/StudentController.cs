using Microsoft.AspNetCore.Mvc;
using StudentCRUDApp.Models;

namespace StudentCRUDApp.Controllers
{
    public class StudentController : Controller
    {
       
        public IActionResult Index()
        {
            return View(DataStore.Students);
        }
        // HTTP GET VERSION
        public IActionResult Create()
        {
            return View();
        }

        // HTTP POST VERSION  
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                DataStore.Create(student);
                return View("Welcome", student);
            }
            else
                return View();
        }

            public IActionResult Update(string studentname)
        {
            Student student = DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault();
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student, string studentname)
        {
            if (ModelState.IsValid)
            {
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().FullName = student.FullName;
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().Age = student.Age;
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().Courses = student.Courses;
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().Department = student.Department;
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().Regno = student.Regno;
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().Sex = student.Sex;
            DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault().Address = student.Address;

            return RedirectToAction("Index");
        }
    else
        return View();
    }
    [HttpPost]
        public IActionResult Delete(string studentname)
        {
            Student student = DataStore.Students.Where(s => s.FullName == studentname).FirstOrDefault();
            DataStore.Delete(student);
            return RedirectToAction("Index");
        }

    }
}
