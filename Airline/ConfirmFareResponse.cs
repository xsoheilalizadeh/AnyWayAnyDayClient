using System.Xml.Serialization;

namespace Airline
{
    [XmlRoot(ElementName = "ConfirmFare")]
    public class ConfirmFareResponse : Response
    {
        [XmlAttribute(AttributeName = "R")]
        public string R { get; set; }

        [XmlAttribute(AttributeName = "F")]
        public string F { get; set; }

        [XmlAttribute(AttributeName = "Confirmed")]
        public string Confirmed { get; set; }
    }
}