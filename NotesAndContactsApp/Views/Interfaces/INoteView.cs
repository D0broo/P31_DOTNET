using NotesAndContactsApp.Models;

namespace NotesAndContactsApp.Views.Interfaces;

public interface INoteView
{
    void Display(Note note);
    void DisplayAll(IEnumerable<Note> notes);
    void SaveToFile(Note note, string filePath);
}