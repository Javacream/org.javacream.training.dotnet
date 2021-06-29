# install EF Tools

* dotnet tool install --global dotnet-ef
* export PATH="$PATH:/home/vscode/.dotnet/tools"
* dotnet ef --version

# install dependencies

* dotnet add package Microsoft.EntityFrameworkCore.SqlServer
* dotnet add package Microsoft.EntityFrameworkCore.Design
* dotnet add package Microsoft.EntityFrameworkCore.Tools

# Migrations

* dotnet ef migrations add CreatePeopleDb
* dotnet ef database update
