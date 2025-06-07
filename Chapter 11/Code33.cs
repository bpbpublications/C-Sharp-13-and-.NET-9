[Authorize(Roles = "Administrator")]
public IActionResult AdminDashboard()
{
    return View();
}