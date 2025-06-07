.. .
builder.Services.AddControllersWithViews();
.. .
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    // Define a route
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
});