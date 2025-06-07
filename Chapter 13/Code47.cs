using Microsoft.AspNetCore.Mvc;

public async Task<IActionResult> Edit(int? id)
{
    if (id == null)
    {
        return NotFound();
    }

    var request = new HttpRequestMessage(HttpMethod.Get, $"http://localhost:5074/api/products/{id}");
    var client = clientFactory.CreateClient();
    var response = await client.SendAsync(request);
    if (!response.IsSuccessStatusCode)
        return NotFound();
    var jsonString = await response.Content.ReadAsStringAsync();
    var product = JsonConvert.DeserializeObject<Product>(jsonString);
    return View(product);
}