using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SistemaDeConvocacoes.Application.Interfaces.Services;
using SistemaDeConvocacoes.Application.ViewModels;

namespace SistemaDeConvocacoes.Presentation.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class CargoController : Controller
    {
        private readonly ICargoAppService _cargoAppService;
        private readonly IProcessoAppService _processoAppService;

        public CargoController(ICargoAppService cargoAppService, IProcessoAppService processoAppService)
        {
            _cargoAppService = cargoAppService;
            _processoAppService = processoAppService;
        }

        // GET: Cargo
        public async Task<IActionResult> Index(Guid id)
        {
            ViewBag.id = id;
            ViewBag.ProcessoId = id;
            ViewBag.DadosProcesso = await _processoAppService.GetByIdAsync(id);
            var cargos = _cargoAppService.GetAllAsync().Result.OrderBy(a => a.CodigoCargo);
            return View(cargos);
        }

        // GET: Cargo/Details/5
        public async Task<IActionResult> Details(Guid? id, Guid ProcessoId)
        {
            ViewBag.Id = ProcessoId;
            ViewBag.ProcessoId = ProcessoId;

            if (id.Equals(null)) 
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var cargoViewModel = await _cargoAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            return View(cargoViewModel);
        }

        // GET: Cargo/Create
        public async Task<IActionResult> Create(Guid Id)
        {
            ViewBag.id = Id;
            ViewBag.ProcessoId = Id;
            ViewBag.dadosProcesso = await _processoAppService.GetByIdAsync(Id);
            return View();
        }

        // POST: Cargo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync(CargoViewModel cargoViewModel)
        {
            ViewBag.ProcessoId = cargoViewModel.ProcessoId;

            if (!ModelState.IsValid) 
                return View(cargoViewModel);

            cargoViewModel.CargoId = Guid.NewGuid();

            await _cargoAppService.AddAsync(cargoViewModel);

            return RedirectToAction("Index", new {Id = cargoViewModel.ProcessoId});
        }

        // GET: Cargo/Edit/5
        public async Task<IActionResult> EditAsync(Guid? id)
        {           
            if (id.Equals(null)) 
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var cargoViewModel = await _cargoAppService.GetByIdAsync(Guid.Parse(id.ToString()));
            ViewBag.ProcessoId = cargoViewModel.ProcessoId;

            return View(cargoViewModel);
        }

        // POST: Cargo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync(CargoViewModel cargoViewModel)
        {
            ViewBag.ProcessoId = cargoViewModel.ProcessoId;

            if (!ModelState.IsValid) 
                return View(cargoViewModel);

            await _cargoAppService.UpdateAsync(cargoViewModel);

            return RedirectToAction("Index", new {Id = cargoViewModel.ProcessoId});
        }

        // GET: Cargo/Delete/5
        public async Task<IActionResult> Delete(Guid? id, Guid ProcessoId)
        {
            ViewBag.Id = ProcessoId;
            ViewBag.ProcessoId = ProcessoId;

            if (id.Equals(null)) 
                return new StatusCodeResult((int)HttpStatusCode.BadRequest);

            var cargoViewModel = await _cargoAppService.GetByIdAsync(Guid.Parse(id.ToString()));

            return View(cargoViewModel);
        }

        // POST: Cargo/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedAsync(Guid id)
        {
           await _cargoAppService.RemoveAsync(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                _cargoAppService.Dispose();

            base.Dispose(disposing);
        }
    }
}