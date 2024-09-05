using AutoMapper;
using EFCoreFerro.Services.Services;
using EFCoreFerro2.Datos;
using EFCoresFerro.Web.ViewModels.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Z.PagedList;

namespace Garden2024.Web.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IServicioMarca? _categoriesService;
        private readonly IMapper? _mapper;
        public MarcaController(IServicioMarca? MarcaService,
            IMapper mapper)
        {
            _categoriesService = MarcaService;
            _mapper = mapper;
        }

        public IActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;
            int pageSize = 10;
            var categories = _categoriesService?.GetLista()
                .ToPagedList(pageNumber, pageSize);
            return View(categories);
        }
        public IActionResult UpSert(int? id)
        {
            if (_categoriesService == null || _mapper == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Dependencias no están configuradas correctamente");
            }
            MarcaEditVm categoryVm;
            if (id == null || id == 0)
            {
                categoryVm = new MarcaEditVm();
            }
            else
            {
                try
                {
                    Marca? category = _categoriesService.GetMarcaPorId(id.Value);
                    if (category == null)
                    {
                        return NotFound();
                    }
                    categoryVm = _mapper.Map<MarcaEditVm>(category);
                    return View(categoryVm);
                }
                catch (Exception ex)
                {
                    // Log the exception (ex) here as needed
                    return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the record.");
                }

            }
            return View(categoryVm);

        }


        [HttpPost]
        public IActionResult UpSert(MarcaEditVm categoryVm)
        {
            if (!ModelState.IsValid)
            {
                return View(categoryVm);
            }

            if (_categoriesService == null || _mapper == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Dependencias no están configuradas correctamente");
            }

            try
            {
                Marca category = _mapper.Map<Marca>(categoryVm);

                if (_categoriesService.existe(category))
                {
                    ModelState.AddModelError(string.Empty, "Record already exist");
                    return View(categoryVm);
                }

                _categoriesService.Agregar(category);
                TempData["success"] = "Record successfully added/edited";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                // Log the exception (ex) here as needed
                ModelState.AddModelError(string.Empty, "An error occurred while editing the record.");
                return View(categoryVm);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            if (id is null || id==0)
            {
                return NotFound();
            }
            Marca? category=_categoriesService?.GetMarcaPorId(id.Value);
            if (category is null)
            {
                return NotFound();
            }
            try
            {
                if (_categoriesService == null || _mapper == null)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, "Dependencias no están configuradas correctamente");
                }

                if (_categoriesService.estarelacionado(category.MarcaId))
                {
                    return Json(new { success = false, message="Related Record... Delete Deny!!" }); ;
                }
                _categoriesService.Borrar(category);
                return Json(new { success = true, message = "Record successfully deleted" });
            }
            catch (Exception)
            {

                return Json(new { success = false, message = "Couldn't delete record!!! " }); ;

            }
        }

    }
}
