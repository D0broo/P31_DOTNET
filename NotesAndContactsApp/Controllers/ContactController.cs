using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Interfaces;

namespace NotesAndContactsApp.Controllers;

public class ContactController
{
    private readonly IContactView _view;
    private readonly IContactSerializer _serializer;

    public ContactController(IContactView view, IContactSerializer serializer)
    {
        _view = view;
        _serializer = serializer;
    }

    public void DisplayContact(Contacts contact) => _view.Display(contact);
    public void DisplayAllContacts(IEnumerable<Contacts> contacts) => _view.DisplayAll(contacts);
    public void SaveContactToFile(Contacts contact, string filePath) => _view.SaveToFile(contact, filePath);

    public void SaveContactsToFile(IEnumerable<Contacts> contacts, string filePath) 
        => _serializer.Serialize(contacts, filePath);

    public List<Contacts> LoadContactsFromFile(string filePath) 
        => _serializer.Deserialize(filePath);
}