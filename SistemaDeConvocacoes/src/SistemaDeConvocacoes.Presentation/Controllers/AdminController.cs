﻿using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly IAdminAppService _adminAppService;

        public AdminController(IAdminAppService adminAppService)
        {
            _adminAppService = adminAppService;
        }

        // GET: Admin2ViewModel
        public ActionResult Index()
        {
            return View(_adminAppService.GetAll());
        }

        // GET: Admin2ViewModel/Details/5
        public ActionResult Details(Guid id)
        {
            var admin2ViewModel = _adminAppService.GetById(id);
            return admin2ViewModel == null ? (ActionResult) NotFound() : View(admin2ViewModel);
        }

        // GET: Admin2ViewModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin2ViewModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Admin2ViewModel admin2ViewModel)
        {
            if (ModelState.IsValid)
            {
                admin2ViewModel.AdminId = Guid.NewGuid();
                _adminAppService.Add(admin2ViewModel);
                return RedirectToAction("Index");
            }

            return View(admin2ViewModel);
        }

        // GET: Admin2ViewModel/Edit/5
        public ActionResult Edit(Guid id)
        {
            var admin2ViewModel = _adminAppService.GetById(id);
            return admin2ViewModel == null ? (ActionResult) NotFound() : View(admin2ViewModel);
        }

        // POST: Admin2ViewModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Admin2ViewModel admin2ViewModel)
        {
            if (ModelState.IsValid)
            {
                _adminAppService.Update(admin2ViewModel);
                return RedirectToAction("Index");
            }

            return View(admin2ViewModel);
        }

        // GET: Admin2ViewModel/Delete/5
        public ActionResult Delete(Guid id)
        {
            var admin2ViewModel = _adminAppService.GetById(id);
            if (admin2ViewModel == null) return NotFound();
            return View(admin2ViewModel);
        }

        // POST: Admin2ViewModel/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _adminAppService.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _adminAppService.Dispose();
            base.Dispose(disposing);
        }
    }
}