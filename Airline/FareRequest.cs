using System.Text;

namespace Airline
{
    public class FareRequest
    {
        public FareRequest(string requestKey, string fareKey, Language language = Language.EN,
            Currency currency = Currency.USD)
        {
            RequestKey = requestKey;
            FareKey = fareKey;
            Language = language;
            Currency = currency;
        }

        public string RequestKey { get; set; }

        public string FareKey { get; set; }

        public Language Language { get; set; }

        public Currency Currency { get; set; }

        public override string ToString()
        {
            var requestBuilder = new StringBuilder()
                .Append("api/Fare/")
                .Append("?R=").Append(RequestKey)
                .Append("&F=").Append(FareKey)
                .Append("&L=").Append(Language)
                .Append("&C=").Append(Currency);

            return requestBuilder.ToString();
        }
    }
}