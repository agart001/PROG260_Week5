using System.Xml.Serialization;

namespace PROG260_Week5.SampleXML
{
    [XmlRoot(ElementName = "item")]
    public class GroceryItem
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "price")]
        public double Price { get; set; }

        [XmlElement(ElementName = "uom")]
        public string UoM { get; set; }


        public override string ToString()
        {
            return $"Field #1={Name} ==> Field #2={Price} ==> Field #3={UoM}";
        }
    }
}