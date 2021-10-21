
Install Amazon.Lambda.Tools Global Tools if not already installed.
```
    dotnet tool install -g Amazon.Lambda.Tools
```

If already installed check if new version is available.
```
    dotnet tool update -g Amazon.Lambda.Tools
```

Execute unit tests
```
    cd "Fundamentos.AWS.Lambda/test/Fundamentos.AWS.Lambda.Tests"
    dotnet test
```

Deploy function to AWS Lambda
```
    cd "Fundamentos.AWS.Lambda/src/Fundamentos.AWS.Lambda"
    dotnet lambda deploy-function
```
