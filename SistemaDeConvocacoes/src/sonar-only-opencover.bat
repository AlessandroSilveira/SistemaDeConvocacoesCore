%USERPROFILE%\.nuget\packages\opencover\4.7.1221\tools\OpenCover.Console.exe -output:"%CD%\opencover.xml" -register:user -target:"C:\Program Files\dotnet\dotnet.exe" -targetargs:"test C:\Users\alesi\source\repos\SistemaDeConvocacoesCore\SistemaDeConvocacoes\src\SistemaDeConvocacoes.Tests\SistemaDeConvocacoes.Tests.csproj" -oldstyle
dotnet sonarscanner end /d:sonar.login="88197a39a5f2c496c8b183d62363d275f0d566e7"
pause