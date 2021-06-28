dotnet new sln -n CorePart1 

dotnet new console -lang c# -n SimpleCSharpApp -o .\SimpleCSharpApp -f net5.0
dotnet sln .\CorePart1n add .\SimpleCSharpApp

dotnet new console -lang c# -n BasicConsoleIO -o .\BasicConsoleIO -f net5.0
dotnet sln .\CorePart1n add .\BasicConsoleIO

dotnet new console -lang c# -n BasicDataTypes -o .\BasicDataTypes -f net5.0
dotnet sln .\CorePart1n add .\BasicDataTypes

dotnet new console -lang c# -n FunWithStrings -o .\FunWithStrings -f net5.0
dotnet sln .\CorePart1n add .\FunWithStrings

dotnet new console -lang c# -n TypeConversions -o .\TypeConversions  -f net5.0
dotnet sln .\CorePart1n add .\TypeConversions

dotnet new console -lang c# -n ImplicitlyTypedLocalVars -o .\ImplicitlyTypedLocalVars -f net5.0
dotnet sln .\CorePart1n add .\ImplicitlyTypedLocalVars

dotnet new console -lang c# -n IterationsAndDecisions -o .\IterationsAndDecisions -f net5.0
dotnet sln .\CorePart1n add .\IterationsAndDecisions

pause
