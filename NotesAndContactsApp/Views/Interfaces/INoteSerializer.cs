using NotesAndContactsApp.Models;

namespace NotesAndContactsApp.Views.Interfaces;

public interface INoteSerializer
{
    void Serialize(IEnumerable<Note> notes, string filePath);
    List<Note> Deserialize(string filePath);
}