namespace NotesAndContactsApp.Models;

public class Note
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime CreationDate { get; set; }
    public List<string> Tags { get; set; } = new();

    public Note(string title, string content, IEnumerable<string>? tags = null)
    {
        Title = title;
        Content = content;
        CreationDate = DateTime.Now;
        if (tags != null)
            Tags.AddRange(tags);
    }
}