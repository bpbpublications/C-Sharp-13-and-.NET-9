using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddTransient<ITransientService, TransientService>();
services.AddScoped<IScopedService, ScopedService>();
services.AddSingleton<ISingletonService, SingletonService>();
var serviceProvider = services.BuildServiceProvider();
// Simulate two separate requests
using (var scope1 = serviceProvider.CreateScope())
{
    var scopedService1 = scope1.ServiceProvider.GetRequiredService<IScopedService>();
    Console.WriteLine($"Scoped Service 1 ID: {scopedService1.GetOperationID()}");
    var transientService1 = scope1.ServiceProvider.GetRequiredService<ITransientService>();
    Console.WriteLine($"Transient Service 1 ID: {transientService1.GetOperationID()}");
}

using (var scope2 = serviceProvider.CreateScope())
{
    var scopedService2 = scope2.ServiceProvider.GetRequiredService<IScopedService>();
    Console.WriteLine($"Scoped Service 2 ID: {scopedService2.GetOperationID()}");
    var transientService2 = scope2.ServiceProvider.GetRequiredService<ITransientService>();
    Console.WriteLine($"Transient Service 2 ID: {transientService2.GetOperationID()}");
}

var singletonService = serviceProvider.GetRequiredService<ISingletonService>();
Console.WriteLine($"Singleton Service ID: {singletonService.GetOperationID()}");
Console.ReadKey();