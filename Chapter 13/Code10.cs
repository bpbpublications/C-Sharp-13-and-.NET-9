using Microsoft.AspNetCore.Mvc;

[HttpPost]
public IActionResult Emergency(EmergencyModel model)
{
    if (ModelState.IsValid)
    {
        // Process the valid model here (e.g., save data, send response)
        return RedirectToAction("SuccessPage");
    }

    // If the model state is not valid, return the same view with the model to show validation errors
    return View(model);
}