dotnet new sln -n CorePart2 

dotnet new console -lang c# -n FunWithArrays -o .\FunWithArrays -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithArrays

dotnet new console -lang c# -n FunWithLocalFunctions -o .\FunWithLocalFunctions -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithLocalFunctions

dotnet new console -lang c# -n FunWithMethods -o .\FunWithMethods -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithMethods

dotnet new console -lang c# -n FunWithMethodOverloading -o .\FunWithMethodOverloading -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithMethodOverloading

dotnet new console -lang c# -n FunWithEnums -o .\FunWithEnums -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithEnums

dotnet new console -lang c# -n FunWithBitwiseOperations -o .\FunWithBitwiseOperations -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithBitwiseOperations

dotnet new console -lang c# -n FunWithStructures -o .\FunWithStructures  -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithStructures

dotnet new console -lang c# -n FunWithValueAndReferenceTypes -o .\FunWithValueAndReferenceTypes -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithValueAndReferenceTypes

dotnet new console -lang c# -n FunWithRefTypeValTypeParams -o .\FunWithRefTypeValTypeParams -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithRefTypeValTypeParams

dotnet new console -lang c# -n FunWithNullableReferenceTypes -o .\FunWithNullableReferenceTypes -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithNullableReferenceTypes

dotnet new console -lang c# -n FunWithNullableValueTypes -o .\FunWithNullableValueTypes -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithNullableValueTypes

dotnet new console -lang c# -n FunWithTuples -o .\FunWithTuples -f net5.0
dotnet sln .\CorePart2.sln add .\FunWithTuples


pause
