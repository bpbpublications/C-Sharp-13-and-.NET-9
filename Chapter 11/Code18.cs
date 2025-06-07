using Microsoft.AspNetCore.Mvc;
using YourAppNamespace.Models;
using System.Collections.Generic; // For using List<>

// Include other necessary namespaces
public class BooksController : Controller
{
    private readonly IBookRepository _bookRepository; // Assuming an interface for data operations
    // Constructor injection for the repository
    public BooksController(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    // GET: Books
    public IActionResult Index()
    {
        var books = _bookRepository.GetAllBooks(); // Retrieves all books from the repository
        return View(books); // Passes the list of books to the view
    }

    // GET: Books/Details/5
    public IActionResult Details(int id)
    {
        var book = _bookRepository.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    // GET: Books/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Books/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Title,Author,ISBN,Price,Genre,Description,PublishDate,StockQuantity")] Book book)
    {
        if (ModelState.IsValid)
        {
            _bookRepository.AddBook(book);
            return RedirectToAction(nameof(Index));
        }

        return View(book);
    }

    // GET: Books/Edit/5
    public IActionResult Edit(int id)
    {
        var book = _bookRepository.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    // POST: Books/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, [Bind("Id,Title,Author,ISBN,Price,Genre,Description,PublishDate,StockQuantity")] Book book)
    {
        if (id != book.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _bookRepository.UpdateBook(book);
            return RedirectToAction(nameof(Index));
        }

        return View(book);
    }

    // GET: Books/Delete/5
    public IActionResult Delete(int id)
    {
        var book = _bookRepository.GetBookById(id);
        if (book == null)
        {
            return NotFound();
        }

        return View(book);
    }

    // POST: Books/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _bookRepository.DeleteBook(id);
        return RedirectToAction(nameof(Index));
    }
}