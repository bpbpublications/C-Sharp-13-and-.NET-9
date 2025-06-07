HttpResponseMessage response = await client.GetAsync("http://example.com/api/nurseries");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
// Deserializing JSON to a list of Nursery objects
var nurseries = JsonConvert.DeserializeObject<List<Nursery>>(responseBody);