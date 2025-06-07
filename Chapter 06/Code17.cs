public interface IVegetable
{
    string Name { get; }
}

public interface IFruit : IVegetable
{
    bool HasSeeds { get; }
}

public interface IGreen : IVegetable
{
    bool IsGreen { get; }
}

public class Banana : IFruit
{
    public string Name => "Banana";
    public bool HasSeeds => false;
}

public class Lettuce : IGreen
{
    public string Name => "Lettuce";
    public bool IsGreen => true;
}

public class ShoppingList
{
    public List<IVegetable> Items { get; } = new List<IVegetable>();

    public void AddItem(IVegetable? item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item));
        }

        Items.Add(item);
        switch (item)
        {
            case IFruit fruit:
                Console.WriteLine($"Added fruit: {fruit.Name}, Has seeds: {fruit.HasSeeds}");
                break;
            case IGreen green:
                Console.WriteLine($"Added green: {green.Name}, Is green: {green.IsGreen}");
                break;
            default:
                Console.WriteLine($"Added vegetable: {item.Name}");
                break;
        }
    }
}

// Using the shopping list
var shoppingList = new ShoppingList();
shoppingList.AddItem(new Banana());
shoppingList.AddItem(new Lettuce());