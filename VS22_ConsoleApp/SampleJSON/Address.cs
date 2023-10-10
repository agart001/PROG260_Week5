using Newtonsoft.Json;

namespace PROG260_Week5.SampleJSON
{
    public class Address
    {
        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set;}

        [JsonProperty("city")]
        public string City { get; set;}

        [JsonProperty("state")]
        public string State { get; set;}

        [JsonProperty("postalCode")]
        public string PostalCode { get; set;}

        public override string ToString()
        {
            return $"Field #1={StreetAddress} ==> Field #2={City} ==> Field #3={State} ==> Field #4={PostalCode}";
        }
    }

}