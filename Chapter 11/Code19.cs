public class BestsellerBooksViewComponent : ViewComponent
{
    private readonly IBookRepository _bookRepository; // Assuming an interface for book data operations
    public BestsellerBooksViewComponent(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var bestsellerBooks = await _bookRepository.GetBestsellerBooksAsync(); // Retrieves bestselling books
        return View("BestsellerBooks", bestsellerBooks); // Uses a specific view to render the books
    }
}