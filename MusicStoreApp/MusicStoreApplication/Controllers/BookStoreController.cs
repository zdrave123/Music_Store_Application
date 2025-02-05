using Microsoft.AspNetCore.Mvc;
using MusicStore.Service.Interface;

namespace MusicStore.Web.Controllers
{
    [Route("bookstore")]
    public class BookStoreController : Controller
    {
        private readonly IBookService _service;

        public BookStoreController(IBookService service)
        {
            _service = service;
        }


        public ActionResult HomePage() 
        {
            return View();
        }

        // View for displaying all books
        [Route("books")]
        public IActionResult Index()
        {
            var books = _service.GetBooks();
            return View(books);
        }

        // View for displaying all bookstores
        [Route("bookstores")]
        public IActionResult BookStores()
        {
            var stores = _service.GetBookStores();
            return View(stores);
        }

        // View for displaying books in stores (combined information)
        [Route("booksinstores")]
        public IActionResult BooksInStores()
        {
            var booksInStores = _service.GetBooksInStores();
            return View(booksInStores);
        }
    }
}
