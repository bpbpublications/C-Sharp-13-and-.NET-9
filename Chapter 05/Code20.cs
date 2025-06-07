public class Product
{
    private string name;
    public string Name { get => name; private set => name = value; }

    public Product(string name)
    {
        this.Name = name;
    }
}