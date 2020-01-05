using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnWeatherBySummary()
        {
        //Given
        var returnValue = controller.Get(1);
        Assert.Equal("Sunkanmi Ijatuyi", returnValue.Value);
        //When

        //Then
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
