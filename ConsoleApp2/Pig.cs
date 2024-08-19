namespace ConsoleApp2;

public class Pig : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("Pig is eating!");
    }

    public void MakeNoise()
    {
        Console.WriteLine("Pig is making noise!");
    }
}