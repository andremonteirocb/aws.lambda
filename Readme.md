
## Configurações
### Instale Amazon.Lambda.Tools Global Tools se ainda não estiver instalado.
```
    dotnet tool install -g Amazon.Lambda.Tools
```

### Verifique se a nova versão está disponível.
```
    dotnet tool update -g Amazon.Lambda.Tools
```

### Execute os testes de unidade
```
    cd "Fundamentos.AWS.Lambda/test/Fundamentos.AWS.Lambda.Tests"
    dotnet test
```

### Implantar função para AWS Lambda
```
    cd "Fundamentos.AWS.Lambda/src/Fundamentos.AWS.Lambda"
    dotnet lambda deploy-function
```
