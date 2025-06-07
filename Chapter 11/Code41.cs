app.MapGet("/todos", async (TodoDbContext db) =>
{
    var todos = await db.Todos.ToListAsync();
    return TypedResults.Ok(todos);
});
app.MapGet("/todos/{id}", async (int id, TodoDbContext db) =>
{
    var todo = await db.Todos.FindAsync(id);
    return todo != null ? TypedResults.Ok(todo) : TypedResults.NotFound();
});
app.M