using System.Xml.Serialization;

namespace Airline
{
    [XmlRoot(ElementName = "CreateOrder")]
    public class CreateOrderResponse : Response
    {
        [XmlAttribute(AttributeName = "OrderId")]
        public string OrderId { get; set; }

        [XmlAttribute(AttributeName = "OrderStatus")]
        public string OrderStatus { get; set; }

        [XmlAttribute(AttributeName = "OrderAlreadyExists")]
        public string OrderAlreadyExists { get; set; }

        [XmlAttribute(AttributeName = "OrderProcessId")]
        public string OrderProcessId { get; set; }
    }
}