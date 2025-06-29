using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using WebApplication3;
using WebApplication3.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Додаємо Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder.RegisterModule<AutofacModule>();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/cocktail", (
    [FromServices] ICocktailService cocktailService,
    [FromServices] IEnumerable<IOutputService> outputServices) =>
{
    foreach (var output in outputServices)
    {
        output.Output("=== Short Info ===");
        output.Output(cocktailService.GetShortInfo());
        output.Output("=== Full Info ===");
        output.Output(cocktailService.GetFullInfo());
    }
    
    return Results.Ok("Cocktail information processed");
});

app.Run();