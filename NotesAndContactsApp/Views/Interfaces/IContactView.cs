using NotesAndContactsApp.Models;

namespace NotesAndContactsApp.Views.Interfaces;

public interface IContactView
{
    void Display(Contacts contact);
    void DisplayAll(IEnumerable<Contacts> contacts);
    void SaveToFile(Contacts contact, string filePath);
}