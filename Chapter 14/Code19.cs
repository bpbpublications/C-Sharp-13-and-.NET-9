using System.Web.Mvc;

public class BookSchema : System.Xml.Schema
{
    public BookSchema(IDependencyResolver resolver) : base(resolver)
    {
        Query = resolver.Resolve<BookQuery>();
    }
}