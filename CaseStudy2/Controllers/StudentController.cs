using CaseStudy2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaseStudy2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        StudentContext studentContext = new StudentContext();
        public ActionResult Index()
        {
            List<Student> students = studentContext.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public ActionResult Create(Student student)
        { 
            studentContext.Students.Add(student);
            studentContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Student student=studentContext.Students.Find(id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student student)
        {
            Student stud=studentContext.Students.Find(student.StudId);
            stud.StudName=student.StudName;
            stud.City=student.City;
            stud.Branch=student.Branch;
            stud.Percentage=student.Percentage;
            studentContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Student s = studentContext.Students.Find(id);
            studentContext.Students.Remove(s);
            studentContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Student student = studentContext.Students.Find(id);
            return View(student);
        }
        [HttpGet]
        public ActionResult byCity(FormCollection form)
        {
            string City = form["City"];
            
            return View(City);
        }
        [HttpPost]
        public ActionResult byCity(String City)
        {
            List<Student> students = (from student in studentContext.Students
                                      where student.City == City
                                      select student).ToList();
            return View("search",students);
        }
        [HttpGet]
        public ActionResult byBranch(FormCollection form)
        {
            string Branch = form["Branch"];

            return View(Branch);
        }
        [HttpPost]
        public ActionResult byBranch(String Branch)
        {
            IEnumerable<Student> students = (from student in studentContext.Students
                                      where student.Branch == Branch
                                      select student);
            return View("search", students);
        }
        [HttpGet]
        public ActionResult byPercentage(FormCollection form)
        {
            
           string From=form["P1"];
           string To=(form["P2"]);
            return View((From,To));

        }
      [HttpPost]
      public ActionResult byPercentage(string From,string To)
        {
            int P1= Convert.ToInt32(From);
            int P2= Convert.ToInt32(To);
            IEnumerable<Student> students=(from student in studentContext.Students
                                    where student.Percentage>=P1
                                    select student);
            IEnumerable<Student> studs = ((from stud in students where stud.Percentage <=P2 select stud));

            return View("search",students);
        }
        [HttpGet]
        public ActionResult byId(FormCollection form)
        {
            int id =Convert.ToInt32(form["id"]);
            return View(id);
        }
        [HttpPost]
        public ActionResult byId(int ID)
        {
            IEnumerable<Student> student= (from stud in studentContext.Students
                              where stud.StudId.Equals(ID)
                            select stud);
            return View("search",student);
        }
        public ActionResult search(Student student)
        {
            return View(student);
        }
    }
}