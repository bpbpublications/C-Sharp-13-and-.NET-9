using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Price")] Product product)
{
    if (id != product.Id)
    {
        return NotFound();
    }

    if (!ModelState.IsValid)
        return View(product);
    var client = clientFactory.CreateClient();
    var content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");
    var response = await client.PutAsync($"http://localhost:5074/api/products/{id}", content);
    if (response.IsSuccessStatusCode)
    {
        return RedirectToAction(nameof(Index));
    }

    if (response.StatusCode == HttpStatusCode.NotFound)
    {
        return NotFound();
    }

    return View(product);
}