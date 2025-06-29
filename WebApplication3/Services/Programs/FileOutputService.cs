using WebApplication3.Services.Interfaces;

namespace WebApplication3.Services.Programs;

public class FileOutputService : IOutputService
{
    private readonly string _filePath;
    
    public FileOutputService(string filePath) => _filePath = filePath;
    
    public void Output(string content) => File.AppendAllText(_filePath, content + Environment.NewLine);
}