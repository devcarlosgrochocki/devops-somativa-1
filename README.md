# API de temperaturas

API pequena em ASP.NET Core para converter Celsius em Fahrenheit.

## Executar localmente

```bash
dotnet run --project src/Temperaturas.Api --no-launch-profile --urls http://localhost:5087
```

Acesse `http://localhost:5087/converter?celsius=25`. A resposta contém `celsius: 25` e `fahrenheit: 77`.

## Testes

```bash
dotnet test Temperaturas.sln
```

## Docker

```bash
docker build -t temperaturas-api .
docker run -d --name temperaturas-api -p 8080:8080 temperaturas-api
docker ps
```

A API fica em `http://localhost:8080/converter?celsius=25`.
