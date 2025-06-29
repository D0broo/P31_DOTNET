using System.Text.Json;
using ConsoleApp2.Interfaces;
using ConsoleApp2.Models.Animals;

namespace ConsoleApp2.Services;

public class JsonStorage : IDataStorage
{
    public void SaveAnimals(IEnumerable<IAnimal> animals, string filePath)
    {
        var animalData = animals.Select(a => new { Type = a.GetType().Name, Name = a.GetType().Name }).ToList();
        var json = JsonSerializer.Serialize(animalData);
        File.WriteAllText(filePath, json);
    }

    public IEnumerable<IAnimal> LoadAnimals(string filePath)
    {
        if (!File.Exists(filePath))
            return Enumerable.Empty<IAnimal>();

        var json = File.ReadAllText(filePath);
        var animalData = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(json);
        
        if (animalData == null)
            return Enumerable.Empty<IAnimal>();

        var animals = new List<IAnimal>();
        foreach (var data in animalData)
        {
            IAnimal animal = data["Type"] switch
            {
                "Dog" => new Dog(),
                "Cat" => new Cat(),
                "Cow" => new Cow(),
                _ => throw new NotSupportedException($"Animal type {data["Type"]} is not supported")
            };
            animals.Add(animal);
        }
        return animals;
    }
}