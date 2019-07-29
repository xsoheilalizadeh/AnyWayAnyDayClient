using System;

namespace Airline
{
    public class InvalidRouteException : Exception
    {
        public InvalidRouteException(string formattedRoute) : base($"the ({formattedRoute}) route format is invalid")
        {
            
        }
        
        public InvalidRouteException(Route route) : base($"the ({route}) route format is invalid")
        {
            
        }
    }
}