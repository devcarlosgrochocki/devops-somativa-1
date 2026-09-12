namespace Temperaturas.Api;

public static class ConversorTemperatura
{
    public static double ParaFahrenheit(double celsius) => celsius * 9 / 5 + 32;
}
