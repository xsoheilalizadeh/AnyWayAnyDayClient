using System;
using System.Collections.Generic;
using Xunit;

namespace Airline.Test
{
    public class RouteTests
    {
        [Theory, MemberData(nameof(CorrectData))]
        public void RouteToStringReturnsExpectedFormat(string origin, string destination, DateTime departureOn,
            string expected)
        {
            var route = new Route(origin, destination, departureOn);

            Assert.True(route.IsValid());
            Assert.NotNull(route.ToString());
            Assert.Equal(10,route.ToString().Length);
            Assert.Equal(expected,route.ToString());
        }

        public static IEnumerable<object[]> CorrectData
        {
            get
            {
                return new[]
                {
                    new object[] {"thr", "mhd", new DateTime(2019, 2, 5),  "0502thrmhd"},
                    new object[] {"mhd", "thr", new DateTime(2019, 12, 5), "0512mhdthr"},
                    new object[] {"mhd", "thr", new DateTime(2019, 2, 11), "1102mhdthr"},
                };
            }
        }
    }
}