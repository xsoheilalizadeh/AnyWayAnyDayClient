using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Airline
{
    public class InitialRequest
    {
        public IList<Route> Routes { get; private set; } = new List<Route>();

        public string Partner { get; set; }

        public int AdultCount { get; private set; }

        public int ChildCount { get; private set; }

        public int InfantCount { get; private set; }

        public FlightClass Class { get; set; }

        public bool HasRoute => Routes.Any();

        public void AddRoute(Route route)
        {
            if (route == null)
            {
                throw new NullReferenceException(nameof(route));
            }

            if (IsDuplicateRoute(route))
            {
                throw new DuplicateRouteException();
            }

            if (!route.IsValid())
            {
                throw new InvalidRouteException(route);
            }

            Routes.Add(route);
        }

        public InitialRequest Build() => this;

        public void SetPartner(string partner) => Partner = partner;

        public void SetClass(FlightClass @class) => Class = @class;

        public void SetPassengerCount(int adultCount = 1, int childCount = 0, int infantCount = 0)
        {
            var passengerCount = adultCount + childCount + infantCount;

            if (passengerCount > 8 || passengerCount <= 0)
            {
                throw new OutOfRandPassengerCount();
            }

            AdultCount = adultCount;
            ChildCount = childCount;
            InfantCount = infantCount;
        }


        public override string ToString()
        {
            var requestBuilder = new StringBuilder()
                .Append("api/newrequest/")
                .Append("?Partner=").Append(Partner)
                .Append("&Route=").Append(GetFormattedRoute())
                .Append("&AD=").Append(AdultCount)
                .Append("&CN=").Append(ChildCount)
                .Append("&IN=").Append(InfantCount)
                .Append("&SC=").Append(GetFormattedClass());

            return requestBuilder.ToString();
        }

        private string GetFormattedClass()
        {
            switch (Class)
            {
                case FlightClass.Business:
                case FlightClass.First:
                    return "B";
                case FlightClass.Economy:
                    return "E";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private string GetFormattedRoute()
        {
            var routes = Routes.Select(r => r.ToString()).ToList();

            return string.Join(string.Empty, routes);
        }

        private bool IsDuplicateRoute(Route route)
        {
            return Routes.Any(r => r.ToString() == route.ToString());
        }
    }
}