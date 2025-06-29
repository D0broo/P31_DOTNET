using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models.Animals;

public class Cow : AnimalBase
{
    public Cow() : base("Cow") { }

    public override void MakeSound(IOutputService output)
    {
        output.WriteLine("Moo-moo!");
    }
}