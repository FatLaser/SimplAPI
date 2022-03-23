using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.TEST;

public class UnitTest1
{
    WeatherForecast controller = new WeatherForecast();

    [Fact]
    public void GetmyWeatherForecast()
    {
        var returnValue = controller.Summary;
    }


    [Fact]
    public void Test1()
    {

    }
}