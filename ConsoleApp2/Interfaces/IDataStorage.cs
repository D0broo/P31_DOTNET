namespace ConsoleApp2.Interfaces;

public interface IDataStorage
{
    void SaveAnimals(IEnumerable<IAnimal> animals, string filePath);
    IEnumerable<IAnimal> LoadAnimals(string filePath);
}