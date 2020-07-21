using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecast controller = new WeatherForecast();
        [Fact]
        public void GetReturnsMyName()
        {
            WeatherForecast controller = new WeatherForecast();
            var returnValue = controller.Get(1);
            Assert.NotEqual("Prashanth", returnValue);
            Assert.Equal(64, returnValue);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
