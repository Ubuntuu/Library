using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryDP.Data;
using LibraryDP.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryDP.Controllers
{
    public class UserController : Controller
    {
        private readonly UserContext _context;

        public UserController(UserContext context)
        {
            _context = context;
        }
        //GET: User
        //Should we use iterator here? 
        public IActionResult Index()
        {
            return View(_context.MyUsers.ToList());
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userModel = _context.MyUsers.FirstOrDefault(m => m.Id == id);

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create([Bind("Id, Name, Email, Username, Password,")] User userModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userModel);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //GET: User/Delete/1
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userModel = _context.MyUsers.FirstOrDefault(m => m.Id == id);
            return View();
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var userModel = _context.MyUsers.Find(id);
            _context.MyUsers.Remove(userModel);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}