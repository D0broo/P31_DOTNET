namespace NotesAndContactsApp.Models;

public class Contacts
{
    public string Name { get; set; }
    public string MobilePhone { get; set; }
    public string? AlternativeMobilePhone { get; set; }
    public string? Email { get; set; }
    public string? Description { get; set; }

    public Contacts(string name, string mobilePhone, string? alternativeMobilePhone = null, 
        string? email = null, string? description = null)
    {
        Name = name;
        MobilePhone = mobilePhone;
        AlternativeMobilePhone = alternativeMobilePhone;
        Email = email;
        Description = description;
    }
}