using System;
using System.Threading.Tasks;
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
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _adminAppService.GetAllAsync());
        }

        // GET: Admin2ViewModel/Details/5
        public async Task<IActionResult> DetailsAsync(Guid id)
        {
            var admin2ViewModel = await _adminAppService.GetByIdAsync(id);

            return admin2ViewModel == null ? (IActionResult) NotFound() : View(admin2ViewModel);
        }

        // GET: Admin2ViewModel/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin2ViewModel/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(Admin2ViewModel admin2ViewModel)
        {
            if (ModelState.IsValid)
            {
                admin2ViewModel.AdminId = Guid.NewGuid();
                await _adminAppService.AddAsync(admin2ViewModel);

                return RedirectToAction("Index");
            }

            return View(admin2ViewModel);
        }

        // GET: Admin2ViewModel/Edit/5
        public async Task<IActionResult> EditAsync(Guid id)
        {
            var admin2ViewModel = await _adminAppService.GetByIdAsync(id);

            return admin2ViewModel == null ? (IActionResult) NotFound() : View(admin2ViewModel);
        }

        // POST: Admin2ViewModel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(Admin2ViewModel admin2ViewModel)
        {
            if (ModelState.IsValid)
            {
                await _adminAppService.UpdateAsync(admin2ViewModel);

                return RedirectToAction("Index");
            }

            return View(admin2ViewModel);
        }

        // GET: Admin2ViewModel/Delete/5
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var admin2ViewModel = await _adminAppService.GetByIdAsync(id);

            if (admin2ViewModel == null) 
                return NotFound();

            return View(admin2ViewModel);
        }

        // POST: Admin2ViewModel/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
            await _adminAppService.RemoveAsync(id);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _adminAppService.Dispose();

            base.Dispose(disposing);
        }
    }
}