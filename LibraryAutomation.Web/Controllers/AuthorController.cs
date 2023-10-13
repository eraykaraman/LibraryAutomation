using LibraryAutomaiton.Service.Services.Abstracts;
using LibraryAutomation.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAutomation.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly IExceptionService _exceptionService;

        public AuthorController(IAuthorService authorService, IExceptionService exceptionService)
        {
            _authorService = authorService;
            _exceptionService = exceptionService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var data = await _authorService.GetAllAuthorsAsync();
                return View(data);
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it.");
            }
        }

        public async Task<IActionResult> Create()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it.");
            }


        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {

            try
            {
                await _authorService.AddAsync(author);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it.");
            }

        }
    }
}
