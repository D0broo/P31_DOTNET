using NotesAndContactsApp.Models;
using NotesAndContactsApp.Views.Interfaces;

namespace NotesAndContactsApp.Views.Implementations;

public class ConsoleContactsView : IContactView
{
    public void Display(Contacts contact)
    {
        Console.WriteLine($"Name: {contact.Name}");
        Console.WriteLine($"Mobile Phone: {contact.MobilePhone}");
        Console.WriteLine($"Alternative Mobile: {contact.AlternativeMobilePhone ?? "N/A"}");
        Console.WriteLine($"Email: {contact.Email ?? "N/A"}");
        Console.WriteLine($"Description: {contact.Description ?? "N/A"}");
    }

    public void DisplayAll(IEnumerable<Contacts> contacts)
    {
        foreach (var contact in contacts)
        {
            Display(contact);
            Console.WriteLine("------------------");
        }
    }

    public void SaveToFile(Contacts contact, string filePath)
    {
        string content = $"Name: {contact.Name}\n" +
                         $"Mobile Phone: {contact.MobilePhone}\n" +
                         $"Alternative Mobile: {contact.AlternativeMobilePhone ?? "N/A"}\n" +
                         $"Email: {contact.Email ?? "N/A"}\n" +
                         $"Description: {contact.Description ?? "N/A"}";
        File.WriteAllText(filePath, content);
    }
}