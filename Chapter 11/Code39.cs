using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}