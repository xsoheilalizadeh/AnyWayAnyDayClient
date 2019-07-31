using System;
using System.Threading.Tasks;
using Xunit;

namespace Airline.Test
{
    public class AirlineClientTests
    {
        private AirlineClient _client;

        public AirlineClientTests()
        {
            _client = new AirlineClient();
        }

        [Fact]
        public async Task InitializeQueryAsyncReturnsSuccessResponse()
        {
            // arrange
            var request = CreateValidInitialRequest();

            // act
            var response = await _client.InitializeQueryAsync(request);

            // assert
            Assert.True(response.Succeeded);
            Assert.NotNull(response.Id);
            Assert.Null(response.ErrorMessage);
        }


        [Fact]
        public async Task FaresAsyncReturnsSuccessResponse()
        {
            var request = CreateValidInitialRequest();
            
            var initializeQuery = await _client.InitializeQueryAsync(request);

            var response = await _client.FaresAsync(new FaresRequest(initializeQuery.Id));

            Assert.NotNull(response);
            Assert.True(response.Succeeded);
        }

        [Fact]
        public async Task FareAsyncReturnsSuccessResponse()
        {
            var request = CreateValidInitialRequest();

            var initializeQuery = await _client.InitializeQueryAsync(request);

            var fares = await _client.FaresAsync(new FaresRequest(initializeQuery.Id));

            var fareKey = fares.Arln[0].FareVerbose[0].F;

            var response = await _client.FareAsync(new FareRequest(initializeQuery.Id, fareKey));

            Assert.NotNull(response);
            Assert.True(response.Succeeded);
        }


        private InitialRequest CreateValidInitialRequest()
        {
            var request = new InitialRequest("testapid", FlightClass.Economy);
            request.SetPassengerCount(1);
            request.AddRoute(new Route("lon", "mow", new DateTime(2019, 8, 12)));

            return request;
        }
    }
}