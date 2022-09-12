using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TBHAcademy.Data;
using TBHAcademy.Models;

namespace TBHAcademy.Controllers
{
    public class HodController : Controller
    {
        private readonly TBHAcademyContext _db;
        public HodController(TBHAcademyContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index1()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult InsertFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _db.Faculty.Add(faculty);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(faculty);

        }
        public IActionResult DisplayFaculty()
        {
            IEnumerable<Faculty> FacultyList = _db.Faculty;
            return View(FacultyList);
        }
        public IActionResult UpdateFaculty(int? id)
        {
            if(id == null && id== 0)
            {
                return NotFound();
            }
            var faculty = _db.Faculty.Find(id);
            if(faculty == null)
            {
                return NotFound();
            }
            return View(faculty);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateFaculty(Faculty faculty)
        {
            _db.Faculty.Update(faculty);
            _db.SaveChanges();
            return RedirectToAction("DisplayFaculty");
        }

    }
}
