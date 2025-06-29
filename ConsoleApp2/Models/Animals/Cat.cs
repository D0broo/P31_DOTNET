using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models.Animals;

public class Cat : AnimalBase
{
    public Cat() : base("Cat") { }

    public override void MakeSound(IOutputService output)
    {
        output.WriteLine("Meow-meow!");
    }
}