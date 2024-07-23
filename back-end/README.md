### Building DB


If the is no migration yet, run:
```bash
 cd Project.Infrastucture &&
 dotnet ef migrations add InitialMigration --startup-project ../Project.API/Project.API.csproj
 
```

To build a database. run:
```bash
 cd Project.Infrastucture &&
 dotnet ef database update InitialMigration --startup-project ../Project.API/Project.API.csproj
```