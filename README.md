# coverlet-playground

### Usage
```
-- dotnet test --collect:"XPlat Code Coverage" // Output folder มี GUID มาด้วยเสมอ

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=TestResults/

reportgenerator `
    -reports:"src\MyLibrary.Tests\TestResults\coverage.cobertura.xml" `
    -targetdir:".coverage-report" `
    -reporttypes:Html
```