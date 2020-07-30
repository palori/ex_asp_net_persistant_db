# ex_asp_net_persistant_db
Conèixer la persistència de dades i els diferents tipus en ASP.NET i amb MySQL i SQL Server

## Persistència
[Persistència](https://study.com/academy/lesson/object-persistence-definition-overview.html) = no volàtil, encara que es tanqui el procés, reset/shut down... les dades continuen


## Exercici
Les carpetes `empleats` i `frontend_empleats` provenen de l'exercici anterior [**8. Intro to ASP.NET**](https://github.com/palori/ex_intro_asp_net)

I s'han modificat per a connectar el projecte amb una BBDD persistent de MySQL enlloc de treballar amb una BBDD local.

2 ways to do this exercise:
1. SQL Server
2. [My SQL Server](https://github.com/palori/ex_asp_net_persistant_db/MySQL_guides.md)

[ASP.NET Web API guide](https://docs.microsoft.com/es-es/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio-code) used for the previous exercise that includes a useful set of NuGet packages that need to be installed for the project to run.


## Other things to consider

### General info about ASP.NET
[ASP.NET Core tutorials](https://dotnettutorials.net/course/asp-net-core-tutorials/)

### Entity Framework
Great [explanation](https://dotnettutorials.net/lesson/entity-framework-core/) on what it is and how it works.

### Migrations
If you want to know more about [migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli).

### CORS policy
Per a poder executar en el mateix PC s'ha d'havilitar la política del CORS.
(>>> afegir tota la info relacionada que s'ha recopilat)

After some time testing and not working it is a good practice to save all and restart the PC.