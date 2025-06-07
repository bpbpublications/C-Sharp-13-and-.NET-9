using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using HttpClient client = new HttpClient();
var content = new StringContent("{\"name\":\"John Doe\"}", Encoding.UTF8, "application/json");
HttpResponseMessage response = await client.PostAsync("http://example.com/api/users", content);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseBody);