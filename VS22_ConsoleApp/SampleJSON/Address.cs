using System.Text.Json.Serialization;

namespace PROG260_Week5.SampleJSON
{
    [JsonSerializable(typeof(Address))]
    public class Address
    {
        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set;}

        [JsonPropertyName("city")]
        public string City { get; set;}

        [JsonPropertyName("state")]
        public string State { get; set;}

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set;}

        [JsonConstructor]
        public Address(string streetAddress, string city, string state, string postalCode) =>
            (StreetAddress, City, State, PostalCode) = (streetAddress, city, state, postalCode);

        public override string ToString()
        {
            return $"Field #1={StreetAddress} ==> Field #2={City} ==> Field #3={State} ==> Field #4={PostalCode}";
        }
    }

}