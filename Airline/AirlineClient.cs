using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Airline
{
    public class AirlineClient : IAirlineClient
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private readonly Uri _baseUri = new Uri("https://api.anywayanyday.com");

        public AirlineClient()
        {
            _httpClientFactory = new HttpClientFactory();
        }

        public HttpClient Client => _httpClientFactory.GetOrCreate(_baseUri);


        public Task<InitialResponse> InitializeQueryAsync(InitialRequest request)
        {
            if (request == null)
            {
                throw new NullReferenceException(nameof(request));
            }

            if (!request.HasRoute)
            {
                throw new InvalidOperationException("The request hasn't any route");
            }

            return GetInitializeQueryAsync(request);
        }

        public Task<FaresResponse> FaresAsync(FaresRequest request)
        {
            if (request == null)
            {
                throw new NullReferenceException(nameof(request));
            }

            return GetFaresAsync(request);
        }

        public Task<FareResponse> FareAsync(FareRequest request)
        {
            if (request == null)
            {
                throw new NullReferenceException(nameof(request));
            }

            return GetFareAsync(request);
        }

        public Task<ConfirmFareResponse> ConfirmFareAsync(ConfirmFareRequest request)
        {
            if (request == null)
            {
                throw new NullReferenceException(nameof(request));
            }

            return GetConfirmFareAsync(request);
        }

        private Task<ConfirmFareResponse> GetConfirmFareAsync(ConfirmFareRequest request)
        {
            var requestUrl = request.ToString();

            return GetAsync<ConfirmFareResponse>(requestUrl);
        }

        private Task<FareResponse> GetFareAsync(FareRequest request)
        {
            var requestUrl = request.ToString();

            return GetAsync<FareResponse>(requestUrl);
        }

        private Task<FaresResponse> GetFaresAsync(FaresRequest request)
        {
            var requestUrl = request.ToString();

            return GetAsync<FaresResponse>(requestUrl);
        }

        private Task<InitialResponse> GetInitializeQueryAsync(InitialRequest request)
        {
            var requestUrl = request.ToString();

            return GetAsync<InitialResponse>(requestUrl);
        }
        
        private async Task<TResponse> GetAsync<TResponse>(string url) where TResponse : Response, new()
        {
            var result = new TResponse();
            using (var response = await Client.GetAsync(url).ConfigureAwait(false))
            {
                if (!response.IsSuccessStatusCode)
                {
                    return result.Failed<TResponse>(response.StatusCode.ToString());
                }

                return await response.Content.ReadAsync<TResponse>().ConfigureAwait(false);
            }
        }
    }
}