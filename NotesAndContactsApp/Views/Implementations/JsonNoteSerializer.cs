using System.Text.Json;
using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Interfaces;

namespace NotesAndContactsApp.Views.Implementations;

public class JsonNoteSerializer : INoteSerializer
{
    public void Serialize(IEnumerable<Note> notes, string filePath)
    {
        string json = JsonSerializer.Serialize(notes);
        File.WriteAllText(filePath, json);
    }

    public List<Note> Deserialize(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<List<Note>>(json) ?? new List<Note>();
    }
}