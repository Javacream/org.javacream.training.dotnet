## push

* dotnet pack
* dotnet nuget push bin/Debug/BooksWarehouse.1.0.0.nupkg --api-key 07138985-ac04-358d-a5fc-0feb7567c3d0 --source http://h2908727.stratoserver.net:8081/repository/nuget-hosted/

## pull

* dotnet nuget add source http://h2908727.stratoserver.net:8081/repository/nuget-hosted/ -n Nexus -u integrata -p integrata123! --store-password-in-clear-text
* dotnet nuget list source
* dotnet add package BooksWarehouse --version 1.0.0
* in developer container ls /root/vscode/.nuget/package -a