using System;

namespace Airline
{
    public class DuplicateRouteException : Exception
    {
        public DuplicateRouteException() : base("You couldn't have duplicate route")
        {
            
        }
    }
}