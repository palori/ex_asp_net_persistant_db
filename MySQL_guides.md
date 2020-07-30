# Guides to connect to My SQL Server

[How to connect MySQL with ASP.NET Core](https://www.c-sharpcorner.com/article/how-to-connect-mysql-with-asp-net-core/)

1. Create a database (schema) called _your-database_ (in my case _empleats_) in MySQL Workbench
2. Create or copy an ASP.NET project. We already have the Models, but you can create yours now in the _Models_ folder. In my case: _Empleats.cs_ and _EmpleatsContext.cs_
3. Install the NuGet Package `MySQL.Data` from Oracle in VS (Also tried with comand line in VScode [dotnet nuget add source MySQL.Data](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-nuget-add-source), it now appears if running `dotnet nuget list source`)
4. Add this code to `appsettings.json`. In my case: _your-database_ = _empleats_
```json
{
    "ConnectionStrings": {    // added to connect to MySQL Server
        "DefaultConnection": "server=localhost;port=3306;database=your-database;user=root;password=your-pwd"
    }
}
```
In case of remote, we need to update the connection string with an appropriate server name and the port name. And probably remove the CORS policy (see below).

---

`WIP...`

[Oracle or Pomelo library](https://dev.to/ruben_j/using-mysql-with-entity-framework-core-and-asp-net-core-1010) to UseMySQL()