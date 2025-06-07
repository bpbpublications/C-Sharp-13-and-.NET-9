.. .
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
otherwise 
    app.UseExceptionHandler("/Error"); // Other options...
app.UseRouting();
app.MapControllerRoute(name: "default", pattern: "controller=Home/action=Index/id? ");
.. .
