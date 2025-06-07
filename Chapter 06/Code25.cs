// Interface
public interface ILivingBeing
{
    void Grow();
}

// Class Animal implements ILivingBeing
public class Animal : ILivingBeing
{
    public void Grow()
    {
        Console.WriteLine("Animals grow by eating food and exercising.");
    }
}

// Class Plant implements ILivingBeing
public class Plant : ILivingBeing
{
    public void Grow()
    {
        Console.WriteLine("Plants grow by photosynthesis.");
    }
}