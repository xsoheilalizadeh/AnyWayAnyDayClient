using System.Text;

namespace Airline
{
    public class FaresRequest
    {
        public FaresRequest(string requestKey,
            FlightType? flightType = null,
            PriceType? priceType = null,
            Language language = Language.EN,
            Currency currency = Currency.USD,
            Sorting sorting = Sorting.Price,
            string airportDeparture = null,
            string airportArrival = null,
            int? pageSize = null,
            int? pageNumber = null,
            FlyTime? departureTime = null,
            FlyTime? arrivalTime = null)
        {
            RequestKey = requestKey;
            Language = language;
            Currency = currency;
            Sorting = sorting;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            AirportDeparture = airportDeparture;
            AirportArrival = airportArrival;
            PageSize = pageSize;
            PageNumber = pageNumber;
            FlightType = flightType;
            PriceType = priceType;
        }

        public string RequestKey { get; set; }

        public Language Language { get; set; }

        public Currency Currency { get; set; }

        public Sorting Sorting { get; set; }

        public FlyTime? DepartureTime { get; set; }

        public FlyTime? ArrivalTime { get; set; }

        public string AirportDeparture { get; set; }

        public string AirportArrival { get; set; }

        public int? PageSize { get; set; }

        public int? PageNumber { get; set; }

        public FlightType? FlightType { get; set; }

        public PriceType? PriceType { get; set; }

        public override string ToString()
        {
            var requestBuilder = new StringBuilder()
                .Append("api/Fares/")
                .Append("?R=").Append(RequestKey)
                .Append("&V=Matrix")
                .Append("&L=").Append(Language)
                .Append("&C=").Append(Currency)
                .Append("&S=").Append(Sorting)
                .Append("&VB=true");

            if (DepartureTime != null)
                requestBuilder.Append("&DT1=").Append(DepartureTime);

            if (AirportArrival != null)
                requestBuilder.Append("&AT1=").Append(AirportArrival);

            if (AirportDeparture != null)
                requestBuilder.Append("&DA1=").Append(AirportDeparture);

            if (AirportArrival != null)
                requestBuilder.Append("&AA1=").Append(AirportArrival);

            if (PageSize != null)
                requestBuilder.Append("&PS=").Append(PageSize);

            if (PageNumber != null)
                requestBuilder.Append("&PN=").Append(PageNumber);

            if (FlightType != null)
                requestBuilder.Append("&CT=").Append(FlightType);

            if (PriceType != null)
                requestBuilder.Append("&PT=").Append(PriceType);
            
            return requestBuilder.ToString();
        }
    }

    public enum PriceType
    {
        All,
        Adult
    }

    public enum FlightType
    {
        All,
        Direct
    }

    public enum FlyTime
    {
        Night,
        Morning,
        Afternoon,
        Evening
    }

    public enum Sorting
    {
        Price,
        Time
    }

    public enum Currency
    {
        RUB,
        USD,
        EUR,
        CHF,
        UAH
    }

    public enum Language
    {
        EN,
        RU
    }
}