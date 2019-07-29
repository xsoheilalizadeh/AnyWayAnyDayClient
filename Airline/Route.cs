using System;
using System.Text;

namespace Airline
{
    public class Route
    {
        public Route(string origin, string destination, DateTime departureOn)
        {
            Origin = origin;
            Destination = destination;
            DepartureOn = departureOn;
        }
        
        public string Origin { get; set; }

        public string Destination { get; set; }

        public DateTime DepartureOn { get; set; }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Origin))
                return false;
            
            if (string.IsNullOrEmpty(Destination))
                return false;

            if (ToString().Length != 10)
                return false;

            return true;
        }

        public override string ToString()
        {
            var routeBuilder = new StringBuilder()
                .Append(DepartureOn.ToString("dd"))
                .Append(DepartureOn.ToString("MM"))
                .Append(Origin)
                .Append(Destination);

            return routeBuilder.ToString();
        }
    }
}