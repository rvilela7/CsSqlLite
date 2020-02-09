https://docs.microsoft.com/en-us/ef/core/get-started/

### Migrations
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update

### DI
https://dzone.com/articles/dependency-injection-in-net-core-console-applicati