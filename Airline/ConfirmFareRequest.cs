using System.Text;

namespace Airline
{
    public class ConfirmFareRequest
    {
        public string RequestKey { get; set; }

        public string FareKey { get; set; }

        public override string ToString()
        {
            var requestBuilder = new StringBuilder()
                .Append("api/ConfirmFare")
                .Append("?R=").Append(RequestKey)
                .Append("&F=").Append(FareKey);

            return requestBuilder.ToString();
        }
    }
}