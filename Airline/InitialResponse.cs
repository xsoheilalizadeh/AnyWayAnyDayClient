using System.Xml.Serialization;

namespace Airline
{
    [XmlRoot(ElementName = "NewRequest")]
    public class InitialResponse : Response
    {
        [XmlAttribute(AttributeName = "Id")] public string Id { get; set; }
    }
}