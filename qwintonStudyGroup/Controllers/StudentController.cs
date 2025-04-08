using qwintonStudyGroup.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace qwintonStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        private static List<studentModel> students = new List<studentModel>
            {
                new studentModel { studentNumber = "u21669849", name="Qwinton", lastName="Knocklein", email="u21669849@tuks.co.za"},
                new studentModel { studentNumber = "u23658772", name = "Xander", lastName = "Visagie", email = "u23658772@tuks.co.za"},
                new studentModel { studentNumber = "u24664929", name = "Arno", lastName = "Smalberger", email = "u24664929@tuks.co.za" },
                new studentModel { studentNumber = "u24711919", name = "Regardt", lastName = "Van Heerden", email = "u24711919@tuks.co.za" },
                new studentModel { studentNumber = "u24587878", name = "Reinhardt", lastName = "Coetzee", email = "u24587878@tuks.co.za" }
            };

        public ActionResult ListStudents()
        {
            return View(students);
        }
        public ActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent(studentModel student)
        {
            if (ModelState.IsValid)
            {
                students.Add(student);
                return RedirectToAction("ListStudents");
            }
            return View(student);
        }
    }
}