// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");
Console.Write("Enter 1 to choose dog, 2 to choose pig: ");
int userChoice = Convert.ToInt32(Console.ReadLine());

IAnimal myAnimal;
if (userChoice == 1)
{
    myAnimal = new Dog();
}
else
{
    myAnimal = new Pig();
}

Console.WriteLine($"My type of pet is: {myAnimal.GetType().Name}");
Thread.Sleep(500);
myAnimal.MakeNoise();
Thread.Sleep(500);
myAnimal.Eat();

