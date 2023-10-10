using System.Text.Json.Serialization;

namespace PROG260_Week5.SampleJSON
{
    [JsonSerializable(typeof(Student))]
    public class Student
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set;}

        [JsonPropertyName("lastName")]
        public string LastName { get; set;}

        [JsonPropertyName("isEnrolled")]
        public bool IsEnrolled { get; set;}

        [JsonPropertyName("YearsEnrolled")]
        public int YearsEnrolled { get; set;}

        [JsonPropertyName("address1")]
        public Address Address1 { get; set;}

        [JsonPropertyName("address2")]
        public string Address2 { get; set;}

        [JsonPropertyName("phoneNumbers")]
        List<Phone> PhoneNumbers { get; set;}

        [JsonConstructor]
        public Student(string firstName, string lastname, bool isenrolled, int yearsenrolled, 
            Address address1, string address2, List<Phone> phonenumbers) => 
            (FirstName, LastName, IsEnrolled, YearsEnrolled, Address1, Address2, PhoneNumbers) =
            (firstName, lastname, isenrolled, yearsenrolled, address1, address2, phonenumbers);


        public override string ToString()
        {
            return $"Field #1={FirstName} ==> Field #2={LastName} ==> Field #3={IsEnrolled} ==> Field #4={YearsEnrolled}" 
            + $" ==> Field #5={Address1} ==> Field #6={Address2}"
            + $" ==> Field #7={PhoneNumbers}";
        }
    }

}