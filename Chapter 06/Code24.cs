// Abstract class LivingBeing
public abstract class LivingBeing
{
    public abstract void Grow();
}

// Class Animal inherits from LivingBeing
public class Animal : LivingBeing
{
    public override void Grow()
    {
        Console.WriteLine("Animals grow by eating food and exercising.");
    }
}

// Class Plant inherits from LivingBeing
public class Plant : LivingBeing
{
    public override void Grow()
    {
        Console.WriteLine("Plants grow by photosynthesis.");
    }
}