using System.Text.Json;
using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Interfaces;

namespace NotesAndContactsApp.Views.Implementations;

public class JsonContactSerializer : IContactSerializer
{
    public void Serialize(IEnumerable<Contacts> contacts, string filePath)
    {
        string json = JsonSerializer.Serialize(contacts);
        File.WriteAllText(filePath, json);
    }

    public List<Contacts> Deserialize(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Contacts>>(json) ?? new List<Contacts>();
    }
}