using NotesAndContactsApp.Models;

namespace NotesAndContactsApp.Views.Interfaces;

public interface IContactSerializer
{
    void Serialize(IEnumerable<Contacts> contacts, string filePath);
    List<Contacts> Deserialize(string filePath);
}