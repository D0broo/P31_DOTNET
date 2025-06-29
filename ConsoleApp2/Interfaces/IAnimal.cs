namespace ConsoleApp2.Interfaces;

public interface IAnimal
{
    void DisplayName(IOutputService output);
    void MakeSound(IOutputService output);
}