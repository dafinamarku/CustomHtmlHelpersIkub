using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomHtmlHelpers.Models;

namespace CustomHtmlHelpers.Controllers
{
    public class ClassController : Controller
    {

    public IEnumerable<StudentClass> classes = new List<StudentClass>
              {
                new StudentClass{id=1, name="A1", students=new List<Student>{
                  new Student{ name="Brandon", age=20, gender='m', email="brandon@gmail.com" },
                  new Student{name="Ana", age=20, gender='f', email="ana02@gmail.com"},
                  new Student{name="Gloria", age=21, gender='f', email="gloria@gmail.com"},
                  new Student{name="Ryan", age=21, gender='m', email="rayan@gmail.com"}
                } },
                new StudentClass{id=2, name="A2", students=new List<Student>{
                  new Student{ name="Otis", age=20, gender='m', email="otis@gmail.com" },
                  new Student{name="Ana", age=20, gender='f', email="ana02@gmail.com"},
                  new Student{name="Dea", age=21, gender='f', email="dea@gmail.com"},
                  new Student{name="Justin", age=21, gender='m', email="justin@gmail.com"}
                } }
              };
        // GET: Class
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Classes()
        {
          return View(classes);
        }

        public ActionResult Details(int id)
        {
          StudentClass classDetails = classes.First(c=>c.id==id);
          return View(classDetails);
        }
    }
}