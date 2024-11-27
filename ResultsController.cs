using ActionResultInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionResultInMVC.Controllers
{
    public class ResultsController : Controller
    {
       public JsonResult GetEmployees()
        {
            Employee e1 = new Employee { Id = 101, Name = "Yamini", Job = "Manager", Salary = 50000, Status = true };
            Employee e2 = new Employee { Id = 102, Name = "Chinni", Job = "Manager", Salary = 50000, Status = true };
            Employee e3 = new Employee { Id = 103, Name = "Varun", Job = "Manager", Salary = 50000, Status = true };
            Employee e4 = new Employee { Id = 104, Name = "Tishika", Job = "Manager", Salary = 50000, Status = true };
            List<Employee> Emps = new List<Employee> { e1,e2,e3,e4};
            return Json(Emps, JsonRequestBehavior.AllowGet);
        }
        public FileResult DownloadWord()
        {
            return File("~/Downloads/Yamini Resume.docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
    }
}