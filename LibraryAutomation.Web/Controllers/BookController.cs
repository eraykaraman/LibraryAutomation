using LibraryAutomaiton.Service.Services.Abstracts;
using LibraryAutomation.Entity.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryAutomation.Web.Controllers
{

    public class BookController : Controller
    {

        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;
        private readonly IRentService _rentService;
        private readonly IExceptionService _exceptionService;

        public BookController(IBookService bookService, IAuthorService authorService, IRentService rentService, IExceptionService exceptionService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _rentService = rentService;
            _exceptionService = exceptionService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            try
            {
                return RedirectToAction("Index", "Home");
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
                var authors = await _authorService.GetAllAuthorsAsync();
                var authorList = authors.Select(author => new SelectListItem
                {
                    Value = author.Id.ToString(),
                    Text = $"{author.Name} {author.LastName}"
                }).ToList();

                ViewBag.Authors = authorList;

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
        public async Task<IActionResult> Create(Book book)
        {

            try
            {
                await _bookService.AddAsync(book);
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
