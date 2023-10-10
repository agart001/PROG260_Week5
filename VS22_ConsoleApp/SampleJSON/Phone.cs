using Newtonsoft.Json;

namespace PROG260_Week5.SampleJSON
{

    public class Phone
    {
        [JsonProperty("type")]
        public string Type { get; set;}

        [JsonProperty("number")]
        public string Number { get; set;}

        [JsonProperty("CanContact")]
        public bool canContact { get; set;}
   

        public override string ToString()
        {
            return $"Field #1={Type} ==> Field #2={Number} ==> Field #3={canContact}";
        }
    }

}