using Bibliotheque.App;
using Bibliotheque.Application;
using Bibliotheque.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/*
Mon client de la bibliothèque veut gérer les manga dans sa bibliothèque
L'objectif est de récupérer tout les manga qu'elle à dejà dans sa base donnée
vous devez crée l'entité, le service, le repo et me dire pourquoi et qu'est-ce que ça permet
*/

Console.OutputEncoding = System.Text.Encoding.UTF8;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

builder.Services.AddTransient<MenuConsole>();

using var host = builder.Build();

using (var scope = host.Services.CreateScope())
{
    var menu = scope.ServiceProvider.GetRequiredService<MenuConsole>();
    menu.Run();
}
