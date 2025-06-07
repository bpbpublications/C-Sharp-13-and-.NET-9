using System.Text.Json;

string jsonText = """
[
{"id": 1, "customer_name": "Alice", "profession": "Doctor"},
{"id": 2, "customer_name": "Bob", "profession": "Engineer"},
{"id": 3, "customer_name": "Charlie", "profession": "Lawyer"},
{"id": 4, "customer_name": "David", "profession": "Secretary"},
{"id": 5, "customer_name": "Eve", "profession": "Doctor"},
{"id": 6, "customer_name": "Frank", "profession": "Engineer"},
{"id": 7, "customer_name": "Grace", "profession": "Lawyer"},
{"id": 8, "customer_name": "Hannah", "profession": "Secretary"},
{"id": 9, "customer_name": "Isaac", "profession": "Doctor"},
{"id": 10, "customer_name": "Jack", "profession": "Engineer"},
{"id": 11, "customer_name": "Anna", "profession": "Secretary"},
{"id": 12, "customer_name": "Andrew", "profession": "Secretary"}
]
""";
List<Customer> customers = JsonSerializer.Deserialize<List<Customer>>(jsonText);
var groupedCustomers =
    from c in customers
    group c by c.profession into professionGroup
        select new
        {
            Profession = professionGroup.Key,
            Count = professionGroup.Count()
        };
foreach (var group in groupedCustomers)
{
    Console.WriteLine($"Profession: {group.Profession}, Count: {group.Count}");
}

class Customer
{
    public int id { get; set; }
    public string customer_name { get; set; }
    public string profession { get; set; }
}