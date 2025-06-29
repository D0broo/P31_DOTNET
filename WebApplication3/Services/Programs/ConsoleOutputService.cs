using WebApplication3.Services.Interfaces;

namespace WebApplication3.Services.Programs;

public class ConsoleOutputService : IOutputService
{
    public void Output(string content) => Console.WriteLine(content);
}