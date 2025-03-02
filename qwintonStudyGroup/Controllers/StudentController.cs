using qwintonStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qwintonStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Default
        public ActionResult ListStudents()
        {
            List<Models.studentModel> students = new List<Models.studentModel>();
            students.Add(new Models.studentModel { studentNumber = "u21669849", name="Qwinton", lastName="Knocklein", email="u21669849@tuks.co.za" });
            students.Add(new Models.studentModel { studentNumber = "u23658772", name = "Xander", lastName = "Visagie", email = "u23658772@tuks.co.za" });
            students.Add(new Models.studentModel { studentNumber = "u24664929", name = "Arno", lastName = "Smalberger", email = "u24664929@tuks.co.za" });
            students.Add(new Models.studentModel { studentNumber = "u24711919", name = "Regardt", lastName = "Van Heerden", email = "u24711919@tuks.co.za" });
            students.Add(new Models.studentModel { studentNumber = "u24587878", name = "Reinhardt", lastName = "Coetzee", email = "u24587878@tuks.co.za" });

            return View(students);
        }
    }
}