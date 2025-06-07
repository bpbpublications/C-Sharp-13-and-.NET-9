using OrthopedicClinic.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.Services.AddScoped<PatientService>();
await builder.Build().RunAsync();