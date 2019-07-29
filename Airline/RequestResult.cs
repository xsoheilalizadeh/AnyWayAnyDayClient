using System;

namespace Airline
{
    public class RequestResult<TResponse> 
    {
        public bool Succeeded { get; set; }

        public TResponse Response { get; private set; }

       
    }
}           