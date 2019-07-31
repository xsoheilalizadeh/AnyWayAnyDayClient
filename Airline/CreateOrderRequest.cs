using System.Text;

namespace Airline
{
    public class CreateOrderRequest
    {
        private readonly bool _needMiddleName;

        public CreateOrderRequest(string requestKey, string fareKey, bool needMiddleName, string firstName,
            string lastName, string middleName, string nationality, string birthDate, string documentNumber,
            string documentExpireDate, Gender gender, string frequentFlyerAirline, string frequentFlyerNumber,
            string phoneNumber, string phoneCountry, string userName, string personalEmail)
        {
            _needMiddleName = needMiddleName;
            RequestKey = requestKey;
            FareKey = fareKey;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            Nationality = nationality;
            BirthDate = birthDate;
            PassportNumber = documentNumber;
            PassportExpireDate = documentExpireDate;
            Gender = gender;
            FrequentFlyerAirline = frequentFlyerAirline;
            FrequentFlyerNumber = frequentFlyerNumber;
            PhoneNumber = phoneNumber;
            PhoneCountry = phoneCountry;
            UserName = userName;
            PersonalEmail = personalEmail;
        }

        public string RequestKey { get; set; }

        public string FareKey { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Nationality { get; set; }

        public string BirthDate { get; set; }

        public string PassportNumber { get; set; }

        public string PassportExpireDate { get; set; }

        public Gender Gender { get; set; }

        public string FrequentFlyerAirline { get; set; }

        public string FrequentFlyerNumber { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneCountry { get; set; }

        public string UserName { get; set; }

        public string PersonalEmail { get; set; }

        public override string ToString()
        {
            var requestBuilder = new StringBuilder()
                .Append("api/CreateReservation")
                .Append("?R=").Append(RequestKey)
                .Append("&F=").Append(FareKey)
                .Append("&FName1=").Append(FirstName)
                .Append("&LName1=").Append(LastName)
                .Append("&PCountry1=").Append(Nationality)
                .Append("&BDate1=").Append(BirthDate)
                .Append("&PNumber1=").Append(PassportNumber)
                .Append("&PExpDate1=").Append(PassportExpireDate)
                .Append("&G1=").Append(Gender)
                .Append("&FrequentFlyerAirline1=").Append(FrequentFlyerAirline)
                .Append("&FrequentFlyerNumber1=").Append(FrequentFlyerNumber)
                .Append("&PhoneNumber=").Append(PhoneNumber)
                .Append("&PhoneCountry=").Append(PhoneCountry)
                .Append("&UserName=").Append(UserName)
                .Append("&PersonalEmail=").Append(PersonalEmail);

            if (_needMiddleName)
                requestBuilder.Append("&MName1=").Append(MiddleName);

            return requestBuilder.ToString();
        }
    }
}