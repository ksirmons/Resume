using Model.IRepositories;
using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Controllers
{
    public class ResumeController : Controller
    {
        //
        // GET: /Resume/
        private IResumeRepository resumeRepository;

        public ResumeController() { }

        public ResumeController(IResumeRepository resumeRepository)
        {
            this.resumeRepository = resumeRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Resume/Details/5

        public ActionResult Details(int id)
        {
            var resumeVm = AutoMapper.Mapper.Map<ResumeViewModel>(resumeRepository.GetResumeById(id));
            return View(resumeVm);
        }

        //
        // GET: /Resume/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Resume/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Resume/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Resume/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Resume/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Resume/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
