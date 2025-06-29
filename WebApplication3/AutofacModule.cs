using Autofac;
using Autofac.Extensions.DependencyInjection;
using WebApplication3.Services.Interfaces;
using WebApplication3.Services.Programs;

namespace WebApplication3;

public class AutofacModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        // Явно вкажіть правильні типи
        builder.RegisterType<CocktailService>().As<ICocktailService>();
        builder.RegisterType<ConsoleOutputService>().As<IOutputService>();
        builder.Register(c => new FileOutputService("cocktails.txt")).As<IOutputService>();
    }
}