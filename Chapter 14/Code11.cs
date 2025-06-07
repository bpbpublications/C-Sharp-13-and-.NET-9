using Newtonsoft.Json;

Nursery newNursery = new Nursery
{
    Name = "Sunshine Nursery",
    Capacity = 50,
    Facilities = "Various"
};
string json = JsonConvert.SerializeObject(newNursery);
StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
HttpResponseMessage response = await client.PostAsync("http://example.com/api/nurseries", content);
response.EnsureSuccessStatusCode();
// Reading the response body
string responseBody = await response.Content.ReadAsStringAsync();