// Index.cshtml.cs
public class IndexModel : PageModel
{
    public string Message { get; set; }

    public void OnGet()
    {
        Message = "My application description page.";
    }
}