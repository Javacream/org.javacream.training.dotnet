# org.javacream.training.dotnet

## remote

docker exec -it mssql /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P admin123!
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=admin123!' -p 1433:1433 --name mssql -d mcr.microsoft.com/mssql/server
