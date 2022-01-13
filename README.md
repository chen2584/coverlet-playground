# coverlet-playground

### Usage
```
-- dotnet test --collect:"XPlat Code Coverage" // Output folder มี GUID มาด้วยเสมอ

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=TestResult/

reportgenerator `
    -reports:"src\MyLibrary.Tests\TestResults\coverage.cobertura.xml" `
    -targetdir:".coverage-report" `
    -reporttypes:Html
```

### With Sonarqube
dotnet sonarscanner begin /k:"dotnet-sonarqube-playground" /d:sonar.host.url="http://localhost:9000"  /d:sonar.login="xxx" /d:sonar.cs.opencover.reportsPaths="src/MyLibrary.Tests/TestResult/coverage.opencover.xml"
dotnet build
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput=TestResult/
dotnet sonarscanner end /d:sonar.login="xxx"