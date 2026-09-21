using Temperaturas.Api;

namespace Temperaturas.Tests;

public class ConversorTemperaturaTests
{
    [Fact]
    public void ConverteZeroCelsiusParaTrintaEDoisFahrenheit()
    {
        Assert.Equal(32, ConversorTemperatura.ParaFahrenheit(0), 6);
    }

    [Fact]
    public void ConverteCemCelsiusParaDuzentosEDozeFahrenheit()
    {
        Assert.Equal(212, ConversorTemperatura.ParaFahrenheit(100), 6);
    }

    [Fact]
    public void ConverteMenosQuarentaCelsiusParaMenosQuarentaFahrenheit()
    {
        Assert.Equal(-40, ConversorTemperatura.ParaFahrenheit(-40), 6);
    }

    [Fact]
    public void ConverteVinteECincoCelsiusParaSetentaESeteFahrenheit()
    {
        Assert.Equal(77, ConversorTemperatura.ParaFahrenheit(25), 6);
    }

    [Fact]
    public void ConverteTemperaturaNegativa()
    {
        Assert.Equal(14, ConversorTemperatura.ParaFahrenheit(-10), 6);
    }

    [Fact]
    public void ConverteTemperaturaDecimal()
    {
        Assert.Equal(68.9, ConversorTemperatura.ParaFahrenheit(20.5), 6);
    }
}
