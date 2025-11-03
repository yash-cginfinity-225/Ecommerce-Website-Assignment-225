# Copy the Repository and run these commandsi n the DataSeed Folder to setup the DB

* dotnet add package Microsoft.EntityFrameworkCore 
* dotnet add package Microsoft.EntityFrameworkCore.Tools
* dotnet add package Microsoft.EntityFrameworkCore.SqlServer 
* dotnet tool install --global dotnet-ef --version 
* dotnet add package Microsoft.EntityFrameworkCore.Design --version
* dotnet ef migrations add InitialCreate 
* dotnet ef database update

# Once Done Enter the EFDemo folder and run the application
* dotnet run
