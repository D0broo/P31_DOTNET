using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models.Animals;

public abstract class AnimalBase : IAnimal
{
    private string Name { get; }

    public AnimalBase(string name)
    {
        Name = name;
    }

    public virtual void DisplayName(IOutputService output)
    {
        output.WriteLine($"Animal: {Name}");
    }

    public abstract void MakeSound(IOutputService output);
}