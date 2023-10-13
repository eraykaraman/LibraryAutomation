using LibraryAutomaiton.Service.Services.Abstracts;
using LibraryAutomation.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAutomation.Web.Controllers
{
    public class RentController : Controller
    {
        private readonly IRentService _rentService;
        private readonly IBookService _bookService;
        private readonly IExceptionService _exceptionService;
        public RentController(IRentService rentService, IBookService bookService, IExceptionService exceptionService)
        {
            _rentService = rentService;
            _bookService = bookService;
            _exceptionService = exceptionService;
        }

        public async Task<IActionResult> Index()
        {

            try
            {
                var data = await _rentService.GetAllRentsAsync();
                return View(data);
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it.");

            }
        }

        [Route("rent/{bookId:guid}")]
        [HttpGet]
        public async Task<IActionResult> RentPageAsync(Guid bookId)
        {
            try
            {
                var rentModel = new Rent
                {
                    BookId = bookId,
                };
                return View(rentModel);
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Rent(Rent rent)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _rentService.AddAsync(rent);

                    var book = await _bookService.GetByIdAsync(rent.BookId);
                    book.IsAvailable = false;
                    await _bookService.SaveAsync();


                    return RedirectToAction("Index", "Home");
                }
                return View("Index", "Home");
            }
            catch (Exception ex)
            {

                _exceptionService.Message = ex.Message;
                await _exceptionService.LogExceptionAsync();
                return Content("Something went wrong. We'll be fixing it.");
            }
        }

        public async Task<IActionResult> Remove(Guid id)
        {
            try
            {
                var rent = await _rentService.GetByIdAsync(id);
                await _rentService.RemoveAsync(id);
                var book = await _bookService.GetByIdAsync(rent.BookId);
                book.IsAvailable = true;
                await _bookService.SaveAsync();
                return RedirectToAction("Index", "Home");
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
