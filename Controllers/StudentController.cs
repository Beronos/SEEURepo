using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEEU.Data;
using SEEU.Models;

namespace SEEU.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolContext _context;

        public StudentController(SchoolContext sc)
        {
            _context = sc;
            Console.WriteLine(  "djvnkfjb");
            Console.WriteLine("betim dt raf");
	{
		default:
	}
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();

            //var s2 = from s in _context.Students
            //               select s;
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                
                return NotFound();
            }

            Student student = _context.Students.Find(id);

            if(student == null)
            {

                
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int? id)
        {
            Student student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }




    }
}
