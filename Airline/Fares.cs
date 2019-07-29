using System.Collections.Generic;
using System.Xml.Serialization;

namespace Airline
{
    [XmlRoot(ElementName = "BrdCng")]
    public class BrdCng
    {
        [XmlElement(ElementName = "V")]
        public List<string> V { get; set; }
    }

    [XmlRoot(ElementName = "DepTm")]
    public class DepTm
    {
        [XmlElement(ElementName = "V")]
        public List<string> V { get; set; }
    }

    [XmlRoot(ElementName = "ArrTm")]
    public class ArrTm
    {
        [XmlElement(ElementName = "V")]
        public List<string> V { get; set; }
    }

    [XmlRoot(ElementName = "DepApt")]
    public class DepApt
    {
        [XmlElement(ElementName = "V")]
        public List<string> V { get; set; }
    }

    [XmlRoot(ElementName = "ArrApt")]
    public class ArrApt
    {
        [XmlElement(ElementName = "V")]
        public List<string> V { get; set; }
    }

    [XmlRoot(ElementName = "Dir")]
    public class Dir
    {
        [XmlElement(ElementName = "BrdCng")]
        public BrdCng BrdCng { get; set; }

        [XmlElement(ElementName = "DepTm")]
        public DepTm DepTm { get; set; }

        [XmlElement(ElementName = "ArrTm")]
        public ArrTm ArrTm { get; set; }

        [XmlElement(ElementName = "DepApt")]
        public DepApt DepApt { get; set; }

        [XmlElement(ElementName = "ArrApt")]
        public ArrApt ArrApt { get; set; }

        [XmlElement(ElementName = "Variant")]
        public List<Variant> Variant { get; set; }

        [XmlAttribute(AttributeName = "SDI")]
        public string SDI { get; set; }

        [XmlAttribute(AttributeName = "SDPI")]
        public string SDPI { get; set; }
    }

    [XmlRoot(ElementName = "Filter")]
    public class Filter
    {
        [XmlElement(ElementName = "Dir")]
        public List<Dir> Dir { get; set; }
    }

    [XmlRoot(ElementName = "Passengers")]
    public class Passengers
    {
        [XmlAttribute(AttributeName = "Adults")]
        public string Adults { get; set; }

        [XmlAttribute(AttributeName = "Children")]
        public string Children { get; set; }

        [XmlAttribute(AttributeName = "Infants")]
        public string Infants { get; set; }
    }

    [XmlRoot(ElementName = "Airline")]
    public class Airline
    {
        [XmlAttribute(AttributeName = "C")]
        public string C { get; set; }

        [XmlAttribute(AttributeName = "N")]
        public string N { get; set; }
    }

    [XmlRoot(ElementName = "Plane")]
    public class Plane
    {
        [XmlAttribute(AttributeName = "C")]
        public string C { get; set; }

        [XmlAttribute(AttributeName = "N")]
        public string N { get; set; }
    }

    [XmlRoot(ElementName = "Departure")]
    public class Departure
    {
        [XmlAttribute(AttributeName = "Code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "Contry")]
        public string Contry { get; set; }

        [XmlAttribute(AttributeName = "City")]
        public string City { get; set; }

        [XmlAttribute(AttributeName = "Airport")]
        public string Airport { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }

        [XmlAttribute(AttributeName = "Time")]
        public string Time { get; set; }

        [XmlAttribute(AttributeName = "DayOfWeek")]
        public string DayOfWeek { get; set; }

        [XmlAttribute(AttributeName = "Terminal")]
        public string Terminal { get; set; }
    }

    [XmlRoot(ElementName = "Arrival")]
    public class Arrival
    {
        [XmlAttribute(AttributeName = "Code")]
        public string Code { get; set; }

        [XmlAttribute(AttributeName = "Contry")]
        public string Contry { get; set; }

        [XmlAttribute(AttributeName = "City")]
        public string City { get; set; }

        [XmlAttribute(AttributeName = "Airport")]
        public string Airport { get; set; }

        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }

        [XmlAttribute(AttributeName = "Time")]
        public string Time { get; set; }

        [XmlAttribute(AttributeName = "DayOfWeek")]
        public string DayOfWeek { get; set; }

        [XmlAttribute(AttributeName = "Terminal")]
        public string Terminal { get; set; }
    }

    [XmlRoot(ElementName = "Baggage")]
    public class Baggage
    {
        [XmlAttribute(AttributeName = "QuantityAndWeightType")]
        public string QuantityAndWeightType { get; set; }

        [XmlAttribute(AttributeName = "Quantity")]
        public string Quantity { get; set; }

        [XmlAttribute(AttributeName = "Weight")]
        public string Weight { get; set; }

        [XmlAttribute(AttributeName = "WeightMeasuringUnitType")]
        public string WeightMeasuringUnitType { get; set; }
    }

    [XmlRoot(ElementName = "Leg")]
    public class Leg
    {
        [XmlElement(ElementName = "Plane")]
        public Plane Plane { get; set; }

        [XmlElement(ElementName = "Departure")]
        public Departure Departure { get; set; }

        [XmlElement(ElementName = "Arrival")]
        public Arrival Arrival { get; set; }

        [XmlElement(ElementName = "Baggage")]
        public Baggage Baggage { get; set; }

        [XmlAttribute(AttributeName = "SC")]
        public string SC { get; set; }

        [XmlAttribute(AttributeName = "BC")]
        public string BC { get; set; }

        [XmlAttribute(AttributeName = "FN")]
        public string FN { get; set; }

        [XmlAttribute(AttributeName = "FT")]
        public string FT { get; set; }

        [XmlAttribute(AttributeName = "ET")]
        public string ET { get; set; }

        [XmlElement(ElementName = "Carrier")]
        public Carrier Carrier { get; set; }
    }

    [XmlRoot(ElementName = "Variant")]
    public class Variant
    {
        [XmlElement(ElementName = "Leg")]
        public List<Leg> Leg { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "TT")]
        public string TT { get; set; }
    }

    [XmlRoot(ElementName = "ReservationTimeLimit")]
    public class ReservationTimeLimit
    {
        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }

        [XmlAttribute(AttributeName = "Time")]
        public string Time { get; set; }
    }

    [XmlRoot(ElementName = "C")]
    public class C
    {
        [XmlElement(ElementName = "S")]
        public List<string> S { get; set; }
    }

    [XmlRoot(ElementName = "ASC")]
    public class ASC
    {
        [XmlElement(ElementName = "C")]
        public List<C> C { get; set; }
    }

    [XmlRoot(ElementName = "Amount")]
    public class Amount
    {
        [XmlAttribute(AttributeName = "ABase")]
        public string ABase { get; set; }

        [XmlAttribute(AttributeName = "ATaxes")]
        public string ATaxes { get; set; }

        [XmlAttribute(AttributeName = "ATotal")]
        public string ATotal { get; set; }

        [XmlAttribute(AttributeName = "CBase")]
        public string CBase { get; set; }

        [XmlAttribute(AttributeName = "CTaxes")]
        public string CTaxes { get; set; }

        [XmlAttribute(AttributeName = "CTotal")]
        public string CTotal { get; set; }

        [XmlAttribute(AttributeName = "IBase")]
        public string IBase { get; set; }

        [XmlAttribute(AttributeName = "ITaxes")]
        public string ITaxes { get; set; }

        [XmlAttribute(AttributeName = "ITotal")]
        public string ITotal { get; set; }
    }

    [XmlRoot(ElementName = "FareVerbose")]
    public class FareVerbose
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

        [XmlAttribute(AttributeName = "F")]
        public string F { get; set; }

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

    [XmlRoot(ElementName = "Arln")]
    public class Arln
    {
        [XmlElement(ElementName = "FareVerbose")]
        public List<FareVerbose> FareVerbose { get; set; }

        [XmlAttribute(AttributeName = "C")]
        public string C { get; set; }

        [XmlAttribute(AttributeName = "N")]
        public string N { get; set; }
    }

    [XmlRoot(ElementName = "Carrier")]
    public class Carrier
    {
        [XmlAttribute(AttributeName = "C")]
        public string C { get; set; }

        [XmlAttribute(AttributeName = "N")]
        public string N { get; set; }
    }

    [XmlRoot(ElementName = "Referenses")]
    public class Referenses
    {
        [XmlElement(ElementName = "Airline")]
        public List<Airline> Airline { get; set; }
    }

    [XmlRoot(ElementName = "Fares")]
    public class FaresResponse : Response
    {
        [XmlElement(ElementName = "Filter")]
        public Filter Filter { get; set; }

        [XmlElement(ElementName = "Arln")]
        public List<Arln> Arln { get; set; }

        [XmlElement(ElementName = "Referenses")]
        public Referenses Referenses { get; set; }

        [XmlElement(ElementName = "SearchRequestURL")]
        public string SearchRequestURL { get; set; }

        [XmlAttribute(AttributeName = "C")]
        public string C { get; set; }

        [XmlAttribute(AttributeName = "L")]
        public string L { get; set; }

        [XmlAttribute(AttributeName = "SortBy")]
        public string SortBy { get; set; }

        [XmlAttribute(AttributeName = "ViewType")]
        public string ViewType { get; set; }

        [XmlAttribute(AttributeName = "R")]
        public string R { get; set; }

        [XmlAttribute(AttributeName = "PN")]
        public string PN { get; set; }

        [XmlAttribute(AttributeName = "PS")]
        public string PS { get; set; }

        [XmlAttribute(AttributeName = "PT")]
        public string PT { get; set; }

        [XmlAttribute(AttributeName = "CT")]
        public string CT { get; set; }
    }
}