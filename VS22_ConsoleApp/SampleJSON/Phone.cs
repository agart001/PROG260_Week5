using System.Text.Json.Serialization;

namespace PROG260_Week5.SampleJSON
{
    [JsonSerializable(typeof(Phone))]
    public class Phone
    {
        [JsonPropertyName("type")]
        public string Type { get; set;}

        [JsonPropertyName("number")]
        public string Number { get; set;}

        [JsonPropertyName("CanContact")]
        public bool canContact { get; set;}

        [JsonConstructor]
        public Phone(string type, string number, bool CanContact) =>
            (Type, Number, canContact) = (type, number, CanContact);
   

        public override string ToString()
        {
            return $"Field #1={Type} ==> Field #2={Number} ==> Field #3={canContact}";
        }
    }

}