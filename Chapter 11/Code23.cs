.. .
app.UseRouting();
ShortCircuitsConfig(app);
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

.. .
static void ShortCircuitsConfig(WebApplication app)
{
    app.MapGet("/Redirect/Contoso", (context) =>
    {
        context.Response.Redirect("https://www.contoso.com/");
        return Task.CompletedTask;
    }).ShortCircuit(200);
    app.MapGet("/KeyPage", (context) =>
    {
        context.Response.Redirect("https://www.contoso.com/KeyPage");
        return Task.CompletedTask;
    }).ShortCircuit(200);
    app.MapGet("/", (context) =>
    {
        context.Response.Redirect("https://www.contoso.com/Info");
        return Task.CompletedTask;
    }).ShortCircuit(200);
    app.MapGet("/robots.txt", () => @"
User-agent: *
Disallow: /
").ShortCircuit(200);
}