public interface IMammal : ILivingBeing
{
    void FeedMilk();
}

public class Human : IMammal
{
    public void Breathe()
    {
        Console.WriteLine("Human is breathing through lungs...");
    }

    public void Grow()
    {
        Console.WriteLine("Human is growing...");
    }

    public void FeedMilk()
    {
        Console.WriteLine("Human is feeding milk to the child...");
    }
}