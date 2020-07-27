﻿using System;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaAppService _pessoaAppService;

        public PessoaController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }

        public ActionResult Index()
        {
            return View(_pessoaAppService.GetAll());
        }

        public ActionResult Details(Guid id)
        {
            var pessoaViewModel = _pessoaAppService.GetById(id);
            return pessoaViewModel.Equals(null) ? (ActionResult) NotFound() : View(pessoaViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) return View(pessoaViewModel);
            _pessoaAppService.Add(pessoaViewModel);
            return RedirectToAction("Index");
        }

        // GET: Pessoa/Edit/5
        public ActionResult Edit(Guid id)
        {
            var pessoaViewModel = _pessoaAppService.GetById(id);
            return pessoaViewModel.Equals(null) ? (ActionResult) NotFound() : View(pessoaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) return View(pessoaViewModel);
            _pessoaAppService.Update(pessoaViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            var pessoaViewModel = _pessoaAppService.GetById(id);
            return pessoaViewModel.Equals(null) ? (ActionResult) NotFound() : View(pessoaViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            _pessoaAppService.Remove(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _pessoaAppService.Dispose();
            base.Dispose(disposing);
        }
    }
}