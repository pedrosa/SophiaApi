using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Domain.Entities;
using Infra.Data.Repositories;
using Sophia.ViewModels;

namespace Sophia.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentRepository _studentRepository = new StudentRepository();

        // GET: Students
        public ActionResult Index()
        {
            var studentViewModel = Mapper.Map<IEnumerable<Student>, IEnumerable<StudentViewModel>>(_studentRepository.GetAll());
            return View(studentViewModel);
        }

        //public ActionResult Especiais()
        //{
        //    var studentViewModel = Mapper.Map<IEnumerable<Student>, IEnumerable<StudentViewModel>>(_studentRepository.());

        //    return View(studentViewModel);
        //}

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            var student = _studentRepository.GetById(id);
            var studentViewModel = Mapper.Map<Student, StudentViewModel>(student);

            return View(studentViewModel);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var studentDomain = Mapper.Map<StudentViewModel, Student>(student);
                _studentRepository.Add(studentDomain);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            var student = _studentRepository.GetById(id);
            var studentViewModel = Mapper.Map<Student, StudentViewModel>(student);

            return View(studentViewModel);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentViewModel student)
        {
            if (ModelState.IsValid)
            {
                var studentDomain = Mapper.Map<StudentViewModel, Student>(student);
                _studentRepository.Update(studentDomain);

                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            var student = _studentRepository.GetById(id);
            var studentViewModel = Mapper.Map<Student, StudentViewModel>(student);

            return View(studentViewModel);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var student = _studentRepository.GetById(id);
            _studentRepository.Remove(student);

            return RedirectToAction("Index");
        }
    }
}
