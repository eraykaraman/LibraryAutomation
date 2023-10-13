using LibraryAutomaiton.Service.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAutomation.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExceptionService _exceptionService;
        private readonly IBookService _bookService;

        public HomeController(ILogger<HomeController> logger, IBookService bookService, IExceptionService exceptionService)
        {

            _bookService = bookService;
            _exceptionService = exceptionService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var data = await _bookService.GetAllBooksWithAuthorsAsync();
                return View(data);
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it."); ;
            }
        }



        public async Task<IActionResult> AboutAsync()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {


                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it."); ;
            }
        }


    }
}