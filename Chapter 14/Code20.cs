using System;
using System.Net.Http;
using System.Threading.Tasks;

using HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("http://example.com");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseBody);