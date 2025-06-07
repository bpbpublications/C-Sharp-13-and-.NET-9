Animal myAnimal = new Animal();
Animal myPig = new Pig();
Animal myDog = new Dog();
myAnimal.Sound(); // Outputs: The animal makes a sound
myPig.Sound(); // Outputs: The pig says: wee wee
myDog.Sound(); // Outputs: The dog says: bow wow
public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Pig : Animal
{
    public override void Sound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}