using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models.Animals;

public class Dog : AnimalBase
{
    public Dog() : base("Dog") { }

    public override void MakeSound(IOutputService output)
    {
        output.WriteLine("Woof-woof!");
    }
}