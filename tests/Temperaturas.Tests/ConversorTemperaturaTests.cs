using Temperaturas.Api;

namespace Temperaturas.Tests;

public class ConversorTemperaturaTests
{
    [Theory]
    [InlineData(0, 32)]
    [InlineData(100, 212)]
    [InlineData(-40, -40)]
    [InlineData(25, 77)]
    public void ConverteCelsiusParaFahrenheit(double celsius, double esperado)
    {
        Assert.Equal(esperado, ConversorTemperatura.ParaFahrenheit(celsius), 6);
    }
}
