using AutoMapper;
using Model.IRepositories;
using Resume.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resume.Web.Controllers
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
            var indexViewModel = new ResumeIndexViewModel();
            indexViewModel.ResumeItems = Mapper.Map<IEnumerable<ResumeIndexItemViewModel>>(this.resumeRepository.All());
            return View(indexViewModel);
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
            var createModel = new ResumeCreateModel();
            return View(createModel);
        }

        //
        // POST: /Resume/Create

        [HttpPost]
        public ActionResult Create(ResumeCreateModel createModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Model.Resume createResume = new Model.Resume();
                    createResume.Name = createModel.Name;

                    resumeRepository.AddOrUpdateResume(createResume);

                    resumeRepository.Save();

                    return RedirectToAction("Edit", new { id = createResume.Id });
                }
                else
                {
                    return View(createModel);
                }
            }
            catch
            {
                return View(createModel);
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
