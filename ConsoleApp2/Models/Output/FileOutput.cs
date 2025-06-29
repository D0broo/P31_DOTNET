using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models.Output;

public class FileOutput : IOutputService
{
    private readonly string _filePath;

    public FileOutput(string filePath)
    {
        _filePath = filePath;
    }

    public void Write(string content) => File.AppendAllText(_filePath, content);
    public void WriteLine(string content) => File.AppendAllLines(_filePath, new[] { content });
}