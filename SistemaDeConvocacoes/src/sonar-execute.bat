dotnet tool install --global dotnet-sonarscanner
dotnet sonarscanner begin /k:"SistemaDeConvocacoesCore" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="88197a39a5f2c496c8b183d62363d275f0d566e7" /d:sonar.cs.opencover.reportsPaths="%CD%\opencover.xml"
dotnet build
dotnet sonarscanner end /d:sonar.login="88197a39a5f2c496c8b183d62363d275f0d566e7"
pause