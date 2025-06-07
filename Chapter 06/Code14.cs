public class Plant : ILivingBeing
{
    public void Breathe()
    {
        Console.WriteLine("Plant is breathing through stomata...");
    }

    public void Grow()
    {
        Console.WriteLine("Plant is growing...");
    }
}

public class Animal : ILivingBeing
{
    public void Breathe()
    {
        Console.WriteLine("Animal is breathing through lungs...");
    }

    public void Grow()
    {
        Console.WriteLine("Animal is growing...");
    }
}