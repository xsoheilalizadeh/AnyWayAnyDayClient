using System;
using System.Threading.Tasks;

namespace Airline.Sample
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            var initialization = await QueryInitializationAsync();

            using (var client = new AirlineClient())
            {
                var request = new FaresRequest(initialization.Id);

                var response = await client.FaresAsync(request);

                Console.WriteLine($"[Search result]: {response.Arln.Count} airlines found.");

                foreach (var airline in response.Arln)
                {
                    Console.WriteLine($"The {airline.N} found {airline.FareVerbose.Count} fares.");
                    foreach (var fare in airline.FareVerbose)
                    {
                        Console.WriteLine($"Fare - [Id: {fare.F} TotalAmount:${fare.TotalAmount}]");
                    }
                }
            }
        }

        /// <summary>
        /// {host}/api/NewRequest
        /// </summary>
        /// <returns></returns>
        private static async Task<InitialResponse> QueryInitializationAsync()
        {
            using (var client = new AirlineClient())
            {
                var request = new InitialRequest("testapid", FlightClass.Economy);
                
                request.SetPassengerCount(1);
                request.AddRoute(new Route("lon", "mow", new DateTime(2019, 8, 12)));

                var response = await client.InitializeQueryAsync(request);

                Console.WriteLine($"[Query initialization]: NewRequest is {response.Id}\n");

                return response;
            }
        }
    }
}