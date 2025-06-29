using ConsoleApp2.Interfaces;
using ConsoleApp2.Models.Animals;
using ConsoleApp2.Models.Output;
using ConsoleApp2.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

// Реєстрація сервісів
services.AddTransient<IOutputService, ConsoleOutput>();
services.AddTransient<IDataStorage, JsonStorage>();
services.AddTransient<IAnimal, Dog>();
services.AddTransient<IAnimal, Cat>();
services.AddTransient<IAnimal, Cow>();

var provider = services.BuildServiceProvider();

// Використання
var output = provider.GetRequiredService<IOutputService>();
var animals = provider.GetServices<IAnimal>().ToList();
var storage = provider.GetRequiredService<IDataStorage>();

output.WriteLine("=== All Animals ===");
foreach (var animal in animals)
{
    animal.DisplayName(output);
    animal.MakeSound(output);
    output.WriteLine("------");
}

string filePath = "animals.json";
storage.SaveAnimals(animals, filePath);
output.WriteLine($"Animals saved to {filePath}");

var loadedAnimals = storage.LoadAnimals(filePath);
output.WriteLine("\n=== Loaded Animals ===");
foreach (var animal in loadedAnimals)
{
    animal.DisplayName(output);
    animal.MakeSound(output);
    output.WriteLine("------");
}