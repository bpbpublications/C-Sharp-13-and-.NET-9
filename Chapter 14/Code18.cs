app.UseGraphQL<ISchema>();
app.UseGraphQLPlayground(new GraphQLPlaygroundOptions()); // to use Playground
builder.Services.AddScoped<IdependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
builder.Services.AddScoped<BookQuery>();
builder.Services.AddScoped<Ischema, BookSchema>();
builder.Services.AddGraphQL(o =>
{
    o.ExposeExceptions = false;
}).AddGraphTypes(ServiceLifetime.Scoped);