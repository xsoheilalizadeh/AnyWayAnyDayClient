using System;

namespace Airline
{
    public class OutOfRandPassengerCount : Exception
    {
        public OutOfRandPassengerCount() : base("Your passengers count is out of rand it must be more than 0 and lesser than 8")
        {
            
        }
    }
}