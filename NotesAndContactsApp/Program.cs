using NotesAndContactsApp.Controllers;
using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Implementations;
using NotesAndContactsApp.Views.Interfaces;

// Налаштування Dependency Injection
IContactView contactView = new ConsoleContactsView();
IContactSerializer contactSerializer = new JsonContactSerializer();
var contactController = new ContactController(contactView, contactSerializer);

// Приклад використання
var contacts = new List<Contacts>
{
    new Contacts("John Doe", "+380991234567", "+380631234567", "john@example.com", "Friend"),
    new Contacts("Jane Smith", "+380971234567", null, "jane@example.com", "Colleague")
};

Console.WriteLine("All Contacts:");
contactController.DisplayAllContacts(contacts);

// Збереження та завантаження
contactController.SaveContactsToFile(contacts, "contacts.json");
var loadedContacts = contactController.LoadContactsFromFile("contacts.json");
Console.WriteLine("\nLoaded Contacts:");
contactController.DisplayAllContacts(loadedContacts);