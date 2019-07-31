using System;
using System.Threading.Tasks;

namespace Airline
{
    public interface IAirlineClient : IDisposable
    {
        Task<InitialResponse> InitializeQueryAsync(InitialRequest request);

        Task<FaresResponse> FaresAsync(FaresRequest request);

        Task<FareResponse> FareAsync(FareRequest request);

        Task<ConfirmFareResponse> ConfirmFareAsync(ConfirmFareRequest request);

        Task<CreateOrderResponse> CreateOrderAsync(CreateOrderRequest request);
    }
}