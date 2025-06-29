using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Interfaces;

namespace NotesAndContactsApp.Controllers;

public class NoteController
{
    private readonly INoteView _view;
    private readonly INoteSerializer _serializer;

    public NoteController(INoteView view, INoteSerializer serializer)
    {
        _view = view;
        _serializer = serializer;
    }

    public void DisplayNote(Note note) => _view.Display(note);
    public void DisplayAllNotes(IEnumerable<Note> notes) => _view.DisplayAll(notes);
    public void SaveNoteToFile(Note note, string filePath) => _view.SaveToFile(note, filePath);

    // Нові методи для серіалізації
    public void SaveNotesToFile(IEnumerable<Note> notes, string filePath) 
        => _serializer.Serialize(notes, filePath);

    public List<Note> LoadNotesFromFile(string filePath) 
        => _serializer.Deserialize(filePath);
}