using Newtonsoft.Json;

namespace PROG260_Week5.SampleJSON
{
    public class Student
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set;}

        [JsonProperty("lastName")]
        public string LastName { get; set;}

        [JsonProperty("isEnrolled")]
        public bool IsEnrolled { get; set;}

        [JsonProperty("YearsEnrolled")]
        public int YearsEnrolled { get; set;}

        [JsonProperty("address1")]
        public Address Address1 { get; set;}

        [JsonProperty("address2")]
        public string Address2 { get; set;}

        [JsonProperty("phoneNumbers")]
        List<Phone> PhoneNumbers = new List<Phone>();


        public override string ToString()
        {
            return $"Field #1={FirstName} ==> Field #2={LastName} ==> Field #3={IsEnrolled} ==> Field #4={YearsEnrolled}" 
            + $"{Environment.NewLine}==> Field #5={Address1} ==> Field #6={Address2}"
            + $"{Environment.NewLine}==> Field #7={PhoneNumbers}";
        }
    }

}