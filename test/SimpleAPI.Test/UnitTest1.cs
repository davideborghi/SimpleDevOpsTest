using System;
using SimpleAPI.Controllers;
using Xunit;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetReturnMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Davide Borghi", returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
