FROM mcr.microsoft.com/dotnet/sdk:10.0-alpine AS build
WORKDIR /app

COPY src/Temperaturas.Api/Temperaturas.Api.csproj src/Temperaturas.Api/
RUN dotnet restore src/Temperaturas.Api/Temperaturas.Api.csproj

COPY src/Temperaturas.Api/ src/Temperaturas.Api/
RUN dotnet publish src/Temperaturas.Api/Temperaturas.Api.csproj -c Release -o /app/publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0-alpine
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "Temperaturas.Api.dll"]
