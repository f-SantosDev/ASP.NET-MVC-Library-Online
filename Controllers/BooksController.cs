using ASP_Net_MVC_Library_Online.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Net_MVC_Library_Online.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.BooksDB);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                Repository.Insert(book);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Update(int identifier)
        {
            Book search = Repository.BooksDB.Where((r) => r.ID == identifier).First();
            return View(search);
        }

        [HttpPost]
        public IActionResult Update(int identifier, Book book)
        {
            if (ModelState.IsValid)
            {
                var searchBook = Repository.BooksDB.Where((r) => r.ID == identifier).First();

                searchBook.Title = book.Title;
                searchBook.Author = book.Author;
                searchBook.YearOfPublish = book.YearOfPublish;
                searchBook.Genre = book.Genre;

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int identifier)
        {
            Book searchBook = Repository.BooksDB.Where((r) => r.ID == identifier).First();
            
            if (searchBook != null)
            {
                Repository.Delete(searchBook);
            }

            return RedirectToAction("Index");
        }

        public IActionResult ConfirmDelete(int identifier)
        {
            Book searchBook = Repository.BooksDB.Where((r) => r.ID == identifier).First();

            if (searchBook == null)
            {
                return NotFound();
            }
            return View(searchBook);
        }

        public IActionResult Details(int identifier)
        {
            Book search = Repository.BooksDB.Where((r) => r.ID == identifier).First();
            return View(search);
        }
    }
}
