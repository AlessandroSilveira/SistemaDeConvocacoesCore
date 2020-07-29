using System;
using System.Threading.Tasks;
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

        public async Task<IActionResult> IndexAsync()
        {
            return View(await _pessoaAppService.GetAllAsync());
        }

        public async Task<IActionResult> DetailsAsync(Guid id)
        {
            var pessoaViewModel = await _pessoaAppService.GetByIdAsync(id);

            return pessoaViewModel.Equals(null) ? (ActionResult) NotFound() : View(pessoaViewModel);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) 
                return View(pessoaViewModel);

            await _pessoaAppService.AddAsync(pessoaViewModel);

            return RedirectToAction("Index");
        }

        // GET: Pessoa/Edit/5
        public async Task<IActionResult> EditAsync(Guid id)
        {
            var pessoaViewModel = await _pessoaAppService.GetByIdAsync(id);

            return pessoaViewModel.Equals(null) ? (IActionResult) NotFound() : View(pessoaViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) 
                return View(pessoaViewModel);

            await _pessoaAppService.UpdateAsync(pessoaViewModel);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var pessoaViewModel = await _pessoaAppService.GetByIdAsync(id);
            return pessoaViewModel.Equals(null) ? (ActionResult) NotFound() : View(pessoaViewModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
           await _pessoaAppService.RemoveAsync(id);
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