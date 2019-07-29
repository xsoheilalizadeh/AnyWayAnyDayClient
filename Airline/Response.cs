using System.Xml.Serialization;

namespace Airline
{
    public class Response
    {
        public bool Succeeded => string.IsNullOrEmpty(ErrorMessage) || string.IsNullOrWhiteSpace(ErrorMessage);
        
        [XmlAttribute("Error")]
        public string ErrorMessage { get; set; }

        public T Failed<T>(string errorMessage) where T : Response, new()
        {
            return new T
            {
                ErrorMessage = errorMessage
            };
        }
    }
}