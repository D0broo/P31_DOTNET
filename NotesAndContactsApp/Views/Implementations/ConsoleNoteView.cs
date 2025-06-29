using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Interfaces;

namespace NotesAndContactsApp.Views.Implementations;

public class ConsoleNoteView : INoteView
{
    public void Display(Note note)
    {
        Console.WriteLine($"Title: {note.Title}");
        Console.WriteLine($"Content: {note.Content}");
        Console.WriteLine($"Created: {note.CreationDate}");
        Console.WriteLine($"Tags: {string.Join(", ", note.Tags)}");
    }

    public void DisplayAll(IEnumerable<Note> notes)
    {
        foreach (var note in notes)
        {
            Display(note);
            Console.WriteLine("------------------");
        }
    }

    public void SaveToFile(Note note, string filePath)
    {
        string content = $"Title: {note.Title}\nContent: {note.Content}\nCreated: {note.CreationDate}\nTags: {string.Join(", ", note.Tags)}";
        File.WriteAllText(filePath, content);
    }
}