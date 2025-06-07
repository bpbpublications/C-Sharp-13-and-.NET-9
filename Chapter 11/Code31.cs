using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

public class HomeController : Controller
{
    // route to the index page
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public IActionResult Index()
    {
        return View();
    }

    // route with a parameter
    [Route("Home/Details/{id}")]
    public IActionResult Details(int id)
    {
        // logic to handle the details view
        return View();
    }
}