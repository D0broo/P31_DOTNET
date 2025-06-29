using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Models.Output;

public class ConsoleOutput : IOutputService
{
    public void Write(string content) => Console.Write(content);
    public void WriteLine(string content) => Console.WriteLine(content);
}