using System.Collections.Generic;
using System.Xml.Serialization;

namespace Airline
{
    [XmlRoot(ElementName = "Fare")]
    public class FareResponse : Response
    {
        [XmlElement(ElementName = "Passengers")]
        public Passengers Passengers { get; set; }

        [XmlElement(ElementName = "Airline")]
        public Airline Airline { get; set; }

        [XmlElement(ElementName = "Dir")]
        public List<Dir> Dir { get; set; }

        [XmlElement(ElementName = "ReservationTimeLimit")]
        public ReservationTimeLimit ReservationTimeLimit { get; set; }

        [XmlElement(ElementName = "ASC")]
        public ASC ASC { get; set; }

        [XmlElement(ElementName = "Amount")]
        public Amount Amount { get; set; }

        [XmlAttribute(AttributeName = "Currency")]
        public string Currency { get; set; }

        [XmlAttribute(AttributeName = "Available")]
        public string Available { get; set; }

        [XmlAttribute(AttributeName = "R")]
        public string R { get; set; }

        [XmlAttribute(AttributeName = "F")]
        public string F { get; set; }

        [XmlAttribute(AttributeName = "V")]
        public string V { get; set; }

        [XmlAttribute(AttributeName = "CanMakeReservation")]
        public string CanMakeReservation { get; set; }

        [XmlAttribute(AttributeName = "MM")]
        public string MM { get; set; }

        [XmlAttribute(AttributeName = "MMC")]
        public string MMC { get; set; }

        [XmlAttribute(AttributeName = "CS")]
        public string CS { get; set; }

        [XmlAttribute(AttributeName = "MT")]
        public string MT { get; set; }

        [XmlAttribute(AttributeName = "HB")]
        public string HB { get; set; }

        [XmlAttribute(AttributeName = "TotalAmount")]
        public string TotalAmount { get; set; }

        [XmlAttribute(AttributeName = "TotalAmountNonCeiled")]
        public string TotalAmountNonCeiled { get; set; }

        [XmlAttribute(AttributeName = "NeedMiddleName")]
        public string NeedMiddleName { get; set; }

        [XmlAttribute(AttributeName = "NeedPassportIssueCity")]
        public string NeedPassportIssueCity { get; set; }

        [XmlAttribute(AttributeName = "NeedPassportIssueDate")]
        public string NeedPassportIssueDate { get; set; }

        [XmlAttribute(AttributeName = "MinAvailSeats")]
        public string MinAvailSeats { get; set; }
    }
}