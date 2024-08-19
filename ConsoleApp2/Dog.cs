namespace ConsoleApp2;

public class Dog : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Dog is eating");
    }

    public void MakeNoise()
    {
        Console.WriteLine("Dog is making noise");
    }
}