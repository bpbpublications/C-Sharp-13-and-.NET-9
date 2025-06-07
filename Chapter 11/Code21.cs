var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.Use(async (context, next) =>
{
    // Do work that can write to the Response.
    await next.Invoke();
// Do other work that doesn't write to the Response.
});
app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from 2nd delegate.");
});
app.Run()