public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class BookQuery : ObjectGraphType
{
    public BookQuery()
    {
        Field<BookType>("“book" ”, arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "“title" ”}), resolve: context =>
        {
            var title = context.GetArgument<string>("“title" ”);
            return new Book
            {
                Title = title,
                Author = "“Unknown" ”};
        });
    }
}

public class BookType : ObjectGraphType<Book>
{
    public BookType()
    {
        Field(x => x.Title);
        Field(x => x.Author);
    }
}