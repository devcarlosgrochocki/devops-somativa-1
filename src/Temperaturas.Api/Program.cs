using Temperaturas.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "API de conversão de temperatura");

app.MapGet("/converter", (double celsius) =>
    double.IsFinite(celsius)
        ? Results.Ok(new ConversaoResultado(celsius, ConversorTemperatura.ParaFahrenheit(celsius)))
        : Results.BadRequest("Informe uma temperatura válida."));

app.Run();

record ConversaoResultado(double Celsius, double Fahrenheit);
